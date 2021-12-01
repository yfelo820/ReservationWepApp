using ReservationWepApp.BackStaff.DB.Entities;
using ReservationWepApp.BackStaff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.BackStaff.Services
{
    public class MasterService : IMasterService
    {
        private readonly IReservationRepository<Reservation> _reservations;
        private readonly IReservationRepository<Contact> _contacs;


        public MasterService(IReservationRepository<Reservation> reservations,
                             IReservationRepository<Contact> contacs)
        {
            _reservations = reservations;
            _contacs = contacs;
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            return await _contacs.Add(contact);
        }

        public async Task<Reservation> AddReservation(Reservation reservation)
        {
            return await _reservations.Add(reservation);
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            return await _contacs.GetAll(); 
        }

        public async Task<int> GetContactId(string name)
        {
            return (await _contacs.Find(b => b.Name == name)).Single().Id;
        }

        public async Task<List<Reservation>> GetReservations()
        {
            return await _reservations.GetAll();
        }
    }
}
