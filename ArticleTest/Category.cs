namespace ArticleTest
{
    public class Category
    {
        // List<Category> Categories = new List<Category> ();
        //     Categories.Add (new Category (1, "Sports"));
        //     Categories.Add (new Category (2, "Politics"));
        //     Categories.Add (new Category (3, "Religion"));
        //     Categories.Add (new Category (4, "Entertainment")); 
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            CategoryName = name;
        }

    }
}