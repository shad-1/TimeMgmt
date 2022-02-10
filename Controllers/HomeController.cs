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
            ViewBag.Cat = _context.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddTask(ToDo task)
        {
            if (ModelState.IsValid)
            {
                //Add the category object for a given categoryID
                if (task.Category == null)
                    task.Category = _context.Categories.Single(c => c.CategoryID == task.Categoryid);

                _context.Add(task);
                _context.SaveChanges();

                //Redirect to movies view
                return RedirectToAction("Index");
            }
            //If invalid, return the form.
            else
            {
                ViewBag.Cat = _context.Categories.ToList<Category>();
                return View(task);
            }
        }

        //* EDIT Task *//
        public IActionResult EditTask(int id)
        {
            ViewBag.Cat = _context.Categories.ToList();

            return View("AddTask");
        }

        [HttpPost]
        public IActionResult EditTask(ToDo task)
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
        public IActionResult DeleteTask(ToDo task)
        {
               // TaskMgmt.Responses.Remove(task); //removes the record 
               // TaskMgmt.SaveChanges();//saves the changes
                return RedirectToAction("Index"); //redirects to view movies table
            }
        }
    }


