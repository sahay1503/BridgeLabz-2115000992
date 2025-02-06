//Class Hospital 
using System;
using System.Collections.Generic;

// Represents a hospital that associates doctors and patients
class Hospital
{
    // The name of the hospital
    public string Name { get; set; }

    // List of doctors working at the hospital
    public List<Doctor> Doctors { get; set; }

    // List of patients admitted or consulted at the hospital
    public List<Patient> Patients { get; set; }

    // Constructor to initialize the hospital with a name
    public Hospital(string name)
    {
        Name = name;
        Doctors = new List<Doctor>(); // Initializes an empty list of doctors
        Patients = new List<Patient>(); // Initializes an empty list of patients
    }

    // Adds a new doctor to the hospital
    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor); // Adds the doctor to the hospital's list of doctors
    }

    // Adds a new patient to the hospital
    public void AddPatient(Patient patient)
    {
        Patients.Add(patient); // Adds the patient to the hospital's list of patients
    }

    // Displays the hospital’s structure, including doctors and their patients
    public void DisplayHospital()
    {
        Console.WriteLine($"Hospital: {Name}");

        // Display all doctors and their associated patients
        Console.WriteLine("Doctors:");
        foreach (var doctor in Doctors)
        {
            doctor.DisplayPatients(); // Display each doctor’s consultations
        }

        // Display all patients and their consultations
        Console.WriteLine("Patients:");
        foreach (var patient in Patients)
        {
            patient.DisplayConsultations(); // Display each patient's consultation details
        }
    }
}
