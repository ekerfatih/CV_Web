using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature {
    public class FeatureList(IFeatureService featureService) : ViewComponent {
        private readonly IFeatureService _featureService = featureService;

        public IViewComponentResult Invoke() {
            var values = _featureService.TGetList(); 
            return View(values);
        }
    }
}
