//Main Program
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Creating hospital
        Hospital myHospital = new Hospital("Saxena's Hospital Bareilly");

        // Creating doctors
        Doctor drRamesh = new Doctor("Ramesh ", "Cardiology");
        Doctor drPrakash = new Doctor("Prakash", "Neurology");

        // Creating patients
        Patient patientVijay = new Patient("Vijay Yadav");
        Patient patientRavi = new Patient("Ravi Singh");

        // Adding doctors and patients to hospital
        myHospital.AddDoctor(drRamesh);
        myHospital.AddDoctor(drPrakash);
        myHospital.AddPatient(patientVijay);
        myHospital.AddPatient(patientRavi);

        // Consulting doctors
        patientVijay.Consult(drRamesh);
        patientVijay.Consult(drPrakash);
        patientRavi.Consult(drRamesh);

        // Displaying hospital structure
        myHospital.DisplayHospital();
    }
}
