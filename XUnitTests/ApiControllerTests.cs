using System;
using Xunit;
using RGRProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace XUnitTests
{
    public class ApiControllerTests
    {

        [Fact]
        public void TestGetPlaces()
        {
            // Arrange
            APIController controller = new APIController();
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = new DefaultHttpContext();

            // Act
            ApiAnswer<string> result = controller.GetPlaces().Value as ApiAnswer<string>;

            // Assert
            Assert.Equal("places", result.Data);
        }
    }
}
