using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    internal class CodeFirstApproach
    {
        public static void Main(string[] args)
        {
            //AddNewBook();
            //DeleteNewBook();
            //UpdateNewBook();
            //GetAllBookDetails();
            //AddnewCustomerAndOrder();
            // GetAllCustomerWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();

            Console.ReadLine();

        }

        //private static void AddNewBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 4;
        //    book.BookName = "Half Girlfriend";
        //    book.author = "Chetan Bhagat";
        //    book.price = 100;

        //    try
        //    {
        //        ctx.Book.Add(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book addded sucessfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //private static void DeleteNewBook()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Book.Where(b => b.BookID == 3).SingleOrDefault();

        //    try
        //    {
        //        ctx.Book.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book deleted sucessfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}

        //private static void UpdateNewBook()
        //{
        //    var ctx = new BookContext();
        //    var book = ctx.Book.Where(b => b.BookID == 2).SingleOrDefault();


        //    try
        //    {
        //        book.author = "jack";
        //        ctx.Book.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new book updated sucessfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void GetAllBookDetails()
        //{
        //    var ctx = new BookContext();
        //    var Book = ctx.Book;
        //    foreach (var book in Book)
        //    {
        //        Console.WriteLine(book.BookName + " " + book.BookID + " ");

        //    }
        //}

        //private static void AddnewCustomerAndOrder()
        //{
        //    var ctx = new BookContext();
        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "Monika";
        //    customer.Age = 21;

        //    Order ord = new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 1000;
        //    ord.OrderDate = DateTime.Now;

        //    ord.cust = customer;
        //    try
        //    {
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("customer and order created successfully");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.ToString());   
        //    }
        //}

        //private static void GetAllCustomerWithOrder_EagerLoading()
        //{


        //        //Eager loading means that the related data is loaded 
        //        //from the database as part of the initial query.
        //        var ctx = new BookContext();
        //        try
        //        {
        //            var customers = ctx.Customers.Include("Orders");

        //            //var customers = ctx.Customers.Include(o => o.Orders);                   

        //            foreach (var customer in customers)
        //            {
        //                Console.WriteLine(customer.Name);
        //                Console.WriteLine("----->");


        //                foreach (var order in customer.Orders)
        //                {
        //                    Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //                }
        //                Console.WriteLine("-----");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //}


        //private static void GetAllCustomersWithOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");

        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }

        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }
}
