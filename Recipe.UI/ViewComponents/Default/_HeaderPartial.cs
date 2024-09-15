using Microsoft.AspNetCore.Mvc;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
