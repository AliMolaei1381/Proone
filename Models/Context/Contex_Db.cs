using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pro.Models.Entities;


namespace sample.Models.Context
{
    public class Context_Db : DbContext
    {
        public Context_Db (DbContextOptions<Context_Db> options) : base (options) 
        {

        }
        public DbSet<Tbl_User> tbl_Users {get; set;}
        
    public class ToDoContextFactory : IDesignTimeDbContextFactory<Context_Db> {
        public Context_Db CreateDbContext (string[] args) {
            var builder = new DbContextOptionsBuilder<Context_Db> ();
            builder.UseSqlServer ("Data Source=DESKTOP-2RAFFTQ;initial Catalog=qw;integrated Security=SSPI;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;");
            return new Context_Db (builder.Options);
        }
    }
    
    }

   
    
}