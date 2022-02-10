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
        [HttpGet]
        public IActionResult EditTask(int id)
        {
            ViewBag.Categories = _context.Categories.ToList(); //allows for movie categories to be used
            //var form = TimeMgmt.Responses.Single(x => x.id == id);  
            var form = _context.ToDos.Single(x => x.TaskId == id);
            //identifies which record is being edited
            return View("AddTask", form); //returns editable information  //ADD FORM BACK(!)
        }

        [HttpPost]
        public IActionResult EditTask(ToDo task)
        {
            _context.ToDos.Update(task); //updates the task
            _context.SaveChanges(); //saves changes
            return RedirectToAction("Index"); //redirects to the table
        }

        //* DELETE Task *//
        [HttpGet]
        public IActionResult DeleteTask(int id)
        {
            //var form = TimeMgmt.Responses.Single(x => x.id == id);  
            var form = _context.ToDos.Single(x => x.TaskId == id);  
            //identifies which record is being deleted
            return View(form); //ADD FORM BACK HERE TOO
        }

        [HttpPost]
        public IActionResult DeleteTask(ToDo task)
        {
                // TaskMgmt.Responses.Remove(task); //removes the record 
                // TaskMgmt.SaveChanges();//saves the changes
                _context.ToDos.Remove(task);
                _context.SaveChanges();
                return RedirectToAction("Index"); //redirects to view movies table
            }
        }
    }


