using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.DIP_Example
{
    public class UserControllerDIP     
    {
        private readonly IUserModelDIP _userRepository;
        public UserControllerDIP(IUserModelDIP userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser()
        {
            _userRepository.Inser();
        }
        public void UpdateUser()
        {
            _userRepository.Update();
        }
        public void DeleteUser()
        {
            _userRepository.Delete();
        }
    }
}
