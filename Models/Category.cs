using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeMgmt.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int categoryid { get; set; }
        public string categoryname { get; set; }

        public static implicit operator Category(int v)
        {
            throw new NotImplementedException();
        }
    }
}
