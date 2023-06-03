class Video {
    public string _title;
    public string _author;
    public int _second;

    public List <Comment> Comments;

    public Video (string title, string author, int second ) {
        _title = title;
        _author = author;
        _second = second;
        Comments = new List <Comment> ();
    }

    public void AddComment (string name, string text)
    {
        Comment comment = new Comment (name, text);
        Comments.Add (comment);
    }
    public int NumOfComments ()
    {
        return Comments.Count;
    }
}