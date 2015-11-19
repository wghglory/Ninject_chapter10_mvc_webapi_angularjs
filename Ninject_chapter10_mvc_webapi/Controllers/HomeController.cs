using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject_chapter10_mvc_webapi.Models;

namespace Ninject_chapter10_mvc_webapi.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository repoImpl)
        {
            repo = repoImpl;
        }

        public ActionResult Index()
        {
            return View(repo.Products);
        }
    }
}