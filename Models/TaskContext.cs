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

        public DbSet<TaskContext> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public string Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Category>().HasData(
                    new Category { categoryid = 1, categoryname = "Home" },
                    new Category { categoryid = 2, categoryname = "School" },
                    new Category { categoryid = 3, categoryname = "Work" },
                    new Category { categoryid = 4, categoryname = "Church" }
                );


            mb.Entity<Tasks>().HasData(
                // pre-fill the database with movies
                // P.S. If you haven't seen these, you should really make time for them
                new Tasks
                {
                    TaskId = 1,
                    task = "Project 1",
                    dueDate = "2022-02-09",
                    quadrant = "Quadrant 3",
                    Categoryid = 2,
                    completed = false
                },
                new Tasks
                {
                    TaskId = 2,
                    task = "HBGary Analysis",
                    dueDate = "2022-02-10",
                    quadrant = "Quadrant 3",
                    Categoryid = 2,
                    completed = false
                },
                new Tasks
                {
                    TaskId = 3,
                    task = "MLR",
                    dueDate = "2022-02-09",
                    quadrant = "Quadrant 3",
                    Categoryid = 2,
                    completed = false
                }
                );
        } 


    }
}
