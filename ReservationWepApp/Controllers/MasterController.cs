using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationWepApp.BackStaff.DB.Entities;
using ReservationWepApp.BackStaff.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationWepApp.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;

        public MasterController(IMasterService masterService) => _masterService = masterService;

        [HttpGet]
        public async Task<IActionResult> GetReservations()
        {
            return Ok(await _masterService.GetReservations());
        }
           
        [HttpGet("contacts")]
        public async Task<IActionResult> GetAllContacts()
        {
            return Ok(await _masterService.GetAllContacts());
        }

        [HttpPost("contact")]
        public async Task<IActionResult> AddContact([FromBody] Contact contact)
        {
            return Ok(await _masterService.AddContact(contact));
        }

        [HttpPost("reservation")]
        public async Task<IActionResult> AddReservation([FromBody] Reservation reservation)
        {
            return Ok(await _masterService.AddReservation(reservation));
        }

        [HttpGet("contactId")]
        public async Task<IActionResult> GetContactId([FromQuery] string name)
        {
            return Ok(await _masterService.GetContactId(name));
        }

    }
}
