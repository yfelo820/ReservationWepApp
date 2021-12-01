using Microsoft.EntityFrameworkCore;
using ReservationWepApp.BackStaff.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.BackStaff.DB
{
    public class ReservationContextDB : DbContext
    {
        public ReservationContextDB(DbContextOptions<ReservationContextDB> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
