﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Footer {
    public class FooterList : ViewComponent {
        public IViewComponentResult Invoke() {
            return View();
        }
    }
}
