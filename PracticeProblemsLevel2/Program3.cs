using System;
class Program3
{
    public string FindLargestAndSecondLargestDigit(int number)
    {
        int[] digits = new int[10];
        int index = 0;

        while (number != 0 && index < 10)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        return $"Largest digit: {largest}\nSecond largest digit: {secondLargest}";
    }
}
