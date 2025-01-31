using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        entries.ForEach(entry => Console.WriteLine(entry));
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, entries.ConvertAll(e => e.ToString()));
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
                entries.Add(new Entry(parts[1], parts[2]));
        }
        Console.WriteLine("Journal loaded.");
    }
}
