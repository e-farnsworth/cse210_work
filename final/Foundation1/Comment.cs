public class Comment
{
    private string _name;
    private string _comment;
    // Tracks the name of the commenter and the text of the comment
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetCommentInformation()
    {
        return $"@{_name}\n{_comment}" + $"\n";
    }
}