public class AccountController
{
    private readonly UserModel model;      // concrete dependency
 
    public AccountController(UserModel model)
    {
        this.model = model;
    }
 
    public void SaveAccount()
    {
        model.Insert();
    }
}
