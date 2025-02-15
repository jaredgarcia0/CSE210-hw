using System;

class Verse
{
    public string Reference;
    private List<Word> words;

    public Verse(string reference, string text)
    {
        Reference = reference;
        words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = words.Where(w => !w.Hidden).ToList();
        if (visibleWords.Count == 0) return;

        Random rand = new Random();
        List<Word> wordsToHide = visibleWords.OrderBy(x => rand.Next()).Take(count).ToList();

        foreach (Word word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool IsFullyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.Hidden)
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        string result = Reference + " ";
        foreach (Word word in words)
        {
            result += word.ToString() + " ";
        }
        return result.Trim();
    }
}