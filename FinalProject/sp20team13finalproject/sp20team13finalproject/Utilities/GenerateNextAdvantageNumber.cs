using sp20team13finalproject.DAL;
using System;
using System.Linq;


namespace sp20team13finalproject.Utilities
{
    public static class GenerateNextAdvantageNumber
    {
        // Function Used To Generate The Next Advantage Number (Called In SeedIdentity.cs)
        public static Int32 GetNextAdvantageNumber(AppDbContext _context)
        {
            Int32 intMaxAdvantageNumber; //the current maximum advantage number
            Int32 intNextAdvantageNumber; //the advantage number for the next order

            if (_context.Users.Count() == 0) //there are no numbers in the database yet
            {
                intMaxAdvantageNumber = 5000; //advantage numbers start at 5001 and go up by 1
            }
            else
            {
                intMaxAdvantageNumber = _context.Users.Max(o => o.AdvantageNum); //this is the highest number in the database right now
            }

            //add one to the current max to find the next one
            intNextAdvantageNumber = intMaxAdvantageNumber + 1;

            //return the value
            return intNextAdvantageNumber;
        }

    }
}