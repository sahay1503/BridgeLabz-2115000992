using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EmployeeManagementSystem
{
    public interface IDepartment
    {
        void AssignDepartment(string department);
        string GetDepartmentDetails();

    }
}
