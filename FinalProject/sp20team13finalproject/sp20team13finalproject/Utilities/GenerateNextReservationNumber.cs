using sp20team13finalproject.DAL;
using System;
using System.Linq;


namespace sp20team13finalproject.Utilities
{
    public static class GenerateNextReservationNumber
    {
        // Function Used To Generate The Next Reservation Number
        public static Int32 GetNextReservationNumber(AppDbContext _context)
        {
            Int32 intMaxReservationNumber; //the current maximum reservation number
            Int32 intNextReservationNumber; //the reservation number for the next order

            if (_context.Reservations.Count() == 0) //there are no numbers in the database yet
            {
                intMaxReservationNumber = 9999; //reservation numbers start at 10000 and go up by 1
            }
            else
            {
                intMaxReservationNumber = _context.Reservations.Max(r => r.ReservationNum); //this is the highest number in the database right now
            }

            //add one to the current max to find the next one
            intNextReservationNumber = intMaxReservationNumber + 1;

            //return the value
            return intNextReservationNumber;
        }

    }
}