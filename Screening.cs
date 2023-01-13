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
    
    class Screening
    {
        public  int ScreeningNo { get; set; }
        public DateTime ScreeningDateTime { get; set; }
        public string ScreeningType { get; set; }
        public int SeatRemaining { get; set; }
        public Cinema Cinema { get; set; }
        public Movie Movie { get; set; }
        public Screening() { }
        public Screening(int screeningNo,DateTime screeningDateTime, string screeningType, int seatsRemaining,Cinema c, Movie m)
        {
            ScreeningNo = screeningNo;
            ScreeningDateTime = screeningDateTime;
            ScreeningType = screeningType;
            SeatRemaining = seatsRemaining;
            Cinema = c;
            Movie = m;
        }
        public override string ToString()
        {
            return "ScreeningNo: " + ScreeningNo + "\tScreeningDateTime: " + ScreeningDateTime + " \tScreeningType: " + ScreeningType
                + "\tSeatsRemaining: ";
        }
    }
}
