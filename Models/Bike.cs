﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motorbikemanage.mvc.Models
{
    public class Bike
    {
        public int Id { get; set; }
        public string Bike_Name { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
    }
}
