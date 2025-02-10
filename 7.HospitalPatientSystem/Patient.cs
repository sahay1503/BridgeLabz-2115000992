namespace HospitalManagementSystem
{
    // Abstract base class for all patients
    public abstract class Patient
    {
        // Private fields to store patient details
        private int patientId;
        private string name;
        private int age;

        // Public property for Patient ID (read-only)
        public int PatientId
        {
            get { return patientId; }
            private set { patientId = value; }
        }

        // Public property for Name (read-only)
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        // Public property for Age (read-only)
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        // Constructor to initialize a patient
        public Patient(int patientId, string name, int age)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
        }

        // Abstract method to calculate the hospital bill (implemented in derived classes)
        public abstract double CalculateBill();

        // Method to display patient details
        public virtual void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
        }
    }

}