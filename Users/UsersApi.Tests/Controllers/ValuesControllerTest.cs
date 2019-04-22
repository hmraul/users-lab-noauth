using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using UsersApi.Controllers;

namespace UsersApi.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        private ValuesController _controller = new ValuesController(new UsersDomain());

        [TestMethod]
        public void Get()
        {
            // Actuar
            IEnumerable<string> result = _controller.Get();

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Actuar
            string result = _controller.Get(5);

            // Declarar
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Actuar
            _controller.Post("value");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Actuar
            _controller.Put(5, "value");

            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Actuar
            _controller.Delete(5);

            // Declarar
        }
    }
}
