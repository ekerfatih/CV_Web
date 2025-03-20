using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Contact {
    public class ContactList(IContactService contactService) : ViewComponent{
        private readonly IContactService _contactService = contactService;
        public IViewComponentResult Invoke() {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
