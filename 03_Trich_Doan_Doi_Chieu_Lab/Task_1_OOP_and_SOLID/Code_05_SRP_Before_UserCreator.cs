public class UserCreator
{
    public void CreateUser(string user, string email, string password)
    {
        if (!email.Contains("@")) return;             // validation
        File.AppendAllText("users.csv",               // persistence
            $"{user},{email},{password}\n");
    }
}
