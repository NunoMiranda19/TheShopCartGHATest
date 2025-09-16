using NUnit.Framework;
using ShopCartApp.Entities;
using ShopCartApp.Implementations;
using ShopCartApp.Interfaces;
using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ShopCartUnitTests
{
    public class UnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            var itemnId = Guid.NewGuid();
            var shopCart = GetShopCart();

            //Act
            shopCart.Add(new CartProduct()
            {
                Id = itemnId,
                Name = "Item A",
                Price = 2,
                Quantity = 10
            });


            //Assert
            var items = shopCart.GetAll();

            Assert.IsTrue(
                items.Count() == 1
                && items.First().Id == itemnId);
        }

        [Test]
        public void Test2()
        {
            Assert.Fail();
        }

        private static ICart GetShopCart()
        {
            return new Cart();
        }
    }
}