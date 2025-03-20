using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers {
    public class DefaultController : Controller {
        private readonly IMessageService _messageService;

        public DefaultController(IMessageService messageService) {
            _messageService = messageService;
        }

        public IActionResult Index() {
            return View();
        }
        public PartialViewResult HeaderPartial() {
            return PartialView();
        }
        public PartialViewResult NavbarPartial() {
            return PartialView();
        }
        public PartialViewResult MessagePartial() {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Message msg) {
            msg.Date = DateTime.Now;
            _messageService.TInsert(msg);
            return RedirectToAction("Index");
        }
    }
}
