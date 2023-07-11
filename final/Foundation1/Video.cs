public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds
    private List<Comment> _comments = new List<Comment>();
    private Comment _comment;
    // Tracks the title, author, and length (in seconds) of the video
    // Tracks a list of comments on the video

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetVideoInformation()
    {
        return $"Title: {_title} || Author: {_author}\n Length: {_length} seconds || {_comments.Count()} total comments";
    }

    public void AddComment(string name, string comment)
    {
        _comment = new Comment(name, comment);
        _comments.Add(_comment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetCommentInformation());
        }
    }

}