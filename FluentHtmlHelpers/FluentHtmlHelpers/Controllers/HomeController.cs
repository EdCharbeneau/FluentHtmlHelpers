using FluentHtmlHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FluentHtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StronglyTyped()
        {
            return View(new SampleAlertModel() { AlertBoxText = "Message", AlertBoxStyle = MyHelpers.AlertStyle.Warning });
        }

    }
}
