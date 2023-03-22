namespace Domain;

public class Author : EntityBase
{
    public Author()
    {
        Books = new HashSet<Book>();
    }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Nationality { get; set; }
    public string Biography { get; set; }
    
    public ICollection<Book> Books { get; set; }
}