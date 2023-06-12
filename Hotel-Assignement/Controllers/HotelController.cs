using Hotel_Assignement.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_Assignement.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult HotelBookingDetails()
        {
            HotelBooking booking = new HotelBooking()
            {
                Id = 1,
                GuestName = "Raji",
                DateStart = DateTime.Today,
                DateEnd = DateTime.Today.AddDays(3)

            };

            return View(booking);
        }
    }
}

