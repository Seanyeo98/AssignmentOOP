using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class CinemaHall
    {
        //ATTRIBUTES
        public string Name { get; set; }
        public int HallNo { get; set; }
        public int Capcity { get; set; }

        //CONSTRUCTORS
        //Default
        public CinemaHall() { }

        //Parameterized
        public CinemaHall(string n, int hn, int c)
        {
            Name = n;
            HallNo = hn;
            Capcity = c;
        }

        //TOSTRING
        public override string ToString()
        {
            return ("Name: " + Name + "HallNo: " + HallNo + "Capcity: " + Capcity);
        }
    }
}
