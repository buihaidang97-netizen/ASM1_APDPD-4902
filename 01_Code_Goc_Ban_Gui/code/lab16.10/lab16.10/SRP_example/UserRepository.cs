using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.SRP_example
{

    public class UserRepository : IUseRepository
    {
        public void Save(string user, string email, string password)
        {
            
            // luu thong tin nguoi dung vao database
            Console.WriteLine($"{user} saved successfully");
        }
        public void Update(string[] data, int ID)
        {
            throw new NotImplementedException();
            
        }
        public void Delete(int ID)
        {
            throw new NotImplementedException();
           
        }
    }
    
}
