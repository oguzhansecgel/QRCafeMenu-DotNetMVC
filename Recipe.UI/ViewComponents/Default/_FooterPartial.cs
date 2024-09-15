using Microsoft.AspNetCore.Mvc;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _FooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
