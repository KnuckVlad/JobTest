using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTest.Entitys
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }

        public ApplicationContext() : base()
        {
            Database.EnsureCreated();
        }

    }
}
