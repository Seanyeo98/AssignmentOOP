using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Screening
    {
        //ATTRIBUTES
        public static int screeningCount = 1;
        public string ScreeningNo { get; set; }
        public DateTime ScreeningDateTime { get; set; }
        public string ScreeningType { get; set; }
        public int SeatsRemaining { get; set; }
        public CinemaHall cinemaHall { get; set; }
        public Movie movie { get; set; }

        //CONSTRUCTORS
        //Default
        public Screening() { }

        //Parameterized
        public Screening(DateTime sdt, string st, CinemaHall ch, Movie m)
        {
            ScreeningDateTime = sdt;
            ScreeningType = st;
            cinemaHall = ch;
            movie = m;
            ScreeningNo = Convert.ToString(screeningCount);
            screeningCount++;
        }

        //TOSTRING
        public override string ToString()
        {
            return ("ScreeningDateTime: " + ScreeningDateTime + "ScreeningType: " + ScreeningType + "SeatsRemaining: " + SeatsRemaining);
        }
    }

}
