using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_lesson_project
{
    class Credit
    {
        public Client client { get; set; }

        public int Amount { get; set; }
        public int Percent { get; set; }
        public int Mounth { get; set; }
        public int CalculatePercent { get; set; }
        public int Payment { get; set; }
        public int PaymentPerMonth { get; set; }

        void CalculatePayment()
        {
            Payment = (Amount * (100 + Percent) / 100);

        } 
        
        void CalculatePaymentPerMonth()
        {
            Payment = (Amount * (100 + Percent) / 100)/12;

        }

    }
}
