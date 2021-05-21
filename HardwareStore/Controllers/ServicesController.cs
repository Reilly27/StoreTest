using HardwareStore.Domain;
using HardwareStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStore.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            Serviceitem catygory = new Serviceitem();

            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceitemById(id));
            }
            

            ViewBag.TextField = dataManager.TextFilds.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceitems());
        }

        public IActionResult One()
        {
            ViewBag.TextField = dataManager.TextFilds.GetTextFieldByCodeWord("PageServices");
            return View(dataManager.ServiceItems.GetServiceitems());
        }
    }
}
