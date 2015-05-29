using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeInformatonDBApp.Model;
using EmployeeInformatonDBApp.DAL;
using System.Data;

namespace EmployeeInformatonDBApp.BLL
{
    class CustomerInformationManager
    {
        CustomerInformationGateway objCustomerInformationGateway = new CustomerInformationGateway();
        public string SaveEmployeeInfo(Employee objEmployee)
        {
           int rowAffected=objCustomerInformationGateway.SaveEmployeeInfo(objEmployee);
           if (rowAffected > 0)
           {
               return "saved successfully";
           }
           else
           {
               return "save failed";
           }
        }
        public DataTable GetDesignationTD(Designation objDesignation)
        {
           DataTable data= objCustomerInformationGateway.GetDesignationTD(objDesignation);
           return data;
        }
    }
}
