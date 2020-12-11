using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorbikemanage.mvc.Models
{
    public class Buy
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public int BikeId { get; set; }
        public Bike Bike
        {
            get; set;
        }
    }
}