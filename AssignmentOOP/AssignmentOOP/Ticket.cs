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
    abstract class Ticket
    {
        //ATTRIBUTES
        public Screening screening { get; set; }

        //CONSTRUCTORS
        //Default
        public Ticket() { }

        //Parameterized
        public Ticket(Screening s)
        {
            screening = s;
        }

        //METHODS
        public abstract double CalculatePrice();

        //TOSTRING
        public override string ToString()
        {
            return ("Screening: " + screening);
        }
    }
}
