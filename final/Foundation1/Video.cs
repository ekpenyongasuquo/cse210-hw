public class Video
{
    private string _author;
    private string _title;
    private int _lenght;
    private List<Comment> _comments;

    public Video(string author, string title, int lenght)
    {
        _author = author;
        _title = title;
        _lenght = lenght;
        _comments = new List<Comment>();
    }
    public void AddComment(string author, string comment)
    {
        Comment newComment = new Comment(author, comment);
        _comments.Add(newComment);
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine("\n--- VIDEO INFO ---");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght in seconds: {_lenght}");
        Console.WriteLine($"Lenght in HH:MM:SS: {GetLenghtInHHMMSS()}");
        Console.WriteLine($"Number of comments: {GetCommentsCount()}");
    }
    public void DisplayVideoComments()
    {
        Console.WriteLine("\n--- COMMENTS ---");
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetUserName()}\n {comment.GetComment()}");
        }
    }
    public string GetLenghtInHHMMSS()
    {
        TimeSpan time = TimeSpan.FromSeconds(_lenght);
        return time.ToString(@"hh\:mm\:ss");

    }
    
    //GETTERS
    public string GetAuthor()
    {
        return _author;
    }
    public string GetTitle()
    {
        return _title;
    }
    public int GetLenght()
    {
        return _lenght;
    }
    public int GetCommentsCount()
    {
        return _comments.Count();
    }
}