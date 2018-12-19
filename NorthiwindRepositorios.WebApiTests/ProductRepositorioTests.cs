using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthiwindRepositorios.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthiwindRepositorios.WebApi.Tests
{
    [TestClass()]
    public class ProductRepositorioTests
    {
        private readonly ProductRepositorio repositorio = new ProductRepositorio();

        

        [TestMethod()]
        public void PostTest()
        {
            var product = new ProductViewModel();
            product.ProductName = "Café";
            product.UnitPrice = 21.56m;



            var response = repositorio.Post(product).Result;

            Console.WriteLine(response.ProductID);
            ///Assert.Fail();
        }


        [TestMethod()]
        public void PutTest()
        {
            var product = new ProductViewModel();
            product.ProductName = "Café com Bobagem";
            product.UnitPrice = 21.08m;
            product.ProductID = 80;



            repositorio.Put(product).Wait();

            var response = repositorio.Get(80).Result;

            Assert.IsTrue(response.UnitPrice==21.08m);
        }


        [TestMethod]
        public void Get()
        {
            Assert.IsTrue(repositorio.Get().Result.Count > 0);
        }


        [TestMethod]
        public void DeleteTest()
        {

            repositorio.Delete(80).Wait();
            var response = repositorio.Get(80).Result;

            Assert.IsNull(response);

        }
    }
}