using System;

class Scripture
{
    private Reference _reference;
    public List<Word> _words;

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = ("Behold, I am a disciple of Jesus Christ, the Son of God.  I have been called of him to declare his word among his people, that they might have everlasting life.");
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool hide;
    }

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        text = "";
    }
}