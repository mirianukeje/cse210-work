using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture()
    {
        _reference = new Reference("John", 3, 16);
        string text = "For God so loved the world that he gave his only begotten Son";
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    // ✅ Improved logic to avoid hiding already hidden words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Get only the unhidden words
        List<Word> unhiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                unhiddenWords.Add(word);
            }
        }

        // Shuffle the unhidden words
        for (int i = unhiddenWords.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Word temp = unhiddenWords[i];
            unhiddenWords[i] = unhiddenWords[j];
            unhiddenWords[j] = temp;
        }

        // Hide up to the requested number of unhidden words
        int count = Math.Min(numberToHide, unhiddenWords.Count);
        for (int i = 0; i < count; i++)
        {
            unhiddenWords[i].Hide();
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " - ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
