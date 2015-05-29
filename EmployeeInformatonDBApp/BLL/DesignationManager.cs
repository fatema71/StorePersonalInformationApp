using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeInformatonDBApp.Model;
using EmployeeInformatonDBApp.DAL;
using System.Data;

namespace EmployeeInformatonDBApp.BLL
{
    class DesignationManager
    {
       
        DesignationGateway objDesignationGateway = new DesignationGateway();
       
        public string SaveDesignation(Designation objDesignation)
        {
            if (!CheckCode(objDesignation))
            {
                int rowAffected = objDesignationGateway.SaveDesignation(objDesignation);
                if (rowAffected > 0)
                {
                    return "saved successfully";
                }
                else
                {
                    return "save failed";
                }
            }
            else
            {
                return "code is available";
            }
            

        }
        public bool CheckCode(Designation objDesignation)
        { 
           bool isExist= objDesignationGateway.CheckCode(objDesignation);
           return isExist;
        }
        //public DataTable loadCombobox(Designation objDesignation)
        //{
        //  DataTable data= objDesignationGateway.loadCombobox(objDesignation);
        //  return data;
        //}
    }
}
