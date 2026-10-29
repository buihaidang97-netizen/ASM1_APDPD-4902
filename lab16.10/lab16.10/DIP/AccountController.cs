using System;
using System.Collections.Generic;
using System.Text;

namespace lab16._10.DIP
{
    public class AccountController
    {
        private readonly UserModel model;
        public AccountController(UserModel model)
        {
            this.model = model;
        }
        public void SaveAccount()
        {
            model.Insert();
        }
    }
}
