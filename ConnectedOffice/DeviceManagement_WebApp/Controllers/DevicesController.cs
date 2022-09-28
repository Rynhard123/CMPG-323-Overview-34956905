#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;

namespace DeviceManagement_WebApp.Controllers
{
    public class DevicesController : Controller
    {
        private readonly IDevicesRepo _deviceRepository;
        private readonly IZonesRepo _zoneRepository;
        private readonly ICategoriesRepo _categoryRepository;

        public DevicesController(IDevicesRepo deviceRepo, IZonesRepo zoneRepo, ICategoriesRepo categoryRepo)
        {
            _zoneRepository = zoneRepo;
            _deviceRepository = deviceRepo;
            _categoryRepository = categoryRepo;
        }

        // GET: Devices
        public async Task<IActionResult> Index()
        {
            return View(_deviceRepository.GetAllDevices().ToList());
        }

        // GET: Devices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = _deviceRepository.GetDeviceById(id);

            if (device == null)
            {
                return NotFound();
            }

            return View(device);
        }

        // GET: Devices/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAllCategories(), "CategoryId", "CategoryName");
            ViewData["ZoneId"] = new SelectList(_zoneRepository.GetAllZones(), "ZoneId", "ZoneName");
            return View();
        }

        // POST: Devices/Create
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeviceId,DeviceName,CategoryId,ZoneId,Status,IsActive,DateCreated")] Device device)
        {
            device.DeviceId = Guid.NewGuid();
            _deviceRepository.AddDevice(device);
            return RedirectToAction(nameof(Index));


        }

        // GET: Devices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = _deviceRepository.GetDeviceById(id);
            if (device == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.GetAllCategories(), "CategoryId", "CategoryName", device.CategoryId);
            ViewData["ZoneId"] = new SelectList(_zoneRepository.GetAllZones(), "ZoneId", "ZoneName", device.ZoneId);
            return View(device);
        }

        // POST: Devices/Edit/5
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("DeviceId,DeviceName,CategoryId,ZoneId,Status,IsActive,DateCreated")] Device device)
        {
            if (id != device.DeviceId)
            {
                return NotFound();
            }
            try
            {
                _deviceRepository.UpdateDevice(device);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeviceExists(device.DeviceId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }

        // GET: Devices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var device = _deviceRepository.GetDeviceById(id);

            if (device == null)
            {
                return NotFound();
            }

            return View(device);
        }

        // POST: Devices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var device = _deviceRepository.GetDeviceById(id);
            _deviceRepository.RemoveDevice(device);
            return RedirectToAction(nameof(Index));
        }

        private bool DeviceExists(Guid id)
        {
            return _deviceRepository.GetDeviceById(id) != null;
        }
    }
}
