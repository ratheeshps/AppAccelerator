using Xunit;
using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
using System.Text.RegularExpressions;

namespace Payment.Processing.API.UnitTests.Controllers
{
    public class PaymentControllerTest
    {
        [Fact]
        public void Get_ReturnsOkResult_WithExpectedMessage()
        {
            // Arrange
            var controller = new PaymentController();

            // Act
            var result = controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var message = Assert.IsType<string>(okResult.Value);
            Assert.StartsWith("API is working. Current Time is ", message);

            // Verify the date format using regex
            var datePattern = @"\d{2}-\w{3}-\d{4} \d{2}:\d{2}:\d{2}";
            Assert.Matches(datePattern, message);
        }
    }
}
