using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork2;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText(@"C:\Users\Альбина\Desktop\HW13.2.txt");

        string textUp = text.ToUpper();

        var noPunctuationText = new string(textUp.Where(c => !char.IsPunctuation(c)).ToArray());

        char[] delimiters = new char [] { ' ', '\r', '\n' };

        var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        var hSet = new HashSet<string>(words);

        var repeatedWords = new Dictionary<string, int>();

        foreach (var word in hSet) 
        {
            repeatedWords.Add(word, 0);        
        }

        foreach (var word in words) 
        {
        if (repeatedWords.ContainsKey(word)) 
            { 
            
            }
        }
    }

}
