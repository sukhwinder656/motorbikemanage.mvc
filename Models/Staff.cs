using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorbikemanage.mvc.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Date_of_Birth { get; set; }
    }
}
