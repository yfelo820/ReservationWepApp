using ReservationWepApp.BackStaff.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.BackStaff.Interfaces
{
    public interface IMasterService
    {
        Task<List<Reservation>> GetReservations();
        Task<Contact> AddContact(Contact contact);
        Task<List<Contact>> GetAllContacts();
        Task<Reservation> AddReservation(Reservation reservation);
        Task<int> GetContactId(string name);
    }
}
