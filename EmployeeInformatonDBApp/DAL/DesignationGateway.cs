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
    class DesignationGateway
    {
        string connectionstring = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;
       
        public int SaveDesignation(Designation objDesignation)
        {

            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string query = "INSERT INTO Designation_Table VALUES('"+objDesignation.Code+"','"+objDesignation.Title+"')";
            SqlCommand command = new SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
       }
        public bool CheckCode(Designation objDesignation)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            string query = "SELECT * FROM Designation_Table where Code='"+objDesignation.Code+"' ";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool isExist = reader.Read();
            connection.Close();
            return isExist;

        }
        //public DataTable loadCombobox(Designation objDesignation)
        //{
        //    SqlConnection connection = new SqlConnection(connectionstring);
        //    connection.Open();
        //    string query = "SELECT * FROM Designation_Table";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataTable data = new DataTable();
        //    adapter.Fill(data);
        //    connection.Close();
        //    return data;


        //}
    }
}
