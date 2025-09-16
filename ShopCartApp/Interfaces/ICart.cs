using ShopCartApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCartApp.Interfaces
{
    public interface ICart
    {
        void Add(CartProduct product);
        void Remove(Guid productId,int quantity);
        IEnumerable<CartProduct> GetAll();
    }
}
