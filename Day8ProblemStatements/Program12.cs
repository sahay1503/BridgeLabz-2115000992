using System;
public class Program12
{
    public static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        for (int i = 0; i < sentence.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < oldWord.Length; j++)
            {
                if (i + j >= sentence.Length || sentence[i + j] != oldWord[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                result += newWord;
                i += oldWord.Length - 1;
            }
            else
            {
                result += sentence[i];
            }
        }
        return result;
    }
}