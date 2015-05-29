using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeInformatonDBApp.Model;
using EmployeeInformatonDBApp.DAL;
using System.Data;

namespace EmployeeInformatonDBApp.BLL
{
    class SearchManager
    {
        SearchGateway objSearchGateway = new SearchGateway();
        public DataTable ShowListViewItem(Employee objEmployee)
        {

            DataTable data = objSearchGateway.ShowListViewItem(objEmployee);
            return data;

        }
        public DataTable ShowSearchItem(Employee objEmployee)
        {
            return objSearchGateway.ShowSearchItem(objEmployee);
        }
        public DataTable GetEditItem(string query)
        {
            return objSearchGateway.GetEditItem(query);
        }
    }
}
