using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CoreWithSqlServerConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DataAccessUsingDaperORM();
           // DataAccessUsingEfCore();
           // DataAccessUsingAdoNet();

          

                Console.ReadKey();
        }

        private static void DataAccessUsingDaperORM()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", false)
            .Build();

            var connString = config.GetSection("connectionString").Value;
            using (var connection=new SqlConnection(connString))
            {
                var employee = connection.Query<TblEmployee>("select top(10) * from erp_Hr.dbo.TblEmployee where intUnitId=16").AsList();
                foreach(var emp in employee)
                {
                    Console.WriteLine("Employee Id: {0}", emp.IntEmployeeId);
                    Console.WriteLine("Employee Name: {0}", emp.StrEmployeeName);
                }
            }
        }

        private static void DataAccessUsingAdoNet()
        {
            var config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appSettings.json", false)
             .Build();

            var connString = config.GetSection("connectionString").Value;
            //Ado.NEt
            //1.Open a SqlConnection
            //2.Open a SqlCommand
            //3.Use a SqlAdapter to foll datatable
            // 4. Select * from erp_hr.dbo.tblEmployee

            using (var conn = new SqlConnection(connString))
            {
                var query = "Select * from erp_hr.dbo.tblEmployee";
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var empTable = new DataTable();
                        adapter.Fill(empTable);

                        foreach (DataRow row in empTable.Rows)
                        {
                            foreach (var emp in row.ItemArray)
                            {
                                Console.WriteLine(emp);
                            }
                        }
                    }

                }
            }
        }

        private static void DataAccessUsingEfCore()
        {
            using ( var db=new ERP_HRContext())
            {
                foreach(var emp in db.TblEmployee)
                {
                    Console.WriteLine("EmployeeId: {0}", emp.IntEmployeeId);
                    Console.WriteLine("Employee Name: {0}", emp.StrEmployeeName);
                   // Console.WriteLine("EmployeeId:", emp.IntEmployeeId);
                }
            }
        }
    }
}
