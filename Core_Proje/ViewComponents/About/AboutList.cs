using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About {
    public class AboutList(IAboutService aboutService) : ViewComponent {
        private readonly IAboutService _aboutService = aboutService;
        public IViewComponentResult Invoke() {
            var values = _aboutService.TGetList();
            return View(values);
        }
    }
}
