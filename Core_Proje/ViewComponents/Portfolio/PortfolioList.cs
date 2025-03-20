using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Portfolio {
    public class PortfolioList(IPortfolioService portfolioService):ViewComponent {
        private readonly IPortfolioService _portfolioService = portfolioService;
        public IViewComponentResult Invoke() {
            var values = _portfolioService.TGetList();
            return View(values);
        }
    }
}
