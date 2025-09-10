using ShopCartApp.Entities;
using ShopCartApp.Implementations;
using System;

namespace ShopCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Shop App");

            var itemId1 = Guid.NewGuid();
            var itemId2 = Guid.NewGuid();
            var itemId3 = Guid.NewGuid();

            var cart = new Cart();

            cart.Add(new CartProduct()
            {
                Id = itemId1,
                Name = "Name1",
                Quantity = 2,
                Price = 10.2m
            });

            cart.Add(new CartProduct()
            {
                Id = itemId2,
                Name = "Nam2",
                Quantity = 10,
                Price = 1.1m
            });

            cart.Add(new CartProduct()
            {
                Id = itemId3,
                Name = "Name3",
                Quantity = 4,
                Price = 33.3m
            });

            cart.Remove(itemId3,1);
            cart.Remove(itemId3, 3);

            cart.Add(new CartProduct()
            {
                Id = itemId2,
                Name = "Nam2",
                Quantity = 5,
                Price = 1.1m
            });

            foreach (var item in cart.GetAll())
            {
                Console.WriteLine($"{item.Id}-{item.Name}-{item.Quantity}-{item.Price}-{item.TotalPrice}");
            }
            {

            }

            Conso  le.WriteLine("End Shop App");
        }
    }
}
