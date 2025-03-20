using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill {
    public class SkillList(ISkillService skillService) : ViewComponent {
        private readonly ISkillService _skillService = skillService;
        public IViewComponentResult Invoke() {
            var values = _skillService.TGetList();
            return View(values);
        }
    }
}
