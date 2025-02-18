using System;
using System.Collections.Generic;

// Abstract class representing a job role
abstract class JobRole
{
    public string CandidateName { get; set; }
    public int ExperienceYears { get; set; }

    public JobRole(string candidateName, int experienceYears)
    {
        CandidateName = candidateName;
        ExperienceYears = experienceYears;
    }

    public abstract void DisplayJobDetails();
}

// Specific job roles
class SoftwareEngineer : JobRole
{
    public SoftwareEngineer(string candidateName, int experienceYears)
        : base(candidateName, experienceYears) { }

    public override void DisplayJobDetails()
    {
        Console.WriteLine($"{CandidateName} applied for Software Engineer with {ExperienceYears} years of experience.");
    }
}

class DataScientist : JobRole
{
    public DataScientist(string candidateName, int experienceYears)
        : base(candidateName, experienceYears) { }

    public override void DisplayJobDetails()
    {
        Console.WriteLine($"{CandidateName} applied for Data Scientist with {ExperienceYears} years of experience.");
    }
}

// Generic class for resume processing
class Resume<T> where T : JobRole
{
    public T CandidateInfo { get; set; }

    public Resume(T candidateInfo)
    {
        CandidateInfo = candidateInfo;
    }

    public void DisplayResume()
    {
        CandidateInfo.DisplayJobDetails();
    }
}

// Resume Screening System
class ResumeScreeningSystem
{
    private List<object> resumes = new List<object>();

    // Generic method to add a resume dynamically
    public void AddResume<T>(Resume<T> resume) where T : JobRole
    {
        resumes.Add(resume);
    }

    // Process and display resumes
    public void ScreenResumes()
    {
        Console.WriteLine("\nProcessing Resumes...");
        foreach (var item in resumes)
        {
            if (item is Resume<SoftwareEngineer> seResume)
                seResume.DisplayResume();
            else if (item is Resume<DataScientist> dsResume)
                dsResume.DisplayResume();
        }
    }
}

class Program
{
    static void Main()
    {
        ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem();

        while (true)
        {
            Console.WriteLine("\n1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Process Resumes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Candidate Name: ");
                    string seName = Console.ReadLine();
                    Console.Write("Enter Experience Years: ");
                    int seExp = int.Parse(Console.ReadLine());

                    Resume<SoftwareEngineer> seResume = new Resume<SoftwareEngineer>(
                        new SoftwareEngineer(seName, seExp));
                    screeningSystem.AddResume(seResume);
                    Console.WriteLine("Software Engineer resume added.");
                    break;

                case "2":
                    Console.Write("Enter Candidate Name: ");
                    string dsName = Console.ReadLine();
                    Console.Write("Enter Experience Years: ");
                    int dsExp = int.Parse(Console.ReadLine());

                    Resume<DataScientist> dsResume = new Resume<DataScientist>(
                        new DataScientist(dsName, dsExp));
                    screeningSystem.AddResume(dsResume);
                    Console.WriteLine("Data Scientist resume added.");
                    break;

                case "3":
                    screeningSystem.ScreenResumes();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
