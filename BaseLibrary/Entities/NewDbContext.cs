using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public  class NewDbContext(DbContextOptions<NewDbContext> options) : DbContext(options)
    {
        public DbSet<Branch> Branches { get; set; }

    }
}
