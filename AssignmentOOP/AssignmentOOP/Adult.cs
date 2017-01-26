//Student No: S10166869 , S10162177
//Student Name: Jourdan Lim , Sean Yeo Degen
//Module Group: IT05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Adult : Ticket
    {
        //ATTRIBUTES
        public bool PopcornOffer { get; set; }

        //CONSTRUCTORS
        //Default
        public Adult() { }

        //Parameterized
        public Adult(Screening s, bool po) : base(s)
        {
            PopcornOffer = po;
        }

        //METHODS
        public override double CalculatePrice()
        {
            if (base.screening.ScreeningType == "2B")
            {
                DateTime dt = new DateTime();
                if (dt.DayOfWeek == DayOfWeek.Friday || dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    return 14.00;
                }

                else
                {
                    return 11.00;
                }
            }

            else
            {
                DateTime dt = new DateTime();
                if (dt.DayOfWeek == DayOfWeek.Friday || dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    return 12.50;
                }

                else
                {
                    return 8.50;
                }
            }
        }

        //TOSTRING
        public override string ToString()
        {
            return (base.ToString());
        }
    }
}
