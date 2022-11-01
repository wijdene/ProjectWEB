namespace MoviesRepository.Data.Models
{
    public class Category
    {
        public Category(string name, int id = 0)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }
    }
}
