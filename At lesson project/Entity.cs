using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_lesson_project
{
   abstract class Entity
    {
        public Guid guid { get; set; } = Guid.NewGuid();


    }
}
