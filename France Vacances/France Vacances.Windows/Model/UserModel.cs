using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Model
{
    class UserModel
    {
        private int _id;
        private string _email;
        private string _password;
        private string _formatDateTime;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string FormatDateTime
        {
            get { return _formatDateTime; }
            set { _formatDateTime = value; }
        }
        public UserModel()
        {
            _id = 0;
            _email = "myemail@email.com";
            _password = "123abc";
            _formatDateTime = DateTime.Now.ToString("f");

        }

        public UserModel(int id, string email, string password)
        {
            this._id = id;
            this._email = email;
            this._password = password;
        }
    }
}
