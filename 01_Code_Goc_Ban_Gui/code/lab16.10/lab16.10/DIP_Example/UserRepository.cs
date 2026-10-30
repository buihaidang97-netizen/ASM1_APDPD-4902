using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.DIP_Example
{
    internal class UserRepository : IUserModelDIP
    {
        public void Delete()
        {
           Console.WriteLine("Deleted data successfully");
        }

        public void Inser()
        {
           Console.WriteLine("Inserted data successfully");
        }

        public void Update()
        {
            Console.WriteLine("Updated data successfully");
        }
    }
}
