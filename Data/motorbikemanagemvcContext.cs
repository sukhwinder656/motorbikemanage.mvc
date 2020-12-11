using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using motorbikemanage.mvc.Models;

namespace motorbikemanage.mvc.Data
{
    public class motorbikemanagemvcContext : DbContext
    {
        public motorbikemanagemvcContext (DbContextOptions<motorbikemanagemvcContext> options)
            : base(options)
        {
        }

        public DbSet<motorbikemanage.mvc.Models.Bike> Bike { get; set; }

        public DbSet<motorbikemanage.mvc.Models.Buy> Buy { get; set; }

        public DbSet<motorbikemanage.mvc.Models.Customer> Customer { get; set; }

        public DbSet<motorbikemanage.mvc.Models.Staff> Staff { get; set; }
    }
}
