using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonial {
    public class TestimonialList (ITestimonialService testimonialService) : ViewComponent {
        private readonly ITestimonialService _testimonialService = testimonialService;
        public IViewComponentResult Invoke() {
            var values = _testimonialService.TGetList();
            return View(values);
        }
    }
}
