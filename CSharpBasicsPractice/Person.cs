using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpBasicsPractice
{
    internal class Person
    {
        int Id { get; set; }
        string? Name { get; set; }
        int? Age { get; set; }
        string? Email { get; set; }
        long Mobile { get; set; }
        public Person(int id, string? name, int? age, string? email, long mobile)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
            Mobile = mobile;
        }

        public override string ToString()
        {
           
            return $"The name is: {Name} \n " +
                              $"Age is: {Age}\n "+
                              $"Email is: {Email} \n "+
                              $"Mobile number is: {Mobile}";
        }
    }
}