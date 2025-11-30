namespace E2EApplication.Models
{
    public class Book
    {
        public int id { get; set; }
        public required string title { get; set; }
        public required string author { get; set; }
        public required string yearPublished { get; set; }
    }
}
