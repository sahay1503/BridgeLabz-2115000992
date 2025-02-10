namespace HospitalManagementSystem
{
    // Concrete class for In-Patients
    public class InPatient : Patient, IMedicalRecord
    {
        private double dailyCharge;
        private int daysAdmitted;
        private List<string> medicalRecords; // Private list to store medical history

        public InPatient(int patientId, string name, int age, double dailyCharge, int daysAdmitted)
            : base(patientId, name, age)
        {
            this.dailyCharge = dailyCharge;
            this.daysAdmitted = daysAdmitted;
            this.medicalRecords = new List<string>(); // Initialize empty medical records list
        }

        // Override method to calculate the bill for in-patients
        public override double CalculateBill()
        {
            return dailyCharge * daysAdmitted;
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