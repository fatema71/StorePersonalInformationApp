using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeInformatonDBApp.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeInformatonDBApp.DAL
{
    class SearchGateway
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
        public DataTable ShowListViewItem(Employee objEmployee)
        {
            string connstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            string query = "SELECT * FROM Employee_Table";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable ShowSearchItem(Employee objEmployee)
        {
            string connstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            string query = "SELECT * FROM Employee_Table where Name like '%"+objEmployee.Name+"%'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable GetEditItem(string query)
        {
            string connstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open(); 
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}
