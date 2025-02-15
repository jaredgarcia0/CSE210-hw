using System;

class Scripture
{
    private List<Verse> verses;

    public Scripture(string reference, string text)
    {
        verses = new List<Verse>();
        string[] lines = text.Split('\n');

        foreach (string line in lines)
        {
            verses.Add(new Verse(reference, line.Trim()));
        }
    }

    public void HideRandomWords(int count)
    {
        foreach (Verse verse in verses)
        {
            verse.HideRandomWords(count);
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Verse verse in verses)
        {
            if (!verse.IsFullyHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void Display()
    {
        Console.Clear();
        foreach (Verse verse in verses)
        {
            Console.WriteLine(verse.ToString());
        }
    }
}

