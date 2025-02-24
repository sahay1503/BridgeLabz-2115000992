using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidCreditCard(string cardNumber)
    {
        string pattern = @"^(4\d{15}|5\d{15})$";
        return Regex.IsMatch(cardNumber, pattern);
    }

    static void Main()
    {
        string[] testCards = { "4111111111111111", "5105105105105100", "1234567812345678", "4012888888881881", "5111111111111111", "378282246310005" };

        foreach (var card in testCards)
        {
            Console.WriteLine($"'{card}' is {(IsValidCreditCard(card) ? "Valid" : "Invalid")}");
        }
    }
}
