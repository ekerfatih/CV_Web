using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Scripts {
    public class ScriptList : ViewComponent{
        public IViewComponentResult Invoke() {
            return View();
        }
    }
}
