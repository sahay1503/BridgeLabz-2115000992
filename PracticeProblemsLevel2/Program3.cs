using System;

// Creating a class to calculate grades based on marks
class Program3
{
    // Function to calculate grade and remarks
    public static string CalculateGrade(int physics, int chemistry, int maths)
    {
        // Calculate the percentage
        int totalMarks = physics + chemistry + maths;
        double percentage = totalMarks / 3.0;

        // Determine grade based on percentage
        string grade, remarks;
        if (percentage >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards.";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards.";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching agency-normalized standards.";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards.";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards.";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards.";
        }

        return $"Percentage: {percentage:F2}%\nGrade: {grade}\nRemarks: {remarks}";
    }
}