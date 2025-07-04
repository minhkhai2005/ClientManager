using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Configuration;


namespace DatabaseClass
{

    public class DatabaseAccess
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["StoreManagementDB"].ConnectionString;

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
            public bool Store_Status { get; set; }
            public string Store_Email { get; set; }
            public int UpdateStore()
            {
                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlQuery = "UPDATE Store SET Store_Name = @Store_Name, Store_Address = @Store_Address, Manager_ID = @Manager_ID, Store_Status = @Store_Status, Store_Email = @Store_Email WHERE Store_ID = @Store_ID";
                        return connection.Execute(sqlQuery, new { Store_Name, Store_Address, Manager_ID, Store_Status, Store_Email, Store_ID });
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as needed
                    Console.WriteLine($"Error updating store: {ex.Message}");
                    return -1; // Return -1 to indicate failure
                }
            }
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
        public static Manager GetManagerByEmail(string email)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Manager WHERE Manager_Email = @Email";
                var manager = connection.QueryFirstOrDefault<Manager>(sql, new { Email = email });

                return manager; // Nếu không tìm thấy trả về chuỗi rỗng
            }
        }

        public static Manager GetManagerByUID(string UID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Manager WHERE Manager_ID = @Manager_ID";
                return connection.QueryFirstOrDefault<Manager>(sqlQuery, new { Manager_ID = UID });
            }
        }

        public static List<Store> GetStoresByManagerID(string managerID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Store WHERE Manager_ID = @Manager_ID";
                return connection.Query<Store>(sqlQuery, new { Manager_ID = managerID }).ToList();
            }
        }
        public static Store GetStoreByID(string storeID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Store WHERE Store_ID = @Store_ID";
                return connection.QueryFirstOrDefault<Store>(sqlQuery, new { Store_ID = storeID });
            }
        }
        public static double GetStoreRevenue(string StoreID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT SUM(Invoice_TotalAmount) from Invoice i\r\nJOIN Employee e on i.Employee_ID = e.Employee_ID\r\nWHERE e.Store_Id = @Store_ID";
                var result = connection.ExecuteScalar<double>(sqlQuery, new { Store_ID = StoreID });
                return result;
            }
        }
        public static int GetStoreOrders(string StoreID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT COUNT(*) FROM Invoice i\r\nJOIN Employee e on i.Employee_ID = e.Employee_ID\r\nWHERE e.Store_Id = @Store_ID";
                var result = connection.ExecuteScalar<int>(sqlQuery, new { Store_ID = StoreID });
                return result;
            }
        }
        public static List<Employee> GetOnDutyEmployee(string StoreID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = @"SELECT 
                e.Employee_ID, e.Employee_Name, e.Employee_Gender, e.Employee_Birth, e.Employee_PhoneNumber, e.Employee_Email, e.Employee_Salary, e.Store_Id
                FROM Employee e
                INNER JOIN Shift s ON e.Employee_ID = s.Employee_ID
                INNER JOIN Store st ON e.Store_Id = st.Store_ID
                WHERE e.Store_Id = @Store_ID  -- Thay đổi Store_ID tại đây
                AND s.Day_of_Week = DATEPART(WEEKDAY, GETDATE())  -- Ngày trong tuần hiện tại
                AND CAST(GETDATE() AS TIME) BETWEEN s.Shift_Start AND s.Shift_Finish  -- Đang trong giờ làm việc
                AND s.Is_Active = 1;  -- Chỉ lấy ca làm việc đang hoạt động";
                var result = connection.ExecuteScalar<List<Employee>>(sqlQuery, new { Store_ID = StoreID });
                return result;
            }
        }
        public static Store GetStoreByEmail(string StoreEmail)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Store WHERE Store_Email = @Store_Email";
                return connection.QueryFirstOrDefault<Store>(sqlQuery, new { Store_Email = StoreEmail });
            }
        }
        public static List<Employee> GetEmployeesByStoreID(string storeID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Employee WHERE Store_ID = @Store_ID";
                return connection.Query<Employee>(sqlQuery, new { Store_ID = storeID }).ToList();
            }
        }
    }
}
