using System;
using System.Collections.Generic;

class Policy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override string ToString()
    {
        return $"{PolicyNumber} | {CoverageType} | Expires: {ExpiryDate.ToShortDateString()}";
    }
}

class InsurancePolicyManagement
{
    private List<Policy> policies = new List<Policy>();
    private List<string> duplicatePolicyNumbers = new List<string>();

    public void AddPolicy(Policy policy)
    {
        bool exists = false;
        foreach (var p in policies)
        {
            if (p.PolicyNumber == policy.PolicyNumber)
            {
                exists = true;
                if (!duplicatePolicyNumbers.Contains(policy.PolicyNumber))
                {
                    duplicatePolicyNumbers.Add(policy.PolicyNumber);
                }
                break;
            }
        }

        if (!exists)
        {
            policies.Add(policy);
            Console.WriteLine($"Policy {policy.PolicyNumber} added successfully!");
        }
        else
        {
            Console.WriteLine($"Duplicate Policy {policy.PolicyNumber} detected! Not added.");
        }
    }

    public List<Policy> GetAllUniquePolicies()
    {
        return policies;
    }

    public List<Policy> GetExpiringSoonPolicies(int days)
    {
        DateTime today = DateTime.Today;
        List<Policy> expiringSoon = new List<Policy>();

        foreach (var policy in policies)
        {
            if ((policy.ExpiryDate - today).Days <= days)
            {
                expiringSoon.Add(policy);
            }
        }

        return expiringSoon;
    }

    public List<Policy> GetPoliciesByCoverageType(string coverageType)
    {
        List<Policy> filteredPolicies = new List<Policy>();

        foreach (var policy in policies)
        {
            if (policy.CoverageType.Equals(coverageType, StringComparison.OrdinalIgnoreCase))
            {
                filteredPolicies.Add(policy);
            }
        }

        return filteredPolicies;
    }

    public List<string> GetDuplicatePolicyNumbers()
    {
        return duplicatePolicyNumbers;
    }

    public List<Policy> GetSortedPoliciesByExpiryDate()
    {
        List<Policy> sortedPolicies = new List<Policy>(policies);
        sortedPolicies.Sort((p1, p2) => p1.ExpiryDate.CompareTo(p2.ExpiryDate));
        return sortedPolicies;
    }
}

class Program
{
    static void Main()
    {
        InsurancePolicyManagement policyManager = new InsurancePolicyManagement();

        while (true)
        {
            Console.WriteLine("\nInsurance Policy Management System");
            Console.WriteLine("1. Add a New Policy");
            Console.WriteLine("2. View All Unique Policies");
            Console.WriteLine("3. View Policies Expiring Soon (Within 30 Days)");
            Console.WriteLine("4. Search Policies by Coverage Type");
            Console.WriteLine("5. View Duplicate Policies");
            Console.WriteLine("6. View Sorted Policies by Expiry Date");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Policy Number: ");
                    string policyNumber = Console.ReadLine();

                    Console.Write("Enter Coverage Type: ");
                    string coverageType = Console.ReadLine();

                    Console.Write("Enter Expiry Date (YYYY-MM-DD): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime expiryDate))
                    {
                        policyManager.AddPolicy(new Policy(policyNumber, coverageType, expiryDate));
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format!");
                    }
                    break;

                case "2":
                    Console.WriteLine("\nAll Unique Policies:");
                    foreach (var policy in policyManager.GetAllUniquePolicies())
                    {
                        Console.WriteLine(policy);
                    }
                    break;

                case "3":
                    Console.WriteLine("\nPolicies Expiring Soon (Within 30 Days):");
                    foreach (var policy in policyManager.GetExpiringSoonPolicies(30))
                    {
                        Console.WriteLine(policy);
                    }
                    break;

                case "4":
                    Console.Write("Enter Coverage Type to Search: ");
                    string searchType = Console.ReadLine();
                    Console.WriteLine($"\nPolicies with Coverage Type '{searchType}':");
                    foreach (var policy in policyManager.GetPoliciesByCoverageType(searchType))
                    {
                        Console.WriteLine(policy);
                    }
                    break;

                case "5":
                    Console.WriteLine("\nDuplicate Policy Numbers:");
                    foreach (var policyNumberDup in policyManager.GetDuplicatePolicyNumbers())
                    {
                        Console.WriteLine(policyNumberDup);
                    }
                    break;

                case "6":
                    Console.WriteLine("\nSorted Policies by Expiry Date:");
                    foreach (var policy in policyManager.GetSortedPoliciesByExpiryDate())
                    {
                        Console.WriteLine(policy);
                    }
                    break;

                case "7":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
} 

