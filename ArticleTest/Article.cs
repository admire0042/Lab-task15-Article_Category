namespace ArticleTest
{
    public class Article
    {
        // 1. Create a class call it Article with the following auto-implemented properties (Id, CategoryId, Title and Body) and a constructor for their initialization.
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Article(int id, int categ, string title, string body)
        {
            Id = id;
            CategoryId = categ;
            Title = title;
            Body = body;
        }
    }
}