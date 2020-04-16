using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisplayData.Controllers;

namespace DisplayTestProject.Tests
{
    [TestClass]
    public class ValueControllerTests
    {
        [TestMethod]
        public void GetMethodTest() 
        {
            var objValuesController = new ValuesController();
            var result=objValuesController.Get(54.2);
            var resultData = ((System.Web.Http.Results.OkNegotiatedContentResult<string>)(result)).Content;
            Assert.AreEqual(resultData.ToString(), "fifty-four dollars and twenty cents");  
        }
    }
}
