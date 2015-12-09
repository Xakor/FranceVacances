using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace France_Vacances.Model
{
    public class UserModel
    {
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _formatDateTime;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
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

        //Constructor
        public UserModel(int id, string name, string email, string password, string formatDateTime)
        {
            this._id = id;
            this._name = name;
            this._email = email;
            this._password = password;
            this._formatDateTime = formatDateTime;
        }

        public UserModel()
        {
            
        }

        
        //public static UserMode UserModels()
        //{
        //    return new
        //    {
        //        new UserModel(1, "Frank Andersen", "fha.post@gmail.com", "password", DateTime.Now.ToString()),
        //        new UserModel(2, "Test Person", "test@test.com", "test", DateTime.Now.ToString()),
        //    };
        //}

    }
}
