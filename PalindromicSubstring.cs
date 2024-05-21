using System;

class MainClass
{
    public static string PalindromicSubstring(string str)
    {
        string longestPalindromic = String.Empty;
        char[] word = str.ToCharArray();
        char[] reversedWord = new char[word.Length];
        Array.Copy(word, reversedWord, word.Length);
        Array.Reverse(reversedWord);
        for (int palindromicSize = 3; palindromicSize <= word.Length; palindromicSize++)
        {
            for (int i = 0; i < word.Length - palindromicSize - 1; i++)
            {
                String potentialPalindromic = new String(word, i, palindromicSize);
                String potentialPalindromicAux = new String(reversedWord, word.Length - i - palindromicSize, palindromicSize);
                if (potentialPalindromic == potentialPalindromicAux)
                {
                    longestPalindromic = potentialPalindromic;
                }
            }
        }
        return longestPalindromic.Length > 2 ? longestPalindromic : "none";
    }

    static void Main()
    {
        Console.WriteLine(PalindromicSubstring(Console.ReadLine()));
    }
}
