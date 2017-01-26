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
    class Student : Ticket
    {
        //ATTRIBUTES
        public string LevelOfStudy { get; set; }

        //CONSTRUCTORS
        //Default
        public Student() { }

        //Parameterized
        public Student(Screening s, string los) : base(s)
        {
            LevelOfStudy = los;
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
                    return 8.00;
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
                    return 7.00;
                }
            }
        }

        //TOSTRING
        public override string ToString()
        {
            return (base.ToString() + "LevelOfStudy: " + LevelOfStudy);
        }
    }
}
