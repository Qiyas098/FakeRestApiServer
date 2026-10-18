using FakeRestApiServer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeRestApiServer.DataAccsess
{
    public class FakeApiDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
         "Data Source=STHQ0126-05;" +
         "Initial Catalog=FakeApiDB;" +
         "Integrated Security=False;" +
         "User Id=admin;" +
         "Password=admin;" +
         "TrustServerCertificate=True;" +
         "Encrypt=True;");
        }

    }
}
