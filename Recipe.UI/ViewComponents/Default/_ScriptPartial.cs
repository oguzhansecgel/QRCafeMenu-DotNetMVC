using Microsoft.AspNetCore.Mvc;

namespace CafeMenum.UI.ViewComponents.Default
{
    public class _ScriptPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
