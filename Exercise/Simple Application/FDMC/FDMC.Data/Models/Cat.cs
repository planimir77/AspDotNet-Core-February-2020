using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FDMC.Data.Models
{
    public class Cat
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }
       
        public string Image  { get; set; }
    }
}
