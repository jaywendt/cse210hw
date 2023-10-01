using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public void Hide()
    {
        Console.Clear();
        Console.Write("___");
    }

    public void Show()
    {

    }

    public string GetDisplayText()
    {
        if (_text =)
        {
            string text = 
            return text;
        }
        else
        {
            
        }
    }

    public Word(string text)
    {
        _text = "";
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public void Hidden()
    {
        _isHidden = true;
    }

    public void notHidden()
    {
        _isHidden = false;
    }
}