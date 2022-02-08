using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeMgmt.Models;

namespace TimeMgmt.Controllers
{
    public class HomeController : Controller
    {

        private TaskContext _context;

        public HomeController(TaskContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //* Quadrants View *//
        public IActionResult Quadrants()
        {
            return View();
        }

        //* ADD Task *//
        public IActionREsunce AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Task task)
        {
            return View();
        }

        //* EDIT Task *//
        public IActionResult EditTask(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditTask(Task task)
        {
            return View();
        }

        //* DELETE Task *//
        public IActionResult DeleteTask(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteTask(Task task)
        {
            return View();
        }
    }
}

