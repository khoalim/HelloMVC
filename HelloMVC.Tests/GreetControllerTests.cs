using System;
using System.Collections.Generic;
using System.Text;
using Xunit; // this using statement must be added
using HelloMVC.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Tests
{
    public class GreetControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new GreetController();
            var result = controller.Index("ThisIsAString");
            Assert.IsType<ViewResult>(result);
        }
    }
}
