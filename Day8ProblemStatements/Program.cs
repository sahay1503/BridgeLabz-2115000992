﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to count vowels and consonants:");
        string text1 = Console.ReadLine();
        var vowelConsonantCount = Program1.CountVowelsAndConsonants(text1);
        Console.WriteLine($"Vowels: {vowelConsonantCount.vowels}, Consonants: {vowelConsonantCount.consonants}");

        Console.WriteLine("Enter a string to reverse:");
        string text2 = Console.ReadLine();
        Console.WriteLine(Program2.ReverseString(text2));

        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string text3 = Console.ReadLine();
        Console.WriteLine(Program3.IsPalindrome(text3));

        Console.WriteLine("Enter a string to remove duplicates:");
        string text4 = Console.ReadLine();
        Console.WriteLine(Program4.RemoveDuplicates(text4));

        Console.WriteLine("Enter a sentence to find the longest word:");
        string sentence = Console.ReadLine();
        Console.WriteLine(Program5.FindLongestWord(sentence));

        Console.WriteLine("Enter a string:");
        string mainText = Console.ReadLine();
        Console.WriteLine("Enter a substring to count occurrences:");
        string substring = Console.ReadLine();
        Console.WriteLine(Program6.CountSubstringOccurrences(mainText, substring));

        Console.WriteLine("Enter a string to toggle case:");
        string text7 = Console.ReadLine();
        Console.WriteLine(Program7.ToggleCase(text7));

        Console.WriteLine("Enter first string to compare:");
        string firstString = Console.ReadLine();
        Console.WriteLine("Enter second string to compare:");
        string secondString = Console.ReadLine();
        Console.WriteLine(Program8.CompareStrings(firstString, secondString));

        Console.WriteLine("Enter a string to find the most frequent character:");
        string text9 = Console.ReadLine();
        Console.WriteLine(Program9.FindMostFrequentCharacter(text9));

        Console.WriteLine("Enter a string:");
        string mainString = Console.ReadLine();
        Console.WriteLine("Enter a character to remove:");
        char characterToRemove = char.Parse(Console.ReadLine());
        Console.WriteLine(Program10.RemoveCharacter(mainString, characterToRemove));

        Console.WriteLine("Enter first string to check for anagram:");
        string firstAnagram = Console.ReadLine();
        Console.WriteLine("Enter second string to check for anagram:");
        string secondAnagram = Console.ReadLine();
        Console.WriteLine(Program11.AreAnagrams(firstAnagram, secondAnagram));

        Console.WriteLine("Enter a sentence:");
        string sentenceToModify = Console.ReadLine();
        Console.WriteLine("Enter the word to replace:");
        string wordToReplace = Console.ReadLine();
        Console.WriteLine("Enter the replacement word:");
        string replacementWord = Console.ReadLine();
        Console.WriteLine(Program12.ReplaceWord(sentenceToModify, wordToReplace, replacementWord));
    }
}
