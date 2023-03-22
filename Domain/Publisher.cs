namespace Domain;

public class Publisher : EntityBase
{
    public Publisher()
    {
        Books = new HashSet<Book>();
    }
    
    public DateTime CreateDate { get; set; }
    public string Location { get; set; }
    
    public virtual ICollection<Book> Books { get; set; }
}