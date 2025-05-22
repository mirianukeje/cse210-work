using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save as text (pipe-separated)
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // Save: date|tag|prompt|entry
                outputFile.WriteLine($"{entry._date}|{entry._tag}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    // Load from text (pipe-separated)
    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 4)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._tag = parts[1];
                entry._promptText = parts[2];
                entry._entryText = parts[3];
                _entries.Add(entry);
            }
        }
    }
}
