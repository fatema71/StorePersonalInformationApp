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
    class CustomerInformationGateway
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
        public int SaveEmployeeInfo(Employee objEmployee)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string query = "INSERT INTO Employee_Table VALUES('" +objEmployee.Name + "','" + objEmployee.Email + "','"+objEmployee.Address+"','"+objEmployee.Designation.DesignationID+"')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public DataTable GetDesignationTD(Designation objDesignation)
        {
            string connstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            string query = "SELECT * FROM Designation_Table";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
    }
}
