using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidadVI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string? City { get; set; }
        public User() { }
        public User(string name, int age, decimal salary, string city)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.City = city;
        }
    }
}
