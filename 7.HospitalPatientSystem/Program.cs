using System;
using System.Collections.Generic;

namespace HospitalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of patients (demonstrating polymorphism)
            List<Patient> patients = new List<Patient>
            {
                new InPatient(101, "Swati Verma", 45, 2000, 5),
                new OutPatient(102, "Mansi Singh", 30, 500),
                new InPatient(103, "Piyush Kumar Singh", 55, 2500, 3),
                new OutPatient(104, "Munish Saxena", 40, 600)
            };

            // Display patient details and billing information
            foreach (var patient in patients)
            {
                patient.GetPatientDetails();
                Console.WriteLine($"Total Bill: {patient.CalculateBill():C}");

                // Check if patient has a medical record
                if (patient is IMedicalRecord medicalRecordPatient)
                {
                    medicalRecordPatient.AddRecord("Initial Checkup - Stable Condition");
                    medicalRecordPatient.ViewRecords();
                }

                Console.WriteLine(); 
            }
        }
    }
}
