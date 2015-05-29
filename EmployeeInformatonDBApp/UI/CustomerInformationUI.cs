using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using EmployeeInformatonDBApp.Model;
using EmployeeInformatonDBApp.BLL;

namespace EmployeeInformatonDBApp.UI
{
    public partial class CustomerInformationUI : Form
    {
        CustomerInformationManager objCustomerInformationManager = new CustomerInformationManager();
        Designation objDesignation = new Designation();
        SearchManager objSearchmanager = new SearchManager();
        int needUpdate = 0;

        public CustomerInformationUI(string editVal)
        {
            InitializeComponent();
            if (editVal != "")
            {
                string query = "SELECT * FROM Employee_Table where Name='" + editVal + "'";
                DataTable data = objSearchmanager.GetEditItem(query);

                string s = data.Rows[0][4].ToString();
                    nameTextBox.Text=data.Rows[0][1].ToString();
                    emailTextBox.Text=data.Rows[0][2].ToString();
                    addressTextBox.Text = data.Rows[0][3].ToString();

                    //designationComboBox.ValueMember = "Designation_ID";
                    designationComboBox.SelectedValue = Convert.ToInt16(data.Rows[0][4].ToString());
                    needUpdate = 1;
            }
        }

        private void CustomerInformationUI_Load(object sender, EventArgs e)
        {
            LoadDesignation();

        }

        private void addMoreButton_Click(object sender, EventArgs e)
        {
            DesignationUI objDesignationUI = new DesignationUI();
            objDesignationUI.Show();
            DataTable data = objCustomerInformationManager.GetDesignationTD(objDesignation);
            LoadDesignation();

           

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee objEmployee = new Employee();
            objEmployee.Name = nameTextBox.Text;
            objEmployee.Email = emailTextBox.Text;
            objEmployee.Address = addressTextBox.Text; 
            objDesignation.DesignationID = Convert.ToInt16(designationComboBox.SelectedValue);
            objEmployee.Designation = objDesignation;
           string output= objCustomerInformationManager.SaveEmployeeInfo(objEmployee);
           MessageBox.Show(output);
            
        }
        public void LoadDesignation()
        {
            designationComboBox.DataSource = objCustomerInformationManager.GetDesignationTD(objDesignation);
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "Designation_ID"; 
        }
      
    }
}
