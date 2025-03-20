using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers {
    public class PortfolioController : Controller {
        private readonly IPortfolioService _portfolioService;

        public PortfolioController(IPortfolioService portfolioService) {
            _portfolioService = portfolioService;
        }

        public IActionResult Index() {
            var values = _portfolioService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio() {
            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio) {
            _portfolioService.TInsert(portfolio);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id) {
            var skill = _portfolioService.TGetByID(id);
            return View(skill);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Portfolio portfolio) {
            _portfolioService.TUpdate(portfolio);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteSkill(int id) {
            _portfolioService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
