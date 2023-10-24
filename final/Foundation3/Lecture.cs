using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity) : base("Lecture Event")
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}