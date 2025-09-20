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
            

            //Assert
            

            Assert.Pass();
        }

        private static ICart GetShopCart()
        {
            return new Cart();
        }
    }
}