//============================================================
// Student Number : S10222628K, S10223160D
// Student Name : ONG SZE HWEE ALEC, WONG GUO FUNG
// Module Group : T11
//============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem_P11_Team_2
{
    class Student : Ticket
    {
        public string LevelOfStudy { get; set; }
        public Student(): base() { }
        public Student(Screening screening, string levelOfStudy) :base(screening)
        { 
            LevelOfStudy = levelOfStudy;
        }
        public override double CalculatePrice()
        {
            List<int> weekEnd = new List<int> { 0, 5, 6 };
            int day = (int)Screening.ScreeningDateTime.DayOfWeek;
            bool isWithin7Days = (Screening.ScreeningDateTime - Screening.Movie.OpeningDate).Days <= 7;
            if (Screening.ScreeningType == "2D")
            {
                if (weekEnd.Contains(day) || isWithin7Days)
                    return 12.50;
                else
                    return 7.00;
            }
            else //3D price for students 
            {
                if (weekEnd.Contains(day) || isWithin7Days)
                    return 14.00;
                else
                    return 8.00;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\tLevelOfStudy: " + LevelOfStudy;
        }
    }
}
