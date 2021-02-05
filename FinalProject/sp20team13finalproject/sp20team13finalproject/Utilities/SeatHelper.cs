using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Utilities
{

    // TODO: make lists with available seat count for search

    public enum FareType { First, Economy }
    public enum SeatType { Aisle, Window}
    public class Seat
    {
        public Int32 SeatID { get; set; }
        [Display(Name = "Seat")]
        public String Name { get; set; }
        [Display(Name = "Fare Type")]
        public FareType FareType { get; set; }
        [Display(Name = "Seat Type")]
        public SeatType SeatType { get; set; }

    }
    public static class FindAvailableSeats
    {
        public static List<Seat> GetAllSeats()
        {
            List<Seat> AllSeats = new List<Seat>();
            AllSeats.Add(new Seat { SeatID = 1, Name = "1A", FareType = FareType.First });
            AllSeats.Add(new Seat { SeatID = 2, Name = "1B", FareType = FareType.First });
            AllSeats.Add(new Seat { SeatID = 3, Name = "2A", FareType = FareType.First });
            AllSeats.Add(new Seat { SeatID = 4, Name = "2B", FareType = FareType.First });
            AllSeats.Add(new Seat { SeatID = 5, Name = "3A", FareType = FareType.Economy, SeatType = SeatType.Window });
            AllSeats.Add(new Seat { SeatID = 6, Name = "3B", FareType = FareType.Economy, SeatType = SeatType.Aisle });
            AllSeats.Add(new Seat { SeatID = 7, Name = "3C", FareType = FareType.Economy, SeatType = SeatType.Aisle });
            AllSeats.Add(new Seat { SeatID = 8, Name = "3D", FareType = FareType.Economy, SeatType = SeatType.Window });
            AllSeats.Add(new Seat { SeatID = 9, Name = "4A", FareType = FareType.Economy, SeatType = SeatType.Window });
            AllSeats.Add(new Seat { SeatID = 10, Name = "4B", FareType = FareType.Economy, SeatType = SeatType.Aisle });
            AllSeats.Add(new Seat { SeatID = 11, Name = "4C", FareType = FareType.Economy, SeatType = SeatType.Aisle });
            AllSeats.Add(new Seat { SeatID = 12, Name = "4D", FareType = FareType.Economy, SeatType = SeatType.Window });
            AllSeats.Add(new Seat { SeatID = 13, Name = "5A", FareType = FareType.Economy, SeatType = SeatType.Window });
            AllSeats.Add(new Seat { SeatID = 14, Name = "5B", FareType = FareType.Economy, SeatType = SeatType.Aisle });
            AllSeats.Add(new Seat { SeatID = 15, Name = "5C", FareType = FareType.Economy, SeatType = SeatType.Aisle });
            AllSeats.Add(new Seat { SeatID = 16, Name = "5D", FareType = FareType.Economy, SeatType = SeatType.Window });
            return AllSeats;
        }

        public static List<String> GetTakenSeats()
        {
            List<String> SeatsTaken = new List<String>();

            return SeatsTaken;
        }

        public static List<Seat> GetAvailableSeats(List<String> SeatsTaken)
        {
            List<Seat> AvailableSeats = new List<Seat>();
            List<Seat> AllSeats = GetAllSeats();
            foreach (Seat s in AllSeats)
            {
                if (SeatsTaken.Contains(s.Name) == false) //this seat is not in the list of taken seats
                {
                    AvailableSeats.Add(s);
                }
            }
            return AvailableSeats;
        }
    }
}