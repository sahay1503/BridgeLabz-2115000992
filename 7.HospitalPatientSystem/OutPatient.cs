namespace HospitalManagementSystem
{
    // Concrete class for Out-Patients
    public class OutPatient : Patient, IMedicalRecord
    {
        private double consultationFee;
        private List<string> medicalRecords; // Private list to store medical history

        public OutPatient(int patientId, string name, int age, double consultationFee)
            : base(patientId, name, age)
        {
            this.consultationFee = consultationFee;
            this.medicalRecords = new List<string>(); // Initialize empty medical records list
        }

        // Override method to calculate the bill for out-patients
        public override double CalculateBill()
        {
            return consultationFee;
        }

        // Implement IMedicalRecord interface methods
        public void AddRecord(string record)
        {
            medicalRecords.Add(record);
            Console.WriteLine("Medical record added successfully.");
        }

        public void ViewRecords()
        {
            Console.WriteLine("Medical Records:");
            foreach (var record in medicalRecords)
            {
                Console.WriteLine($"- {record}");
            }
        }
    }
}