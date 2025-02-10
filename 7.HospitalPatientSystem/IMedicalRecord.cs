namespace HospitalManagementSystem
{
    // Interface for handling medical records
    public interface IMedicalRecord
    {
        void AddRecord(string record); // Method to add medical records
        void ViewRecords();            // Method to view medical records
    }
}