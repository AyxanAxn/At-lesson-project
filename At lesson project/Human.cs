using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace At_lesson_project
{
   abstract class Human : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }

        public override string ToString()
        {
            return $"\nId - {guid}\nName - {Name}\nSurname - {Surname}\nAge - {Age}";
        }
        
    }
}
