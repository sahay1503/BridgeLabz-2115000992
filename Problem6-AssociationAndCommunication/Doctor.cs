//class Doctor
using System;
using System.Collections.Generic;

// Represents a doctor who can consult multiple patients
class Doctor
{
    // The name of the doctor
    public string Name { get; set; }

    // The area of specialization of the doctor
    public string Specialization { get; set; }

    // List of patients the doctor is currently consulting
    public List<Patient> Patients { get; set; }

    // Constructor to initialize the doctor with a name and specialization
    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
        Patients = new List<Patient>(); // Initializes an empty list of patients
    }

    // Displays all patients the doctor has consulted
    public void DisplayPatients()
    {
        Console.WriteLine($"Dr. {Name}, Specialization: {Specialization}");

        // Loop through each patient and display their name
        foreach (var patient in Patients)
        {
            Console.WriteLine($"Consulted Patient: {patient.Name}");
        }
    }
}
