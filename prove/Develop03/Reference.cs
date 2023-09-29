using System;
using System.Data;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public string GetDisplayText()
    {
        string text = ($"Behold, I am a disciple of Jesus Christ, the Son of God.  I have been called of him to declare his word among his people, that they might have everlasting life.");
        return text;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = "";
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = "";
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;


    }
}