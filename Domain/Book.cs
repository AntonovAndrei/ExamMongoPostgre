namespace Domain;

public class Book : EntityBase
{
    public Book()
    {
        Authors = new HashSet<Author>();
        Publishers = new HashSet<Publisher>();
    }
    public string Genre { get; set; }
    public string Description { get; set; }
    
    public virtual ICollection<Author> Authors { get; set; }
    public virtual ICollection<Publisher> Publishers { get; set; }
}