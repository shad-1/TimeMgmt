using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeMgmt.Models
{
    public class ToDo
    {
        [Required]
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        [Required]
        public int Quadrant { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
        public bool Completed { get; set; }
    }
}
