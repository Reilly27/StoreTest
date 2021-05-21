using HardwareStore.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFilds.GetTextFieldByCodeWord("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.TextFilds.GetTextFieldByCodeWord("PageContacts"));
        }
        public IActionResult Info()
        {
            return View(dataManager.TextFilds.GetTextFieldByCodeWord("PageInfo"));
        }
        public IActionResult News()
        {
            return View(dataManager.TextFilds.GetTextFieldByCodeWord("PageNews"));
        }
        public IActionResult AboutUs()
        {
            return View(dataManager.TextFilds.GetTextFieldByCodeWord("PageAboutUs"));
        }
    }
}
