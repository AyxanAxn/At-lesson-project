using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_lesson_project
{
 




    class CEO:Human,IWorker, IControlAndMakeMetting, Organize
    {
        public string Position { get; set; }
        public int Salary { get; set; }
        public int MyProperty { get; set; }

        public void Control()
        {
            throw new NotImplementedException();
        }

        public void MakeMetteng()
        {
            throw new NotImplementedException();
        }

        public void Organize()
        {
            throw new NotImplementedException();
        }

        void DecreasePrecentage(int percent) { 
        
        
        }

    }
}
