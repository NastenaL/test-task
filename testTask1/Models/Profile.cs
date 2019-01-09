using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testTask1.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int Views { get; set; }
    }
}