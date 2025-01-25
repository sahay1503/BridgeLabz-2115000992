using System;
class Program8
{
    public string CalculateStudentGrades(int[] physics, int[] chemistry, int[] maths)
    {
        string result = "";
        for (int i = 0; i < physics.Length; i++)
        {
            int total = physics[i] + chemistry[i] + maths[i];
            double average = total / 3.0;
            string grade = average >= 90 ? "A" : average >= 75 ? "B" : average >= 50 ? "C" : "D";
            result += $"Student {i + 1}: Total Marks = {total}, Average = {average:F2}, Grade = {grade}\n";
        }
        return result;
    }
}