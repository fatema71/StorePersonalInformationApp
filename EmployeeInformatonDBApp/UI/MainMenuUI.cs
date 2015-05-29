using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeInformatonDBApp.UI
{
    public partial class MainMenuUI : Form
    {
        public MainMenuUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CustomerInformationUI objCustomerInformationUI = new CustomerInformationUI("");
            objCustomerInformationUI.Show();
        }

        private void findNEditButton_Click(object sender, EventArgs e)
        {
            EditSearchUI objEditSearchUI=new EditSearchUI();
            objEditSearchUI.Show();
        }
    }
}
