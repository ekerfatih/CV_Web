using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service {
    public class ServiceList(IServiceService serviceService) : ViewComponent {
        private readonly IServiceService _serviceService = serviceService;
        public IViewComponentResult Invoke() {
            var values = _serviceService.TGetList();
            return View(values);
        }
    }
}
