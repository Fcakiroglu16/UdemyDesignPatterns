using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Composite.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }
    }
}