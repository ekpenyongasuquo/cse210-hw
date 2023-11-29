public class Comment
{
    private string _userName;
    private string _comment;

    public Comment(string userName, string comment)
    {
        _userName = userName;
        _comment = comment;

    }
    //GETTERS
    public string GetUserName()
    {
        return _userName;
    }
    public string GetComment()
    {
        return _comment;
    }
}