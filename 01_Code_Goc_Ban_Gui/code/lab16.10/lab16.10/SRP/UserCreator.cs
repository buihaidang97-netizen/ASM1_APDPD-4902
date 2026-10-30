using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.SRP
{
    internal class UserCreator
    {
        //class co nhiem vu di tao tai khoan nguoi dung
        // viet method kiem tra email hop le
        private bool IsValidEmail(string email)
        {
            // kiem tra email hop le
            return true;

        }
        private void SaveUser(string user, string email, string password)
        {
            // luu thong tin nguoi dung vao database
            Console.WriteLine("save successfully");
        }
        public void CreateUser(string user, string email, string password)
        {
            if (!IsValidEmail(email))
            {
                throw new Exception("Invalid email");
            }
            SaveUser(user, email, password);
        }

    }
}
