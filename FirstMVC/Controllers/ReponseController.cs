using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class ReponseController : Controller
    {
        [HttpGet]
        public ViewResult ConfirmerForm()

        {
            return View();
        }

        [HttpPost]
        public ViewResult ConfirmerForm(GuestResponse guestResponse)
        { return View("Merci, guestResponse");
        }
	}
}