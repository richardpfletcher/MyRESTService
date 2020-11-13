using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvolutionWebApi.Controllers;
using EvolutionWebApi.Factory;
//using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Net.Http;


namespace WebApiTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {

            var controller = new CategoryController();
            var response = controller.Get();
            Assert.IsTrue(response.result > 0);


        }


        [TestMethod]
        public void TestMethod2()
        {

            var controller = new EvolutionController();
            var response = controller.GetByID("x",1,1,0,1,75);
            Assert.IsTrue(response.result > 0);


        }

        [TestMethod]
        public void TestMethod3()
        {

            var controller = new PartOfAlbumController();
            var response = controller.Get(1);
            Assert.IsTrue(response.result > 0);


        }

        [TestMethod]
        public void TestMethod4()
        {

            var controller = new ThemeController();
            var response = controller.Get();
            Assert.IsTrue(response.result > 0);


        }


    }
}
