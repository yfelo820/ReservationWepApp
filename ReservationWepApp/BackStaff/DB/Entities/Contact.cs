using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.BackStaff.DB.Entities
{
    public class Contact : Base
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string BirthDate { get; set; }
    }
}
