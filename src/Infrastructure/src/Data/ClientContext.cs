using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.src.Entity;

namespace Infrastructure.src.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable("client");
            modelBuilder
                .Entity<Client>(eb =>
                {
                    eb.HasNoKey();
                    // eb.ToView("View_ClientPostCounts");
                    // eb.Property(v => v.id).HasColumnName("Id");
                });
        }
    }
}