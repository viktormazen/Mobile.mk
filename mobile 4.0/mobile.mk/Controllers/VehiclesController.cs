using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mobile.DataAccess;
using mobile.Domain.Enums;
using mobile.Domain.Models;
using mobile.Services.Interfaces;
using mobile.WebModels;

namespace mobile.WebApp.Controllers
{
    [Authorize]
    public class VehiclesController : Controller
    {
        private readonly IHostingEnvironment _hostingEnviorment;
        private readonly IVehicleService _vehicleService;



        public VehiclesController(IVehicleService vehicleService, 
                                  IHostingEnvironment hostingEnviorment)
        {
            _hostingEnviorment = hostingEnviorment;
            _vehicleService = vehicleService;
        }

        // GET: Vehicles
        [AllowAnonymous]
        public IActionResult Index(string searchBy, string search)
        {
            bool test = User.Identity.IsAuthenticated;

            if(searchBy == "Make")
            {
                return View(_vehicleService.GetAllVehicles().Where(v => v.Make.StartsWith(search)));
            }
            else if(searchBy == "Model")
            {
                return View(_vehicleService.GetAllVehicles().Where(v => v.Model.StartsWith(search)));
            }
            return View(_vehicleService.GetAllVehicles()); 
        }

        [Authorize(Roles = "customer")]
        public IActionResult ListUserVehicles()
        {
            ViewBag.RenderActions = true;

            return View("Index", _vehicleService.GetUserVehicles(User.Identity.Name));
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var vehicle = _vehicleService.GetVehicleById(id);
            return View(vehicle);
        }

        [Authorize(Roles = "customer, admin")]
        public IActionResult Delete(int id)
        {
             _vehicleService.RemoveVehicle(id);
            return View(nameof(Delete));
        }


        [HttpGet]
        [Authorize(Roles = "customer")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "customer")]
        public IActionResult Create(VehicleCreateViewModel vehicle)
        {
            _vehicleService.CreateVehicle(vehicle);
            return RedirectToAction(nameof(Index));
        }


        //[HttpPost]
        //[Authorize(Roles = "customer")]
        //public IActionResult Create(VehicleViewModel newModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
        //        if (newModel.Photo != null)
        //        {
        //            string uploadsFolder = Path.Combine(_hostingEnviorment.WebRootPath, "images");
        //            uniqueFileName = Guid.NewGuid().ToString() + "_" + newModel.Photo.FileName;
        //            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //            newModel.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

        //            _vehicleService.CreateVehicle(newModel);
        //        }

        //        return RedirectToAction(nameof(Index));
        //    }

        //    return RedirectToAction(nameof(Index));
        //}


        [HttpGet]
        [Authorize(Roles = "customer, admin")]
        public IActionResult Edit(int id)
        {
            return View(_vehicleService.GetVehicleById(id));
        }

        [HttpPost]
        [Authorize(Roles = "customer, admin")]
        public IActionResult Edit(VehicleViewModel vehicle)
        {
            _vehicleService.UpdateVehicle(vehicle);
            return RedirectToAction(nameof(Index));
        }

    }
}
