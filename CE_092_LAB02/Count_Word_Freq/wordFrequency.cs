using System;
using System.Collections.Generic;

Console.Write("Enter a sentence: ");
string str = Console.ReadLine() ?? "";

Dictionary<string, int> freq = new Dictionary<string, int>();

string word = "";

for (int i = 0; i < str.Length; i++)
{
    if (str[i] != ' ')
    {
        word += str[i];
    }
    else
    {
        if (word != "")
        {
            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq.Add(word, 1);

            word = "";
        }
    }
}

// Add the last word (if there is one)
if (word != "")
{
    if (freq.ContainsKey(word))
        freq[word]++;
    else
        freq.Add(word, 1);
}

Console.WriteLine("\nWord Frequencies:");

foreach (KeyValuePair<string, int> f in freq)
{
    Console.WriteLine($"'{f.Key}' has {f.Value} occurrence(s).");
}
