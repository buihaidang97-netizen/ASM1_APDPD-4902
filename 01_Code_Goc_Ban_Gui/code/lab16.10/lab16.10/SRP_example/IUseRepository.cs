using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.SRP_example
{
    public interface IUseRepository
    {
        void Save(string user, string email, string password);
        void Update(string[] data, int ID);
        void Delete(int ID);
    }
}
