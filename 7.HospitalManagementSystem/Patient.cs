public class Patient
{
    // Static variable shared across all instances, representing the hospital's name
    public static string HospitalName = "City Hospital";

    // Readonly field for PatientID (cannot be modified after initialization)
    public readonly int PatientID;

    // Instance fields to store patient's name, age, and ailment
    private string Name;
    private int Age;
    private string Ailment;

    // Static variable to keep track of the total number of patients admitted
    private static int totalPatients = 0;

    // Constructor to initialize patient's details: Name, Age, and Ailment
    public Patient(string name, int age, string ailment)
    {
        this.Name = name;  // Assign the patient's name
        this.Age = age;  // Assign the patient's age
        this.Ailment = ailment;  // Assign the patient's ailment
        this.PatientID = ++totalPatients;  // Assign a unique PatientID and increment the total patient count
    }

    // Static method to display the total number of patients admitted
    public static void GetTotalPatients()
    {
        Console.WriteLine($"Total Patients Admitted: {totalPatients}");
    }

    // Method to display patient details
    public void DisplayPatientDetails()
    {
        Console.WriteLine($"Hospital Name: {HospitalName}");
        Console.WriteLine($"Patient ID: {PatientID}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Ailment: {Ailment}");
    }

    // Static method to validate whether an object is an instance of the Patient class
    public static void DisplayIfPatient(object obj)
    {
        if (obj is Patient patient)
        {
            patient.DisplayPatientDetails();
        }
        else
        {
            Console.WriteLine("This is not a valid Patient object.");
        }
    }
}
