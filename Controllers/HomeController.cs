using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TimeMgmt.Models;
using Task = TimeMgmt.Models.Task;

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
        public IActionResult AddTask()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(Task task)
        {
            return View(task);
        }

        //* EDIT Task *//
        public IActionResult EditTask(int id)
        {
            ViewBag.Categories = _context.Categories.ToList(); //allows for movie categories to be used
        //    var form = TimeMgmt.Responses.Single(x => x.id == id);
            //identifies which record is being edited
            return View("AddTask"); //returns editable information  //ADD FORM BACK(!)
        }

        [HttpPost]
        public IActionResult EditTask(Task task)
        {
            _context.Update(task); //updates the task
            _context.SaveChanges(); //saves changes
            return RedirectToAction("Index"); //redirects to the table
        }

        //* DELETE Task *//
        public IActionResult DeleteTask(int id)
        {
            //var form = TimeMgmt.Responses.Single(x => x.id == id);  
            //identifies which record is being deleted
            return View(); //ADD FORM BACK HERE TOO
        }

        [HttpPost]
        public IActionResult DeleteTask(Task task)
        {
               // TaskMgmt.Responses.Remove(task); //removes the record 
               // TaskMgmt.SaveChanges();//saves the changes
                return RedirectToAction("Index"); //redirects to view movies table
            }
        }
    }


