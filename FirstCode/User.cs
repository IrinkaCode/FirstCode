using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCode
{
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public TelephoneNumber Telephone { get; set; }
        public User() { }

        public User(string? name, string? email, int age, string? address, TelephoneNumber telephone)
        {
            Name = name;
            Email = email;
            Age = age;
            Address = address;
            Telephone = telephone;
        }
    }
}
