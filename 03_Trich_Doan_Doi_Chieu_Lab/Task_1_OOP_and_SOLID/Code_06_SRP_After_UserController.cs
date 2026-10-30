public class UserController
{
    private readonly UserValidator _validator;
    private readonly IUseRepository _repository;
 
    public UserController(UserValidator validator, IUseRepository repository)
    {
        _validator = validator;
        _repository = repository;
    }
 
    public void CreateUser(string user, string email, string password)
    {
        if (!_validator.IsValidEmail(email))
        {
            throw new ArgumentException($"{email} invalid format");
        }
        _repository.Save(user, email, password);
    }
}
