//Patient
using System;
using System.Collections.Generic;

// Represents a patient who can consult multiple doctors
class Patient
{
    // The name of the patient
    public string Name { get; set; }

    // List of doctors the patient is consulting
    public List<Doctor> Doctors { get; set; }

    // Constructor to initialize the patient with a name
    public Patient(string name)
    {
        // Initialize the patient's name
        Name = name;

        // Initializes an empty list of doctors the patient will consult
        Doctors = new List<Doctor>();
    }

    // Adds a doctor to the patient's list of consultations (if not already added)
    public void Consult(Doctor doctor)
    {
        // Check if the doctor is already in the patient's list
        if (!Doctors.Contains(doctor))
        {
            // Add the doctor to the patient's consultation list
            Doctors.Add(doctor);

            // Add the patient to the doctor's list of patients
            doctor.Patients.Add(this);
        }

        // Print a message indicating the patient is consulting the doctor
        Console.WriteLine($"{Name} is consulting Dr. {doctor.Name}.");
    }

    // Displays all doctors the patient has consulted
    public void DisplayConsultations()
    {
        // Print the patient's name
        Console.WriteLine($"Patient: {Name}");

        // Loop through each doctor and display their details
        foreach (var doctor in Doctors)
        {
            // Print the doctor's name and their specialization
            Console.WriteLine($"Consulted Doctor: {doctor.Name}, Specialization: {doctor.Specialization}");
        }
    }
}
