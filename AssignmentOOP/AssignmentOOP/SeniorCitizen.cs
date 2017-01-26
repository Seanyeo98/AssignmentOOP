using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class SeniorCitizen : Ticket
    {
        //ATTRIBUTES
        public int YearOfBirth { get; set; }

        //CONSTRUCTORS
        //Default
        public SeniorCitizen() { }

        //Parameterized
        public SeniorCitizen(Screening s, int yob) : base(s)
        {
            YearOfBirth = yob;
        }

        //METHODS
        public override double CalculatePrice()
        {
            if (base.screening.ScreeningType == "3D")
            {
                DateTime dt = new DateTime();
                if (dt.DayOfWeek == DayOfWeek.Friday || dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    return 14.00;
                }

                else
                {
                    return 6.00;
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
                    return 5.00;
                }
            }
        }

        //TOSTRING
        public override string ToString()
        {
            return (base.ToString() + "YearOfBirth: " + YearOfBirth);
        }
    }
}
