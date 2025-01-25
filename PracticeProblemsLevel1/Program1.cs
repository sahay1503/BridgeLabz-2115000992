using System;

// Class to check voting eligibility
class Program1
{
    public static string CheckVotingEligibility(int[] ages)
    {
        string result = "";
        for (int i = 0; i < ages.Length; i++)
        {
            if (ages[i] < 0)
            {
                result += $"Student {i + 1} has invalid age: {ages[i]}\n";
            }
            else if (ages[i] >= 18)
            {
                result += $"Student {i + 1} with age {ages[i]} can vote.\n";
            }
            else
            {
                result += $"Student {i + 1} with age {ages[i]} cannot vote.\n";
            }
        }
        return result;
    }
}
