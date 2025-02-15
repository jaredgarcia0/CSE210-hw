using System;

class Word
{
    public string Text;
    public bool Hidden;

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public override string ToString()
    {
        return Hidden ? new string('_', Text.Length) : Text;
    }
}