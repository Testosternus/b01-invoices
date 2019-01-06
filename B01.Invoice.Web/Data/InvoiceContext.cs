using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B01.Invoice.Web.Entities;

namespace B01.Invoice.Web.Data
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext(DbContextOptions<InvoiceContext> options) : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bill> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceItem>()
                .HasKey(it => new { it.BillId, it.ItemId });

            modelBuilder.Entity<InvoiceItem>()
                .HasOne(ii => ii.Bill)
                .WithMany(i => i.Items)
                .HasForeignKey(ii => ii.BillId);

            modelBuilder.Entity<Item>(ei =>
            {
                ei.Property(i => i.Price).HasColumnType("decimal(5,2)");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
