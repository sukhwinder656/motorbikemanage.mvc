using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorbikemanage.mvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
    }
}
