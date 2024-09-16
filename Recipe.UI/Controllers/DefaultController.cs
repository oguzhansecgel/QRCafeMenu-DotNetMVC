using Microsoft.AspNetCore.Mvc;

namespace CafeMenum.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetContentDetail([FromQuery] int categoryId)
        {
            return ViewComponent("_ContentPartial", new
            {
                categoryId = categoryId
            });
        }
    }
}
