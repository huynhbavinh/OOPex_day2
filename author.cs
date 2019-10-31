using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPex
{
    class author
    {
        private string name, email;
        private char gender;

        public author(string name, string email, char sex)
        {
            this.name = name;
            this.email = email;
            this.gender = sex;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public char GetGender()
        {
            return this.gender;
        }
        public string SetEmail(string newEmail)
        {
            return this.email = newEmail;
        }
        public override string ToString()
        {
            //string sex;
            //if (this.gender == 1)
            //{
            //    sex = "Nam";
            //}
            //else
            //{
            //    sex = "Nữ";
            //}
            return String.Format("Author[name={0},email={1},Gender={2}]",
                this.name,this.email,gender);
        }
    }
}
