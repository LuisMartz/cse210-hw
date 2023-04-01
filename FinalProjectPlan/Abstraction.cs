
namespace YouTubeVideos
{
    abstract class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Length { get; set; }

        private List<Comment> comments;

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }

        public void AddComment(string name, string text)
        {
            comments.Add(new Comment(name, text));
        }

        public int GetNumComments()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }

        public abstract void Display();
    }

    class Comment
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Comment(string name, string text)
        {
            Name = name;
            Text = text;
        }
    }

    class ConcreteVideo : Video
    {
        public ConcreteVideo(string title, string author, int length) : base(title, author, length)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Length: " + Length + " seconds");
            Console.WriteLine("Number of comments: " + GetNumComments());
            foreach (Comment comment in GetComments())
            {
                Console.WriteLine("Comment by " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}

