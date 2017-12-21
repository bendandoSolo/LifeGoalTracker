using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LifeGoalTracker.Controllers
{
    public class Day
    {
        [Key]
        public int Id{ get; set; }
        public DateTime ADay { get; set; }
        public int Pompodoros { get; set; }
        public int Cigarettes { get; set; }
        public int StrongCigarettes { get; set; }
        public int Exercise { get; set; }
    }
}