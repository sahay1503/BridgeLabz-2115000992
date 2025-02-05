using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Creating company
        Company myCompany = new Company("Capgemini Consulting");

        // Adding departments
        myCompany.AddDepartment("IT");
        myCompany.AddDepartment("HR");

        // Adding employees to departments
        myCompany.AddEmployeeToDepartment("IT", "Sudhanshu Tripathi", "Software Engineer");
        myCompany.AddEmployeeToDepartment("IT", "Ayush Chandra", "System Administrator");
        myCompany.AddEmployeeToDepartment("HR", "Himanshu Rai", "HR Manager");

        // Displaying company structure
        myCompany.DisplayCompanyStructure();
    }
}
