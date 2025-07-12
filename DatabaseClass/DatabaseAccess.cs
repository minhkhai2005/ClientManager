﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Configuration;
using static DatabaseClass.DatabaseAccess;
using System.Runtime.InteropServices.ComTypes;


namespace DatabaseClass
{

    public class DatabaseAccess
    {
        //static string connectionString = "Server=100.118.245.104,1433;Database=StoreManagement;User Id=qk;Password=1;";

        //static string connectionString = "Server=MYLAPTOP\\VONG;Database=StoreManagement;Trusted_Connection=True;";
        //static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        //static string connectionString = "Data Source=DESKTOP-30NMLHM\\Wuang_Kai;Initial Catalog=TenDatabase;Integrated Security=True;";

        static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        public static string CurrentEmail { get; set; }
        public class Manager
        {
            
            public string Manager_ID { get; set; }
            public string Manager_Name { get; set; }
            public string Manager_Phone { get; set; }
            public string Manager_Email { get; set; }
            public void UpdateManager()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "UPDATE Manager SET Manager_Name = @Manager_Name, Manager_Phone = @Manager_Phone, Manager_Email = @Manager_Email WHERE Manager_ID = @Manager_ID";
                    connection.Execute(sqlQuery, this);
                }
            }

        }
        public class Employee
        {
            public string Employee_ID { get; set; }
            public string Employee_Name { get; set; }
            public bool Employee_Gender { get; set; }
            public DateTime Employee_Birth { get; set; }
            public string Employee_PhoneNumber { get; set; }
            public string Employee_Email { get; set; }
            public double Employee_Salary { get; set; }
            public string Store_ID { get; set; }

            public override bool Equals(object obj)
            {
                return obj is Employee employee &&
                       Employee_ID == employee.Employee_ID &&
                       Employee_Name == employee.Employee_Name &&
                       Employee_Gender == employee.Employee_Gender &&
                       Employee_Birth == employee.Employee_Birth &&
                       Employee_PhoneNumber == employee.Employee_PhoneNumber &&
                       Employee_Email == employee.Employee_Email &&
                       Employee_Salary == employee.Employee_Salary &&
                       Store_ID == employee.Store_ID;
            }

            public override int GetHashCode()
            {
                int hashCode = -1127884199;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Employee_ID);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Employee_Name);
                hashCode = hashCode * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Employee_Gender);
                hashCode = hashCode * -1521134295 + EqualityComparer<DateTime>.Default.GetHashCode(Employee_Birth);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Employee_PhoneNumber);
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Employee_Email);
                hashCode = hashCode * -1521134295 + Employee_Salary.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Store_ID);
                return hashCode;
            }

            public void UpdateEmployee()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Employee SET 
                                Employee_Name = @Employee_Name, 
                                Employee_Gender = @Employee_Gender, 
                                Employee_Birth = @Employee_Birth, 
                                Employee_PhoneNumber = @Employee_PhoneNumber, 
                                Employee_Email = @Employee_Email, 
                                Employee_Salary = @Employee_Salary,
                                Store_ID = @Store_ID
                            WHERE Employee_ID = @Employee_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
            public List<Shift> GetShifts()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Shift WHERE Employee_ID = @EmployeeID";
                    return connection.Query<Shift>(sqlQuery, new { EmployeeID = this.Employee_ID }).ToList();
                }
            }
            public static List<Shift> GetShifts(string empID)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Shift WHERE Employee_ID = @empID";
                    return connection.Query<Shift>(sqlQuery, new { empID }).ToList();
                }
            }
            public static Employee GetEmployeeByID(string id)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Employee WHERE Employee_ID = @EmployeeID";
                    return connection.QueryFirstOrDefault<Employee>(sqlQuery, new { EmployeeID = id });
                }
            }
        }
        public class Customer
        {
            public string Customer_ID { get; set; }
            public string Customer_Name { get; set; }
            public string Customer_Phone { get; set; }
            public bool Customer_Gender { get; set; }
            public string Store_ID { get; set; }
            public void UpdateCustomer()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Customer SET 
                                Customer_Name = @Customer_Name, 
                                Customer_Phone = @Customer_Phone, 
                                Customer_Gender = @Customer_Gender, 
                                Store_ID = @Store_ID
                            WHERE Customer_ID = @Customer_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
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
            public void UpdateExport()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Export SET 
                                Product_ID = @Product_ID, 
                                Store_ID = @Store_ID, 
                                Export_Quantity = @Export_Quantity, 
                                Export_Provider = @Export_Provider, 
                                Export_Price = @Export_Price, 
                                Export_Date = @Export_Date
                            WHERE Export_ID = @Export_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
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
            public double Import_Total { get; set; }
            public void UpdateImport()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Import SET 
                                Product_ID = @Product_ID, 
                                Store_ID = @Store_ID, 
                                Import_Quantity = @Import_Quantity, 
                                Import_Provider = @Import_Provider, 
                                Import_Price = @Import_Price, 
                                Import_Date = @Import_Date,
                                Import_Total = @Import_Total
                            WHERE Import_ID = @Import_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
            public static List<Import> GetImports(string storeID, string prodID)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Import WHERE Store_ID = @Store_ID AND Product_ID = @Product_ID";
                    return connection.Query<Import>(sqlQuery, new { Store_ID = storeID, Product_ID = prodID }).ToList();
                }
            }
            public static Import GetImportByID(string importID)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Import WHERE Import_ID = @Import_ID";
                    return connection.QueryFirstOrDefault<Import>(sqlQuery, new { Import_ID = importID });
                }
            }
            public void CreateNewImport()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO Import (Import_ID, Product_ID, Store_ID, Import_Quantity, Import_Provider, Import_Price, Import_Date, Import_Total) VALUES (@Import_ID, @Product_ID, @Store_ID, @Import_Quantity, @Import_Provider, @Import_Price, @Import_Date, @Import_Total)";
                    connection.Execute(sqlQuery, this);
                }
            }
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
            public int GetNumberOfSoldItem(string storeID, string productID)
            {
                try
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlQuery = "SELECT \r\n    ISNULL(SUM(id.InvoiceDetail_TotalPrice), 0) AS Product_Revenue\r\nFROM Product p\r\nINNER JOIN InvoiceDetail id ON p.Product_ID = id.Product_ID\r\nINNER JOIN Invoice i ON id.Invoice_ID = i.Invoice_ID\r\nINNER JOIN Employee e ON i.Employee_ID = e.Employee_ID\r\nINNER JOIN Store s ON e.Store_Id = s.Store_ID\r\nWHERE p.Product_ID = @ProductID\r\n    AND s.Store_ID = @StoreID\r\n    AND i.Invoice_Status = 'Paid';";
                        return connection.Execute(sqlQuery, new { StoreID = storeID, ProductID = productID });
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it as needed
                    Console.WriteLine($"Error fetching information: {ex.Message}");
                    return 0;
                }
            }
            static public Store GetStoreByID(string storeID)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Store WHERE Store_ID = @Store_ID";
                    return connection.QueryFirstOrDefault<Store>(sqlQuery, new { Store_ID = storeID });
                }
            }
        }
        public class Product
        {
            public string Product_ID { get; set; }
            public string Product_Name { get; set; }
            public string Product_Provider { get; set; }
            public double Product_Price { get; set; }
            public void UpdateProduct()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Product SET 
                                Product_Name = @Product_Name, 
                                Product_Provider = @Product_Provider, 
                                Product_Price = @Product_Price
                            WHERE Product_ID = @Product_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
            public static Product GetProductByID(string id)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Product WHERE Product_ID = @Product_ID";
                    return connection.QueryFirstOrDefault<Product>(sqlQuery, new { Product_ID = id });
                }
            }
            public static void CreateNewProduct(Product product)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO Product (Product_ID, Product_Name, Product_Provider, Product_Price) VALUES (@Product_ID, @Product_Name, @Product_Provider, @Product_Price)";
                    connection.Execute(sqlQuery, product);
                }
            }
        }
        public class Inventory
        {
            public string Store_ID { get; set; }
            public string Product_ID { get; set; }
            public int Inventory_Stock { get; set; }
            public bool Inventory_Status { get; set; }
            public int Inventory_AlertQuantity { get; set; }

            public static Inventory GetInventoryByID(string storeID, string prodID)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Inventory WHERE Store_ID = @storeID AND Product_ID = @prodID";
                    return connection.QueryFirstOrDefault<Inventory>(sqlQuery, new { storeID, prodID });
                }
            }

            public void UpdateInventory()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Inventory SET 
                                Inventory_Stock = @Inventory_Stock, 
                                Inventory_Status = @Inventory_Status
                            WHERE Store_ID = @Store_ID AND Product_ID = @Product_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
            public static void  CreateNewInventory(Inventory inventory) {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO Inventory (Store_ID, Product_ID, Inventory_Stock, Inventory_Status, Inventory_AlertQuantity) VALUES (@Store_ID, @Product_ID, @Inventory_Stock, @Inventory_Status, @Inventory_AlertQuantity)";
                    connection.Execute(sqlQuery, inventory);
                }
            }
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
            public void UpdateInvoice()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Invoice SET 
                                Employee_ID = @Employee_ID, 
                                Customer_ID = @Customer_ID, 
                                Invoice_TotalAmount = @Invoice_TotalAmount, 
                                Invoice_Status = @Invoice_Status, 
                                Invoice_Note = @Invoice_Note, 
                                Invoice_TotalQuantity = @Invoice_TotalQuantity, 
                                Invoice_Date = @Invoice_Date
                            WHERE Invoice_ID = @Invoice_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
            public static Invoice GetInvoiceByID(string id)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM Invoice WHERE Invoice_ID = @Invoice_ID";
                    return connection.QueryFirstOrDefault<Invoice>(sqlQuery, new { Invoice_ID = id });
                }
            }
        }
        public class InvoiceDetail
        {
            public string Invoice_ID { get; set; }
            public string Product_ID { get; set; }
            public int InvoiceDetail_Quantity { get; set; }
            public double InvoiceDetail_UnitPrice { get; set; }
            public double InvoiceDetail_TotalPrice { get; set; }
            public void UpdateInvoiceDetail()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE InvoiceDetail SET 
                                InvoiceDetail_Quantity = @InvoiceDetail_Quantity, 
                                InvoiceDetail_UnitPrice = @InvoiceDetail_UnitPrice, 
                                InvoiceDetail_TotalPrice = @InvoiceDetail_TotalPrice
                            WHERE Invoice_ID = @Invoice_ID AND Product_ID = @Product_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
            public static List<InvoiceDetail> GetInvoiceDetailsByInvoiceID(string invoiceID)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "SELECT * FROM InvoiceDetail WHERE Invoice_ID = @Invoice_ID";
                    return connection.Query<InvoiceDetail>(sqlQuery, new { Invoice_ID = invoiceID }).ToList();
                }
            }

        }
        public class Shift
        {
            public string Employee_ID { get; set; }
            public int Day_of_Week { get; set; }
            public TimeSpan Shift_Start { get; set; }
            public TimeSpan Shift_Finish { get; set; }
            public bool Is_Active { get; set; }

            public static void SaveShifts(List<Shift> employeeShifts)
            {
                // delete old shifts
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Shift WHERE Employee_ID = @Employee_ID";
                    connection.Execute(deleteQuery, new { Employee_ID = employeeShifts.First().Employee_ID });
                }

                // update new shifts
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = @"INSERT INTO Shift (Employee_ID, Day_of_Week, Shift_Start, Shift_Finish, Is_Active) 
                                           VALUES (@Employee_ID, @Day_of_Week, @Shift_Start, @Shift_Finish, @Is_Active)";
                    connection.Execute(insertQuery, employeeShifts);
                }
            }

            public void UpdateShift()
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = @"UPDATE Shift SET 
                                Day_of_Week = @Day_of_Week, 
                                Shift_Start = @Shift_Start, 
                                Shift_Finish = @Shift_Finish, 
                                Is_Active = @Is_Active
                            WHERE Employee_ID = @Employee_ID";
                    connection.Execute(sqlQuery, this);
                }
            }
        }

        // public method 
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
        public static Store GetStoreByEmail(string email)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Store WHERE Store_Email = @Store_Email";
                return connection.QueryFirstOrDefault<Store>(sqlQuery, new { Store_Email = email });
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
        public static int GetStoreNumberOfOrders(string StoreID)
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
                AND s.Is_Active = 1;  -- Chỉ lấy ca làm việc đang hoạt động";
                var result = connection.Query<Employee>(sqlQuery, new { Store_ID = StoreID }).ToList();
                return result;
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
        public static List<Inventory> GetInventoriesByStoreID(string storeID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Inventory WHERE Store_ID = @Store_ID";
                return connection.Query<Inventory>(sqlQuery, new { Store_ID = storeID }).ToList();
            }
        }
        public static Product GetProductByID(string productID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Product WHERE Product_ID = @Product_ID";
                return connection.QueryFirstOrDefault<Product>(sqlQuery, new { Product_ID = productID });
            }
        }
        public static List<Invoice> GetInvoicesByStoreID(string storeID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT * FROM Invoice i\r\nJOIN Employee e ON e.Employee_ID = i.Employee_ID\r\nWHERE e.Store_ID = @Store_ID";
                return connection.Query<Invoice>(sqlQuery, new { Store_ID = storeID }).ToList();

            }
        }
        public static Employee GetEmployeeByEmail(string email)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Employee WHERE Employee_Email = @Email";
                return connection.QueryFirstOrDefault<Employee>(sql, new { Email = email });
            }
        }

        public static List<Product> GetProductsByStoreID(string store_ID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Join Inventory and Product to get all products available in the given store
                string sqlQuery = @"
            SELECT p.Product_ID, p.Product_Name, p.Product_Provider, p.Product_Price
            FROM Inventory i
            INNER JOIN Product p ON i.Product_ID = p.Product_ID
            WHERE i.Store_ID = @Store_ID";
                return connection.Query<Product>(sqlQuery, new { Store_ID = store_ID }).ToList();
            }
        }

        public static List<Employee> GetEmployeesByManagerID(string managerID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = @"
            SELECT 
                e.Employee_ID,
                e.Employee_Name,
                e.Employee_Gender,
                e.Employee_Birth,
                e.Employee_PhoneNumber,
                e.Employee_Email,
                e.Employee_Salary,
                s.Store_ID,
                s.Store_Name,
                s.Store_Address,
                m.Manager_ID,
                m.Manager_Name
            FROM Employee e
            INNER JOIN Store s ON e.Store_Id = s.Store_ID
            INNER JOIN Manager m ON s.Manager_ID = m.Manager_ID
            WHERE m.Manager_ID = @managerID  -- Replace with your specific Manager_ID
            ORDER BY s.Store_Name, e.Employee_Name;";
                return connection.Query<Employee>(sqlQuery, new { managerID }).ToList();
            }
        }

        public static List<Customer> GetCustomersbyManagerID(string managerID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = @"
        SELECT 
            c.Customer_ID,
            c.Customer_Name,
            c.Customer_Phone
        FROM Customer c
        INNER JOIN Store s ON c.Store_ID = s.Store_ID
        INNER JOIN Manager m ON s.Manager_ID = m.Manager_ID
        WHERE m.Manager_ID = @managerID
        ORDER BY c.Customer_Name;";

            return connection.Query<Customer>(sqlQuery, new { managerID }).ToList();
            }
        }
        
        public class MonthRevenue
        {
            public int month { get; set; }
            public double revenue { get; set; }
        }

        public class WeekRevenue
        {
            public int week { get; set; }
            public double revenue { get; set; }
        }
        public class DayRevenue
        {
            public int day { get; set; }
            public double revenue { get; set; }

        }
        public static List<MonthRevenue> GetMonthlyRevenue(string managerID) 
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = @"
                    WITH MonthlyRevenue AS (
                        SELECT 
                            MONTH(i.Invoice_Date) AS month,
                            SUM(i.Invoice_TotalAmount) AS revenue
                        FROM Invoice i
                        INNER JOIN Employee e ON i.Employee_ID = e.Employee_ID
                        INNER JOIN Store s ON e.Store_Id = s.Store_ID
                        WHERE YEAR(i.Invoice_Date) = YEAR(GETDATE())  -- Current year
                            AND i.Invoice_Status = 'Paid'  -- Only count paid invoices
                            AND s.Manager_ID = @Manager_ID  -- Filter by Manager ID
                        GROUP BY MONTH(i.Invoice_Date)
                    ),
                    AllMonths AS (
                        -- Generate all 12 months to show 0 revenue for months with no sales
                        SELECT 1 AS month UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL 
                        SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL 
                        SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL 
                        SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12
                    )
                    SELECT 
                        am.month,
                        ISNULL(mr.revenue, 0) AS revenue
                    FROM AllMonths am
                    LEFT JOIN MonthlyRevenue mr ON am.month = mr.month
                    ORDER BY am.month;
                ";
                return connection.Query<MonthRevenue>(sqlQuery, new { Manager_ID = managerID }).ToList();
            }
        }
        public static List<WeekRevenue> GetWeeklyRevenue(string managerID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = @"
                    WITH WeeklyRevenue AS (
                        SELECT 
                            DATEPART(WEEK, i.Invoice_Date) - DATEPART(WEEK, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) + 1 AS week,
                            SUM(i.Invoice_TotalAmount) AS revenue
                        FROM Invoice i
                        INNER JOIN Employee e ON i.Employee_ID = e.Employee_ID
                        INNER JOIN Store s ON e.Store_Id = s.Store_ID
                        WHERE YEAR(i.Invoice_Date) = YEAR(GETDATE())  -- Current year
                            AND MONTH(i.Invoice_Date) = MONTH(GETDATE())  -- Current month
                            AND i.Invoice_Status = 'Paid'  -- Only count paid invoices
                            AND s.Manager_ID = @Manager_ID  -- Filter by Manager ID
                        GROUP BY DATEPART(WEEK, i.Invoice_Date) - DATEPART(WEEK, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) + 1
                    ),
                    AllWeeks AS (
                        -- Generate all possible weeks in current month (usually 4-6 weeks)
                        SELECT 1 AS week UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL 
                        SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6
                    )
                    SELECT 
                        aw.week,
                        ISNULL(wr.revenue, 0) AS revenue
                    FROM AllWeeks aw
                    LEFT JOIN WeeklyRevenue wr ON aw.week = wr.week
                    WHERE aw.week <= (
                        -- Calculate maximum week number for current month
                        SELECT 
                            DATEPART(WEEK, EOMONTH(GETDATE())) - DATEPART(WEEK, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) + 1
                    )
                    ORDER BY aw.week;";
                return connection.Query<WeekRevenue>(sqlQuery, new { Manager_ID = managerID }).ToList();
            }
        }
        public static List<DayRevenue> GetDailyRevenue(string managerID) 
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = @"  
                    WITH DailyRevenue AS (
                        SELECT 
                            CASE DATEPART(WEEKDAY, i.Invoice_Date)
                                WHEN 1 THEN 7  -- Sunday = 7
                                ELSE DATEPART(WEEKDAY, i.Invoice_Date) - 1  -- Monday=1, Tuesday=2, ..., Saturday=6
                            END AS day,
                            SUM(i.Invoice_TotalAmount) AS revenue
                        FROM Invoice i
                        INNER JOIN Employee e ON i.Employee_ID = e.Employee_ID
                        INNER JOIN Store s ON e.Store_Id = s.Store_ID
                        WHERE DATEPART(WEEK, i.Invoice_Date) = DATEPART(WEEK, GETDATE())  -- Current week
                            AND YEAR(i.Invoice_Date) = YEAR(GETDATE())  -- Current year
                            AND i.Invoice_Status = 'Paid'  -- Only count paid invoices
                            AND s.Manager_ID = @Manager_ID  -- Filter by Manager ID
                        GROUP BY CASE DATEPART(WEEKDAY, i.Invoice_Date)
                                    WHEN 1 THEN 7  -- Sunday = 7
                                    ELSE DATEPART(WEEKDAY, i.Invoice_Date) - 1  -- Monday=1, Tuesday=2, ..., Saturday=6
                                END
                    ),
                    AllDays AS (
                        -- Generate all 7 days of the week (1=Monday, 2=Tuesday, ..., 7=Sunday)
                        SELECT 1 AS day UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL 
                        SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL SELECT 7
                    )
                    SELECT 
                        ad.day,
                        ISNULL(dr.revenue, 0) AS revenue
                    FROM AllDays ad
                    LEFT JOIN DailyRevenue dr ON ad.day = dr.day
                    ORDER BY ad.day;";
                return connection.Query<DayRevenue>(sqlQuery, new { Manager_ID = managerID }).ToList();
            }
        }
    }
}

