using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using techSupport.Model;

namespace another_test.Data
{
    public class another_testContext : DbContext
    {
        public another_testContext (DbContextOptions<another_testContext> options)
            : base(options)
        {
        }

        public DbSet<techSupport.Model.SupportTakeReq> SupportTakeReq { get; set; }

        public DbSet<techSupport.Model.SupportReq> SupportReq { get; set; }
    }
}
