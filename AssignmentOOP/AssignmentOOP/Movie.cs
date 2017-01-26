using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Movie
    {
        //ATTRIBUTES
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Classification { get; set; }
        public DateTime OpeningDate { get; set; }
        private List<Movie> genreList = new List<Movie>();

        //CONSTRUCTORS
        //Default
        public Movie() { }

        //Parameterized
        public Movie(string t, int d, string c, DateTime od, List<Movie> gl)
        {
            Title = t;
            Duration = d;
            Classification = c;
            OpeningDate = od;
            genreList = gl;
        }

        //METHODS
        public List<Movie> GetGenreList()
        {
            return genreList;
        }

        //TOSTRING
        public override string ToString()
        {
            return ("Title: " + Title + "Duration: " + Duration + "Classification: " + Classification + "Opening Date: " + OpeningDate);
        }
    }
}
