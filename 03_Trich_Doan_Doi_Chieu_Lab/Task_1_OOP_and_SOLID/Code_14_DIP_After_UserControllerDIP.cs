public class UserControllerDIP
{
    private readonly IUserModelDIP _userRepository;   // abstraction
 
    public UserControllerDIP(IUserModelDIP userRepository)
    {
        _userRepository = userRepository;
    }
 
    public void CreateUser() { _userRepository.Inser(); }   // lab spelling
    public void UpdateUser() { _userRepository.Update(); }
    public void DeleteUser() { _userRepository.Delete(); }
}
