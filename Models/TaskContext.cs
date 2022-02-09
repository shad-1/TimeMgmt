using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeMgmt.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            //leave blank for now
        }

        public DbSet<TaskContext> Task { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public string Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                    new Category { CategoryID = 1, CategoryName = "Home" },
                    new Category { CategoryID = 2, CategoryName = "School" },
                    new Category { CategoryID = 3, CategoryName = "Work" },
                    new Category { CategoryID = 4, CategoryName = "Church" }
                );


            mb.Entity<Task>().HasData(
                // pre-fill the database with movies
                // P.S. If you haven't seen these, you should really make time for them
                new Task
                {
                    TaskId = 1,
                    task = "Project 1",
                    DueDate = "2022-02-09",
                    Quadrant = 3,
                    Categoryid = 2,
                    Completed = false
                },
                new Task
                {
                    TaskId = 2,
                    task = "HBGary Analysis",
                    DueDate = "2022-02-10",
                    Quadrant = 3,
                    Categoryid = 2,
                    Completed = false
                },
                new Task
                {
                    TaskId = 3,
                    task = "MLR",
                    DueDate = "2022-02-09",
                    Quadrant = 3,
                    Categoryid = 2,
                    Completed = false
                }
                );
        } 


    }
}
