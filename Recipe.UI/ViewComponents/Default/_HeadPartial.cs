using Microsoft.AspNetCore.Mvc;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
