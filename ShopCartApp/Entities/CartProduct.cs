using System;
using System.Collections.Generic;
using System.Text;

namespace ShopCartApp.Entities
{
    public class CartProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get { return Price * Quantity; } }
    }
}
