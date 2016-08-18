using System.Web.Mvc;
using PairingTest.Web.Models;
using System.Threading.Tasks;
using PairingTest.Web.Helper;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        IServerDataRestClient RestClient = new QuestionnaireAPIService();

        /* ASYNC ACTION METHOD... IF REQUIRED... */
        public async Task<ViewResult> Index()
        {
            
            return View("index", await RestClient.GetAll());

        }


        //public ViewResult Index()
        //{
        //    return View(RestClient.GetAll());
        //}
    }
}
