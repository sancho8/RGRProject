using System;
using Xunit;
using RGRProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using RGRProject.Models;
using Microsoft.EntityFrameworkCore;

namespace XUnitTests
{
    public class ApiControllerTests
    {

        [Fact]
        public void TestGetPlaces()
        {
            // Arrange
            using (var context = GetContext())
            {
                APIController controller = new APIController(context);
                controller.ControllerContext = new ControllerContext();
                controller.ControllerContext.HttpContext = new DefaultHttpContext();

                // Act
                ApiAnswer<List<Place>> result = controller.GetPlaces().Value as ApiAnswer<List<Place>>;

                // Assert
                Assert.Equal(new List<Place>(), result.Data);
            }
        }

        private DatabaseContext GetContext()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                      .UseInMemoryDatabase(Guid.NewGuid().ToString())
                      .Options;
            var context = new DatabaseContext(options);
            return context;
        }
    }
}
