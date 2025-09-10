using ShopCartApp.Entities;
using ShopCartApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopCartApp.Implementations
{
    public class Cart : ICart
    {
        private IList<CartProduct> _items = new List<CartProduct>();

        public void Add(CartProduct product)
        {
            var item = GetIfExists(product.Id);

            if (item == null)
                _items.Add(product);
            else
                item.Quantity += item.Quantity;
        }

        public IEnumerable<CartProduct> GetAll()
        {
            return _items;
        }

        public void Remove(Guid productId, int quantity)
        {
            var item = GetIfExists(productId);

            if(item == null)
                throw new DllNotFoundException($"Cannot find product '{productId}'.");

            item.Quantity -= quantity;

            if (item.Quantity <= 0)
                _items.Remove(item);
        }

        private CartProduct GetIfExists(Guid productId)
        {
            return _items.FirstOrDefault(
                it => it.Id == productId);                
        }
    }
}
