using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TimeMgmt.Models;
using ToDo = TimeMgmt.Models.ToDo;

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
            var Task = _context.ToDos.Include(x => x.Category).ToList();
            return View(Task);
        }


        //* Quadrants View *//
        public IActionResult Quadrants()
        {
            return View();
        }

        //* ADD Task *//
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(ToDo task)
        {
            return View(task);
        }

        //* EDIT Task *//
        public IActionResult EditTask(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditTask(ToDo task)
        {
            return View(task);
        }

        //* DELETE Task *//
        public IActionResult DeleteTask(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeleteTask(ToDo task)
        {
            return View();
        }
    }
}

