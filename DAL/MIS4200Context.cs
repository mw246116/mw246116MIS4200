using mw246116MIS4200.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace mw246116MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            //this method is a "constructor" and is called when context is created
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, mw246116MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
            //the base attribute says which connection string to use
        }
        //Include each object here. The value inside <> is the name of the class,
        //the value outside should generally be the plural of the class name
        //and is the name used to reference the entity in code

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // add this method - it will be used later
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>()
            base.OnModelCreating(modelBuilder);
        }


    }
}