using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Batch1_DET_2022
{
    internal class DatabaseFirstApproach
    {
        public static void Main()
        {
            //            //GetEmpDetailsByID();
            //            //AddNewEmployee();
            //            //DeleteEmployee();
            //            UpdateEmployee();
            //            //GetEmpDetails();
            //            Console.ReadLine();




            //        }
            //        //private static void GetEmpDetailsByID()
            //        //{
            //        //    var ctx = new trainingTSQLContext();
            //        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
            //        //    Console.WriteLine(emp.Ename + "   " + emp.Sal + "  " + emp.Job);
            //        //  foreach (var emp in emps)
            //        //  {
            //        //   Console.WriteLine(emp.Ename + "   " + emp.Sal + emp.Job);
            //        // }

            //        //}
            //        //private static void AddNewEmployee()
            //        //{
            //        //    var ctx = new trainingTSQLContext();
            //        //    try
            //        //    {
            //        //        Emp Employee = new Emp();
            //        //        Employee.Empno = 2655;
            //        //        Employee.Ename = "shilpa";
            //        //        Employee.Deptno = 30;
            //        //        Employee.Job = "Trainee";
            //        //        ctx.Add(Employee);
            //        //        ctx.SaveChanges();
            //        //        Console.WriteLine("New employee Added");
            //        //    }
            //        //    catch (Exception ex)
            //        //    {
            //        //        Console.WriteLine(ex.InnerException.Message);
            //        //    }
            //        //}
            //        ////private static void DeleteEmployee()
            //        //{
            //        //    var ctx = new trainingTSQLContext();
            //        //    try
            //        //    {
            //        //        Emp Employee = new Emp();
            //        //        Employee.Empno = 5689;
            //        //        //Employee.Ename = "Allen";
            //        //        Employee.Deptno = 10;
            //        //        //Employee.Job = "Trainee";
            //        //        ctx.Remove(Employee);
            //        //        ctx.SaveChanges();
            //        //        Console.WriteLine("Employee Deleted");
            //        //    }
            //        //    catch (Exception ex)
            //        //    {
            //        //        Console.WriteLine(ex.InnerException.Message);
            //        //    }
            //        //}
            //        private static void UpdateEmployee()
            //        {
            //            var ctx = new trainingTSQLContext();
            //            try
            //            {
            //                Batch1_DET_2022.Models. Emp Employee = new Models.Emp();
            //                Employee.empno = 7499;
            //               // Employee.SAL = 10000;
            //               // Employee.ENAME = "Manasa";
            //                Employee.deptno = 30;
            //               // Employee.JOB = "Traine";
            //                ctx.Update(Employee);
            //                ctx.SaveChanges();
            //                Console.WriteLine("New employee updated");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.InnerException.Message);
            //            }
            //        }


            //        //public static void GetEmpDetails()

            //        //{

            //        //    var ctx = new trainingTSQLContext();
            //        //    var EMP = ctx.Emps.FromSqlRaw($"GetAllEmpsDetails").ToList();
            //        //    foreach (var e in EMP)
            //        //    {
            //        //        Console.WriteLine(e.Ename);

            //        //    }

        }
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new trainingTSQLContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7777
                        },

                         new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "HR"},

                          new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "rrr"}

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("addemp @empno, @job, @ename", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }
    }
}

