using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.AccessControl;

namespace BASA2
{
    internal class Adminn
    {
        [Key] public int id { get; set; }
        [Key]
        public string name;
        public string password;

        public string NameAdmin
        {
            get { return name; }
            set { name = value; }
        }
        public string PasswordAdmin
        {
            get { return password; }
            set { password = value; }
        }

        public Adminn() { }
        public Adminn(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

    }
}
