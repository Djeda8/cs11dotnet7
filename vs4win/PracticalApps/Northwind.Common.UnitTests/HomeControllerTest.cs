using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Northwind.Mvc.Controllers;
using Northwind.Mvc.Models;
using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Common.UnitTests
{
    public class HomeControllerTest
    {
        [Fact]
        public async Task Index_ReturnsAViewResult_WithAListOfBrainstormSessions()
        {
            // Arrange
            var mockRepo = new Mock<NorthwindContext>();
            var mockLogger = new Mock<ILogger<HomeController>>();

            var controller = new HomeController(mockLogger.Object ,mockRepo.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<HomeIndexViewModel>>(
                viewResult.ViewData.Model);
            Assert.Null(model);
        }
    }
}
