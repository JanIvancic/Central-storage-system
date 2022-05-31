using CentralStorageSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralStorageSystem.Repos
{
    internal class EmployeeRepo
    {
        public static Employee GetEmployeeByUsername(string username)
        {
            Employee employee = null;

            string sql = $"SELECT * FROM Zaposlenici WHERE Username = '{username}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                employee = CreateObject(reader);
            }
            reader.Close();
            DB.CloseConnection();

            return employee;
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();

            string sql = "SELECT * FROM Zaposlenici";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                allEmployees.Add(CreateObject(reader));
            }

            return allEmployees;
        }


        private static Employee CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            string username = reader["Username"].ToString();
            string password = reader["Password"].ToString();

            Employee emp = new Employee
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
            };

            return emp;
        }
    }
}
