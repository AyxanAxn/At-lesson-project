using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_lesson_project
{
    class Worker : Human, IWorker,IOrganize
    {
        public string Position { get; set; }
        public int Salary { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public void Organize()
        {
            
        }

        void CalculateSalaries (){ }
    
    
    }

}

