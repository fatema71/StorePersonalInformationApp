using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeInformatonDBApp.Model
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address{ get; set; }
        public Designation Designation { get; set; }
        
    }
}
