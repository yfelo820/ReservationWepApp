using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.BackStaff.DB.Entities
{
    public class Reservation : Base
    {
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }

        public string Date { get; set; }
        public int Rank { get; set; }
        public string Place { get; set; }
    }
}
