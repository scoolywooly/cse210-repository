using System.Security.Cryptography;

public class Comment 
{
    private string _commentText;
    private string _commentName;

    public Comment(string name, string text)
    {
        _commentText = text;
        _commentName = name;
    }

    public string getText() {
        return _commentText;
    }

    public string getName() {
        return _commentName;
    }
}