using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Person.api
{
    public partial class microserviceContext : DbContext
    {
        public microserviceContext()
        {
        }

        public microserviceContext(DbContextOptions<microserviceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}
    }
}
