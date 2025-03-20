using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers {
    public class SkillController : Controller {

        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService) {
            _skillService = skillService;
        }

        public IActionResult Index() {
            var values = _skillService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill() {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill) {
            _skillService.TInsert(skill);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id) {
            var skill = _skillService.TGetByID(id);
            return View(skill);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill) {
            _skillService.TUpdate(skill);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteSkill(int id) {
            _skillService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
