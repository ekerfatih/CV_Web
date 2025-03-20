using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers {
    public class ExperienceController : Controller {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService) {
            _experienceService = experienceService;
        }

        public IActionResult Index() {
            var values = _experienceService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience() {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Experience Experience) {
            _experienceService.TInsert(Experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id) {
            var Experience = _experienceService.TGetByID(id);
            return View(Experience);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience Experience) {
            _experienceService.TUpdate(Experience);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteExperience(int id) {
            _experienceService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
