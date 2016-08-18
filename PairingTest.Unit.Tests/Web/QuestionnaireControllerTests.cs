using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using PairingTest.Web.Controllers;
using PairingTest.Web.Models;

namespace PairingTest.Unit.Tests.Web
{
    [TestFixture]
    public class QuestionnaireControllerTests
    {
        [Test]
        public async Task ShouldGetQuestions()
        {
            //Arrange
            var expectedTitle = "Geography Questions";
           
            var questionnaireController = new QuestionnaireController();
            var result = await questionnaireController.Index();
            Assert.IsNotNull(result);
            var viewresult = (QuestionnaireViewModel)((ViewResult)result).Model;
            //Assert
            Assert.That(viewresult.QuestionnaireTitle, Is.EqualTo(expectedTitle));

        }
    }
}