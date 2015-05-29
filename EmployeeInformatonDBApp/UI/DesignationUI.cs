using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeInformatonDBApp.BLL;
using EmployeeInformatonDBApp.Model;

namespace EmployeeInformatonDBApp.UI
{
    public partial class DesignationUI : Form
    {
       
        public DesignationUI()
        {
            InitializeComponent();
        }
       
       
   public void saveButton_Click(object sender, EventArgs e)
        {
            Designation objDesignation = new Designation();
            DesignationManager objDesignationManager = new DesignationManager();
            objDesignation.Code = codeTextBox.Text;
            objDesignation.Title = titleTextBox.Text;

            string output = objDesignationManager.SaveDesignation(objDesignation);
            MessageBox.Show(output);
         }

    }
}

       

          
        
