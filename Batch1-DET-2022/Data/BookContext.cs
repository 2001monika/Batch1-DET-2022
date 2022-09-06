using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Batch1_DET_2022.Models;


namespace Batch1_DET_2022.Data
{
    public class BookContext:DbContext
    {
        public BookContext()
        {

        }
        public BookContext(DbContextOptions<BookContext> options) 
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders{ get; set; }
        //public virtual DbSet<Book> Book { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
               // optionsBuilder.UseSqlServer("Server=BG3WS0351\\SQLEXPRESS;Database=trainingTSQL;Trusted_Connection=True;");

       optionsBuilder.UseSqlServer("Server=BG3WS0351\\SQLEXPRESS;Database=trainingTSQL;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Book>()
        //    //    .Property(b => b.price)
        //    //    .IsRequired()
        //    //    .HasColumnName("BKprice")
        //    //    .HasDefaultValue(200);
        //}
    }
}
