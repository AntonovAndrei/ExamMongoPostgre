using Domain;
using PostgrePersistence;

namespace ExamMongoPostgre.Controllers;

public class AuthorController : CrudControllerBase<Author>
{
    public  AuthorController(DataContext context)
        : base(context){}
    
}