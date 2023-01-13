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
    abstract class Ticket
    {
        public Screening Screening { get; set; }
        public Ticket() { }
        public Ticket(Screening screening)
        {
            Screening = screening;
        }
        public abstract double CalculatePrice();
        public override string ToString()
        {
            return "Screening: " + Screening;
        }
    }
}
