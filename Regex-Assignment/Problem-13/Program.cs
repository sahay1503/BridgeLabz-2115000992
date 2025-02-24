using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static List<string> ExtractCurrencyValues(string text)
    {
        string pattern = @"\$\s?\d+(\.\d{2})?";

        MatchCollection matches = Regex.Matches(text, pattern);

        List<string> currencyValues = new List<string>();

        foreach (Match match in matches)
        {
            currencyValues.Add(match.Value.Trim());
        }

        return currencyValues;
    }

    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50. Another item costs $100.";

        List<string> extractedValues = ExtractCurrencyValues(text);

        Console.WriteLine("Extracted Currency Values:");
        Console.WriteLine(string.Join(", ", extractedValues));
    }
}
