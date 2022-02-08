using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeMgmt.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string task { get; set; }
        public string dueDate { get; set; }
        [Required]
        public string quadrant { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
        public bool completed { get; set; }
    }
}
