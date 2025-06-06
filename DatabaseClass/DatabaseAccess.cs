using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;


namespace DatabaseClass
{

    public class DatabaseAccess
    {
        // Thay doi Server, User Id va password tuong ung voi may cua ban
        static string connectionString = "Server=localhost;Database=StoreManagement;Integrated Security=True;TrustServerCertificate=True;";


        public class Manager
        {
            public string Manager_ID { get; set; }
            public string Manager_Name { get; set; }
            public string Manager_Phone { get; set; }
            public string Manager_Email { get; set; }

        }
        public class Employee
        {
            public string Employee_ID { get; set; }
            public string Employee_Name { get; set; }
            public string Employee_Gender { get; set; }
            public string Employee_Birth { get; set; }
            public string Employee_PhoneNumber { get; set; }
            public string Employee_Email { get; set; }
            public double Employee_Salary { get; set; }
            public string Store_ID { get; set; }
        }
        public class Customer
        {
            public string Customer_ID { get; set; }
            public string Customer_Name { get; set; }
            public string Customer_Phone { get; set; }
            public bool Customer_Gender { get; set; }
            public string Store_ID { get; set; }
        }
        public class Export
        {
            public string Export_ID { get; set; }
            public string Product_ID { get; set; }
            public string Store_ID { get; set; }
            public int Export_Quantity { get; set; }
            public string Export_Provider { get; set; }
            public double Export_Price { get; set; }
            public DateTime Export_Date { get; set; }
        }
        public class Import
        {
            public string Import_ID { get; set; }
            public string Product_ID { get; set; }
            public string Store_ID { get; set; }
            public int Import_Quantity { get; set; }
            public string Import_Provider { get; set; }
            public double Import_Price { get; set; }
            public DateTime Import_Date { get; set; }
        }
        public class Store
        {
            public string Store_ID { get; set; }
            public string Store_Name { get; set; }
            public string Store_Address { get; set; }
            public string Manager_ID { get; set; }
            public string Status { get; set; }
        }
        public class Product
        {
            public string Product_ID { get; set; }
            public string Product_Name { get; set; }
            public string Product_Provider { get; set; }
            public string Product_Price { get; set; }
        }
        public class Inventory
        {
            public string Store_ID { get; set; }
            public string Product_ID { get; set; }
            public int Inventory_Stock { get; set; }
            public string Inventory_Status { get; set; }
        }
        public class Invoice
        {
            public string Invoice_ID { get; set; }
            public string Employee_ID { get; set; }
            public string Customer_ID { get; set; }
            public double Invoice_TotalAmount { get; set; }
            public string Invoice_Status { get; set; }
            public string Invoice_Note { get; set; }
            public int Invoice_TotalQuantity { get; set; }
            public DateTime Invoice_Date { get; set; }
        }
        public class InvoiceDetail
        {
            public string Invoice_ID { get; set; }
            public string Product_ID { get; set; }
            public int InvoiceDetail_Quantity { get; set; }
            public double InvoiceDetail_UnitPrice { get; set; }
            public double InvoiceDetail_TotalPrice { get; set; }
        }
        public class Shift
        {
            public string Employee_ID { get; set; }
            public string Shift_Day { get; set; }
            public string Shift_Start { get; set; }
            public string Shift_Finish { get; set; }
        }

        // method 
        public static void CreateNewManager(Manager manager)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "INSERT INTO Manager (Manager_ID, Manager_Name, Manager_Phone, Manager_Email) VALUES (@Manager_ID, @Manager_Name, @Manager_Phone, @Manager_Email)";
                connection.Execute(sqlQuery, manager);
            }
        }

        public static (double revenue, int orders) GetDashboardData(string email)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Dùng đúng tên cột Manager_Email
                string getManagerIdSql = "SELECT Manager_ID FROM Manager WHERE Manager_Email = @Email";
                var managerId = connection.QueryFirstOrDefault<string>(getManagerIdSql, new { Email = email });

                if (string.IsNullOrEmpty(managerId))
                {
                    return (0, 0); // Không tìm thấy manager
                }

                string sql = @"
            SELECT 
                SUM(i.Invoice_TotalAmount) AS TotalRevenue,
                COUNT(*) AS TotalOrders
            FROM Invoice i
            JOIN Customer c ON i.Customer_ID = c.Customer_ID
            JOIN Store s ON c.Store_ID = s.Store_ID
            WHERE s.Manager_ID = @ManagerId";

                var result = connection.QueryFirstOrDefault<dynamic>(sql, new { ManagerId = managerId });

                double revenue = result?.TotalRevenue is decimal d ? (double)d : 0;
                int orders = result?.TotalOrders ?? 0;

                return (revenue, orders);
            }
        }




    }
}
