using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length} seconds:");
        Console.WriteLine($"Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }


}