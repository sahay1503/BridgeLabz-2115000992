using System;
class Program1
{
    public string CalculateEmployeeBonus(double[] salary, double[] yearsOfService)
    {
        double[] bonus = new double[10];
        double[] newSalary = new double[10];
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            bonus[i] = yearsOfService[i] > 5 ? salary[i] * 0.05 : salary[i] * 0.02;
            newSalary[i] = salary[i] + bonus[i];
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        return $"Total bonus payout: {totalBonus}\nTotal old salary: {totalOldSalary}\nTotal new salary: {totalNewSalary}";
    }
}
