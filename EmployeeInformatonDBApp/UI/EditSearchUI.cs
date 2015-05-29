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
    public partial class EditSearchUI : Form
    {
        public EditSearchUI()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {  
            detailShowListView.Items.Clear();
            Employee objEmployee = new Employee();
            SearchManager objSearchManager = new SearchManager();
            
            if (searchNameTextBox.Text == "")
            {
                DataTable data = objSearchManager.ShowListViewItem(objEmployee);
                int i = 0;
                while (i < data.Rows.Count)
                {
                    ListViewItem item = new ListViewItem(data.Rows[i][0].ToString());
                    item.SubItems.Add(data.Rows[i][1].ToString());
                    item.SubItems.Add(data.Rows[i][2].ToString());
                    detailShowListView.Items.Add(item);
                    i++;
                }


            }
            else
            {
                objEmployee.Name = searchNameTextBox.Text;
                DataTable data = objSearchManager.ShowSearchItem(objEmployee);
                int i = 0;
                while (i < data.Rows.Count)
                {
                    ListViewItem item = new ListViewItem(data.Rows[i][0].ToString());
                    item.SubItems.Add(data.Rows[i][1].ToString());
                    item.SubItems.Add(data.Rows[i][2].ToString());
                    detailShowListView.Items.Add(item);
                    i++;
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int index = detailShowListView.SelectedIndices[0];
            ListViewItem item = detailShowListView.Items[index];
            string name =item.SubItems[1].Text;

            CustomerInformationUI objCustomerInformationUI = new CustomerInformationUI(name);
            objCustomerInformationUI.Show();
        }
    }
}
