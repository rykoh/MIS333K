using System.Collections.Generic;
using System;
using System.Linq;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;
using static sp20team13finalproject.Models.FlightDetail;

namespace sp20team13finalproject.Seeding
{
	public static class SeedFlightDetails
	{
		public static void SeedAllFlightDetails(AppDbContext db)
		{
			if (db.FlightDetails.Count() == 957)
			{
				throw new NotSupportedException("The database already contains all flight details!");
			}

			Int32 intFlightDetailsAdded = 0;
			Int32 intFlightDetailNum = 999;
			
			List<FlightDetail> FlightDetails = new List<FlightDetail>();

			try
			{
				FlightDetail fd1 = new FlightDetail()
				{
					// FlightDetailID
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 15, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					// List of Crew Members
					// List of Tickets
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd1);

				FlightDetail fd2 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 16, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd2.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd2);

				FlightDetail fd3 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 17, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd3.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd3);

				FlightDetail fd6 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 20, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd6.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd6);

				FlightDetail fd7 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 21, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd7.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd7);

				FlightDetail fd8 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 22, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd8.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd8);

				FlightDetail fd9 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 23, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd9.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd9);

				FlightDetail fd10 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 24, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd10.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd10);

				FlightDetail fd13 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 27, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd13.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd13);

				FlightDetail fd14 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 28, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd14.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd14);

				FlightDetail fd15 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 29, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd15.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd15);

				FlightDetail fd16 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 4, 30, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd16.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd16);

				FlightDetail fd17 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 1, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd17.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd17);

				FlightDetail fd20 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 4, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd20.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd20);

				FlightDetail fd21 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 5, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd21.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd21);

				FlightDetail fd22 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 6, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd22.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd22);

				FlightDetail fd23 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 7, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd23.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd23);

				FlightDetail fd24 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 8, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd24.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd24);

				FlightDetail fd27 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 11, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd27.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd27);

				FlightDetail fd28 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 12, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd28.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd28);

				FlightDetail fd29 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 13, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd29.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd29);

				FlightDetail fd30 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 14, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd30.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd30);

				FlightDetail fd31 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 15, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd31.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd31);

				FlightDetail fd34 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 18, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd34.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd34);

				FlightDetail fd35 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 19, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd35.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd35);

				FlightDetail fd36 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 20, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd36.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd36);

				FlightDetail fd37 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 21, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd37.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd37);

				FlightDetail fd38 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 22, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd38.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd38);

				FlightDetail fd41 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 25, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd41.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd41);

				FlightDetail fd42 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 26, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd42.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd42);

				FlightDetail fd43 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 27, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd43.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd43);

				FlightDetail fd44 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 28, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd44.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd44);

				FlightDetail fd45 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 5, 29, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd45.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd45);

				FlightDetail fd48 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 1, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd48.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd48);

				FlightDetail fd49 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 2, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd49.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd49);

				FlightDetail fd50 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 3, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd50.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd50);

				FlightDetail fd51 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 4, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd51.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd51);

				FlightDetail fd52 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 5, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd52.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd52);

				FlightDetail fd55 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 8, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd55.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd55);

				FlightDetail fd56 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 9, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd56.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd56);

				FlightDetail fd57 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 10, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd57.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd57);

				FlightDetail fd58 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 11, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd58.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd58);

				FlightDetail fd59 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 12, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd59.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd59);

				FlightDetail fd62 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 15, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd62.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd62);

				FlightDetail fd63 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 16, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd63.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd63);

				FlightDetail fd64 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 17, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd64.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd64);

				FlightDetail fd65 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 18, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd65.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd65);

				FlightDetail fd66 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 19, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd66.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd66);

				FlightDetail fd69 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 22, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd69.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd69);

				FlightDetail fd70 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 23, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd70.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd70);

				FlightDetail fd71 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 24, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd71.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd71);

				FlightDetail fd72 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 25, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd72.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd72);

				FlightDetail fd73 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 26, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd73.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd73);

				FlightDetail fd76 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 29, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd76.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd76);

				FlightDetail fd77 = new FlightDetail()
				{
					FlightNum = 1000,
					Date = new DateTime(2020, 6, 30, 8, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd77.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1000);
				FlightDetails.Add(fd77);

				FlightDetail fd78 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 15, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd78.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd78);

				FlightDetail fd79 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 16, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd79.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd79);

				FlightDetail fd80 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 17, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd80.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd80);

				FlightDetail fd83 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 20, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd83.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd83);

				FlightDetail fd84 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 21, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd84.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd84);

				FlightDetail fd85 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 22, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd85.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd85);

				FlightDetail fd86 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 23, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd86.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd86);

				FlightDetail fd87 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 24, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd87.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd87);

				FlightDetail fd90 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 27, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd90.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd90);

				FlightDetail fd91 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 28, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd91.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd91);

				FlightDetail fd92 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 29, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd92.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd92);

				FlightDetail fd93 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 4, 30, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd93.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd93);

				FlightDetail fd94 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 1, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd94.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd94);

				FlightDetail fd97 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 4, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd97.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd97);

				FlightDetail fd98 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 5, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd98.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd98);

				FlightDetail fd99 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 6, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd99.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd99);

				FlightDetail fd100 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 7, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd100.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd100);

				FlightDetail fd101 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 8, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd101.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd101);

				FlightDetail fd104 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 11, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd104.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd104);

				FlightDetail fd105 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 12, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd105.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd105);

				FlightDetail fd106 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 13, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd106.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd106);

				FlightDetail fd107 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 14, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd107.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd107);

				FlightDetail fd108 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 15, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd108.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd108);

				FlightDetail fd111 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 18, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd111.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd111);

				FlightDetail fd112 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 19, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd112.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd112);

				FlightDetail fd113 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 20, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd113.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd113);

				FlightDetail fd114 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 21, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd114.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd114);

				FlightDetail fd115 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 22, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd115.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd115);

				FlightDetail fd118 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 25, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd118.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd118);

				FlightDetail fd119 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 26, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd119.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd119);

				FlightDetail fd120 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 27, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd120.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd120);

				FlightDetail fd121 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 28, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd121.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd121);

				FlightDetail fd122 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 5, 29, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd122.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd122);

				FlightDetail fd125 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 1, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd125.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd125);

				FlightDetail fd126 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 2, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd126.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd126);

				FlightDetail fd127 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 3, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd127.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd127);

				FlightDetail fd128 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 4, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd128.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd128);

				FlightDetail fd129 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 5, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd129.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd129);

				FlightDetail fd132 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 8, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd132.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd132);

				FlightDetail fd133 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 9, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd133.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd133);

				FlightDetail fd134 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 10, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd134.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd134);

				FlightDetail fd135 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 11, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd135.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd135);

				FlightDetail fd136 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 12, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd136.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd136);

				FlightDetail fd139 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 15, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd139.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd139);

				FlightDetail fd140 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 16, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd140.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd140);

				FlightDetail fd141 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 17, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd141.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd141);

				FlightDetail fd142 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 18, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd142.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd142);

				FlightDetail fd143 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 19, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd143.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd143);

				FlightDetail fd146 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 22, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd146.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd146);

				FlightDetail fd147 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 23, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd147.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd147);

				FlightDetail fd148 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 24, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd148.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd148);

				FlightDetail fd149 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 25, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd149.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd149);

				FlightDetail fd150 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 26, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd150.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd150);

				FlightDetail fd153 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 29, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd153.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd153);

				FlightDetail fd154 = new FlightDetail()
				{
					FlightNum = 1001,
					Date = new DateTime(2020, 6, 30, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd154.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1001);
				FlightDetails.Add(fd154);

				FlightDetail fd155 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 15, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd155.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd155);

				FlightDetail fd156 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 16, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd156.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd156);

				FlightDetail fd157 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 17, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd157.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd157);

				FlightDetail fd158 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 18, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd158.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd158);

				FlightDetail fd159 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 19, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd159.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd159);

				FlightDetail fd160 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 20, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd160.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd160);

				FlightDetail fd161 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 21, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd161.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd161);

				FlightDetail fd162 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 22, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd162.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd162);

				FlightDetail fd163 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 23, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd163.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd163);

				FlightDetail fd164 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 24, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd164.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd164);

				FlightDetail fd165 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 25, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd165.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd165);

				FlightDetail fd166 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 26, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd166.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd166);

				FlightDetail fd167 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 27, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd167.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd167);

				FlightDetail fd168 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 28, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd168.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd168);

				FlightDetail fd169 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 29, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd169.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd169);

				FlightDetail fd170 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 4, 30, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd170.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd170);

				FlightDetail fd171 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 1, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd171.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd171);

				FlightDetail fd172 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 2, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd172.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd172);

				FlightDetail fd173 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 3, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd173.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd173);

				FlightDetail fd174 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 4, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd174.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd174);

				FlightDetail fd175 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 5, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd175.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd175);

				FlightDetail fd176 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 6, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd176.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd176);

				FlightDetail fd177 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 7, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd177.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd177);

				FlightDetail fd178 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 8, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd178.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd178);

				FlightDetail fd179 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 9, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd179.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd179);

				FlightDetail fd180 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 10, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd180.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd180);

				FlightDetail fd181 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 11, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd181.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd181);

				FlightDetail fd182 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 12, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd182.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd182);

				FlightDetail fd183 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 13, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd183.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd183);

				FlightDetail fd184 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 14, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd184.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd184);

				FlightDetail fd185 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 15, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd185.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd185);

				FlightDetail fd186 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 16, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd186.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd186);

				FlightDetail fd187 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 17, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd187.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd187);

				FlightDetail fd188 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 18, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd188.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd188);

				FlightDetail fd189 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 19, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd189.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd189);

				FlightDetail fd190 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 20, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd190.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd190);

				FlightDetail fd191 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 21, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd191.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd191);

				FlightDetail fd192 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 22, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd192.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd192);

				FlightDetail fd193 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 23, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd193.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd193);

				FlightDetail fd194 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 24, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd194.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd194);

				FlightDetail fd195 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 25, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd195.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd195);

				FlightDetail fd196 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 26, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd196.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd196);

				FlightDetail fd197 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 27, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd197.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd197);

				FlightDetail fd198 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 28, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd198.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd198);

				FlightDetail fd199 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 29, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd199.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd199);

				FlightDetail fd200 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 30, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd200.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd200);

				FlightDetail fd201 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 5, 31, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd201.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd201);

				FlightDetail fd202 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 1, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd202.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd202);

				FlightDetail fd203 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 2, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd203.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd203);

				FlightDetail fd204 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 3, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd204.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd204);

				FlightDetail fd205 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 4, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd205.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd205);

				FlightDetail fd206 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 5, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd206.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd206);

				FlightDetail fd207 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 6, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd207.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd207);

				FlightDetail fd208 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 7, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd208.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd208);

				FlightDetail fd209 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 8, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd209.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd209);

				FlightDetail fd210 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 9, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd210.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd210);

				FlightDetail fd211 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 10, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd211.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd211);

				FlightDetail fd212 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 11, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd212.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd212);

				FlightDetail fd213 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 12, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd213.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd213);

				FlightDetail fd214 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 13, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd214.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd214);

				FlightDetail fd215 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 14, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd215.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd215);

				FlightDetail fd216 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 15, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd216.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd216);

				FlightDetail fd217 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 16, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd217.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd217);

				FlightDetail fd218 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 17, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd218.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd218);

				FlightDetail fd219 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 18, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd219.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd219);

				FlightDetail fd220 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 19, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd220.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd220);

				FlightDetail fd221 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 20, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd221.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd221);

				FlightDetail fd222 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 21, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd222.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd222);

				FlightDetail fd223 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 22, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd223.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd223);

				FlightDetail fd224 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 23, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd224.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd224);

				FlightDetail fd225 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 24, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd225.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd225);

				FlightDetail fd226 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 25, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd226.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd226);

				FlightDetail fd227 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 26, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd227.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd227);

				FlightDetail fd228 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 27, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd228.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd228);

				FlightDetail fd229 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 28, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd229.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd229);

				FlightDetail fd230 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 29, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd230.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd230);

				FlightDetail fd231 = new FlightDetail()
				{
					FlightNum = 1002,
					Date = new DateTime(2020, 6, 30, 11, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd231.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1002);
				FlightDetails.Add(fd231);

				FlightDetail fd232 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 15, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd232.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd232);

				FlightDetail fd233 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 16, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd233.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd233);

				FlightDetail fd234 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 17, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd234.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd234);

				FlightDetail fd235 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 18, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd235.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd235);

				FlightDetail fd236 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 19, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd236.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd236);

				FlightDetail fd237 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 20, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd237.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd237);

				FlightDetail fd238 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 21, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd238.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd238);

				FlightDetail fd239 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 22, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd239.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd239);

				FlightDetail fd240 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 23, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd240.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd240);

				FlightDetail fd241 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 24, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd241.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd241);

				FlightDetail fd242 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 25, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd242.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd242);

				FlightDetail fd243 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 26, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd243.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd243);

				FlightDetail fd244 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 27, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd244.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd244);

				FlightDetail fd245 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 28, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd245.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd245);

				FlightDetail fd246 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 29, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd246.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd246);

				FlightDetail fd247 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 4, 30, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd247.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd247);

				FlightDetail fd248 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 1, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd248.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd248);

				FlightDetail fd249 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 2, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd249.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd249);

				FlightDetail fd250 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 3, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd250.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd250);

				FlightDetail fd251 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 4, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd251.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd251);

				FlightDetail fd252 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 5, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd252.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd252);

				FlightDetail fd253 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 6, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd253.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd253);

				FlightDetail fd254 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 7, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd254.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd254);

				FlightDetail fd255 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 8, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd255.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd255);

				FlightDetail fd256 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 9, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd256.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd256);

				FlightDetail fd257 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 10, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd257.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd257);

				FlightDetail fd258 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 11, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd258.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd258);

				FlightDetail fd259 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 12, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd259.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd259);

				FlightDetail fd260 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 13, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd260.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd260);

				FlightDetail fd261 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 14, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd261.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd261);

				FlightDetail fd262 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 15, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd262.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd262);

				FlightDetail fd263 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 16, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd263.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd263);

				FlightDetail fd264 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 17, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd264.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd264);

				FlightDetail fd265 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 18, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd265.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd265);

				FlightDetail fd266 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 19, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd266.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd266);

				FlightDetail fd267 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 20, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd267.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd267);

				FlightDetail fd268 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 21, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd268.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd268);

				FlightDetail fd269 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 22, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd269.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd269);

				FlightDetail fd270 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 23, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd270.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd270);

				FlightDetail fd271 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 24, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd271.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd271);

				FlightDetail fd272 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 25, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd272.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd272);

				FlightDetail fd273 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 26, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd273.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd273);

				FlightDetail fd274 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 27, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd274.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd274);

				FlightDetail fd275 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 28, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd275.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd275);

				FlightDetail fd276 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 29, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd276.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd276);

				FlightDetail fd277 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 30, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd277.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd277);

				FlightDetail fd278 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 5, 31, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd278.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd278);

				FlightDetail fd279 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 1, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd279.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd279);

				FlightDetail fd280 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 2, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd280.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd280);

				FlightDetail fd281 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 3, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd281.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd281);

				FlightDetail fd282 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 4, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd282.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd282);

				FlightDetail fd283 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 5, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd283.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd283);

				FlightDetail fd284 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 6, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd284.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd284);

				FlightDetail fd285 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 7, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd285.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd285);

				FlightDetail fd286 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 8, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd286.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd286);

				FlightDetail fd287 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 9, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd287.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd287);

				FlightDetail fd288 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 10, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd288.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd288);

				FlightDetail fd289 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 11, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd289.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd289);

				FlightDetail fd290 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 12, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd290.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd290);

				FlightDetail fd291 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 13, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd291.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd291);

				FlightDetail fd292 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 14, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd292.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd292);

				FlightDetail fd293 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 15, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd293.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd293);

				FlightDetail fd294 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 16, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd294.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd294);

				FlightDetail fd295 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 17, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd295.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd295);

				FlightDetail fd296 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 18, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd296.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd296);

				FlightDetail fd297 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 19, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd297.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd297);

				FlightDetail fd298 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 20, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd298.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd298);

				FlightDetail fd299 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 21, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd299.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd299);

				FlightDetail fd300 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 22, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd300.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd300);

				FlightDetail fd301 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 23, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd301.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd301);

				FlightDetail fd302 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 24, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd302.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd302);

				FlightDetail fd303 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 25, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd303.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd303);

				FlightDetail fd304 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 26, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd304.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd304);

				FlightDetail fd305 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 27, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd305.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd305);

				FlightDetail fd306 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 28, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd306.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd306);

				FlightDetail fd307 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 29, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd307.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd307);

				FlightDetail fd308 = new FlightDetail()
				{
					FlightNum = 1003,
					Date = new DateTime(2020, 6, 30, 12, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 130,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd308.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1003);
				FlightDetails.Add(fd308);

				FlightDetail fd386 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 15, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd386.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd386);

				FlightDetail fd387 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 16, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd387.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd387);

				FlightDetail fd388 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 17, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd388.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd388);

				FlightDetail fd389 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 18, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd389.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd389);

				FlightDetail fd390 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 19, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd390.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd390);

				FlightDetail fd391 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 20, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd391.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd391);

				FlightDetail fd392 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 21, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd392.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd392);

				FlightDetail fd393 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 22, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd393.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd393);

				FlightDetail fd394 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 23, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd394.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd394);

				FlightDetail fd395 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 24, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd395.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd395);

				FlightDetail fd396 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 25, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd396.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd396);

				FlightDetail fd397 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 26, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd397.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd397);

				FlightDetail fd398 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 27, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd398.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd398);

				FlightDetail fd399 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 28, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd399.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd399);

				FlightDetail fd400 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 29, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd400.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd400);

				FlightDetail fd401 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 4, 30, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd401.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd401);

				FlightDetail fd402 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 1, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd402.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd402);

				FlightDetail fd403 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 2, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd403.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd403);

				FlightDetail fd404 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 3, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd404.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd404);

				FlightDetail fd405 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 4, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd405.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd405);

				FlightDetail fd406 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 5, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd406.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd406);

				FlightDetail fd407 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 6, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd407.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd407);

				FlightDetail fd408 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 7, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd408.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd408);

				FlightDetail fd409 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 8, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd409.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd409);

				FlightDetail fd410 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 9, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd410.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd410);

				FlightDetail fd411 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 10, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd411.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd411);

				FlightDetail fd412 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 11, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd412.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd412);

				FlightDetail fd413 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 12, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd413.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd413);

				FlightDetail fd414 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 13, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd414.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd414);

				FlightDetail fd415 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 14, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd415.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd415);

				FlightDetail fd416 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 15, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd416.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd416);

				FlightDetail fd417 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 16, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd417.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd417);

				FlightDetail fd418 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 17, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd418.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd418);

				FlightDetail fd419 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 18, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd419.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd419);

				FlightDetail fd420 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 19, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd420.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd420);

				FlightDetail fd421 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 20, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd421.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd421);

				FlightDetail fd422 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 21, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd422.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd422);

				FlightDetail fd423 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 22, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd423.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd423);

				FlightDetail fd424 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 23, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd424.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd424);

				FlightDetail fd425 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 24, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd425.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd425);

				FlightDetail fd426 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 25, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd426.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd426);

				FlightDetail fd427 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 26, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd427.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd427);

				FlightDetail fd428 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 27, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd428.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd428);

				FlightDetail fd429 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 28, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd429.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd429);

				FlightDetail fd430 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 29, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd430.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd430);

				FlightDetail fd431 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 30, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd431.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd431);

				FlightDetail fd432 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 5, 31, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd432.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd432);

				FlightDetail fd433 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 1, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd433.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd433);

				FlightDetail fd434 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 2, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd434.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd434);

				FlightDetail fd435 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 3, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd435.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd435);

				FlightDetail fd436 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 4, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd436.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd436);

				FlightDetail fd437 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 5, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd437.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd437);

				FlightDetail fd438 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 6, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd438.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd438);

				FlightDetail fd439 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 7, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd439.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd439);

				FlightDetail fd440 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 8, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd440.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd440);

				FlightDetail fd441 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 9, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd441.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd441);

				FlightDetail fd442 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 10, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd442.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd442);

				FlightDetail fd443 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 11, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd443.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd443);

				FlightDetail fd444 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 12, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd444.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd444);

				FlightDetail fd445 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 13, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd445.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd445);

				FlightDetail fd446 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 14, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd446.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd446);

				FlightDetail fd447 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 15, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd447.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd447);

				FlightDetail fd448 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 16, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd448.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd448);

				FlightDetail fd449 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 17, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd449.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd449);

				FlightDetail fd450 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 18, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd450.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd450);

				FlightDetail fd451 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 19, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd451.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd451);

				FlightDetail fd452 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 20, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd452.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd452);

				FlightDetail fd453 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 21, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd453.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd453);

				FlightDetail fd454 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 22, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd454.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd454);

				FlightDetail fd455 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 23, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd455.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd455);

				FlightDetail fd456 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 24, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd456.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd456);

				FlightDetail fd457 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 25, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd457.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd457);

				FlightDetail fd458 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 26, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd458.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd458);

				FlightDetail fd459 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 27, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd459.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd459);

				FlightDetail fd460 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 28, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd460.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd460);

				FlightDetail fd461 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 29, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd461.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd461);

				FlightDetail fd462 = new FlightDetail()
				{
					FlightNum = 1004,
					Date = new DateTime(2020, 6, 30, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd462.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1004);
				FlightDetails.Add(fd462);

				FlightDetail fd1153 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 15, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1153.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1153);

				FlightDetail fd1154 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 16, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1154.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1154);

				FlightDetail fd1155 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 17, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1155.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1155);

				FlightDetail fd1156 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 18, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1156.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1156);

				FlightDetail fd1157 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 19, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1157.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1157);

				FlightDetail fd1158 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 20, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1158.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1158);

				FlightDetail fd1159 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 21, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1159.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1159);

				FlightDetail fd1160 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 22, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1160.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1160);

				FlightDetail fd1161 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 23, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1161.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1161);

				FlightDetail fd1162 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 24, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1162.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1162);

				FlightDetail fd1163 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 25, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1163.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1163);

				FlightDetail fd1164 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 26, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1164.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1164);

				FlightDetail fd1165 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 27, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1165.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1165);

				FlightDetail fd1166 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 28, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1166.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1166);

				FlightDetail fd1167 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 29, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1167.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1167);

				FlightDetail fd1168 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 4, 30, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1168.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1168);

				FlightDetail fd1169 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 1, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1169.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1169);

				FlightDetail fd1170 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 2, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1170.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1170);

				FlightDetail fd1171 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 3, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1171.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1171);

				FlightDetail fd1172 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 4, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1172.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1172);

				FlightDetail fd1173 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 5, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1173.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1173);

				FlightDetail fd1174 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 6, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1174.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1174);

				FlightDetail fd1175 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 7, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1175.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1175);

				FlightDetail fd1176 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 8, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1176.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1176);

				FlightDetail fd1177 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 9, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1177.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1177);

				FlightDetail fd1178 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 10, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1178.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1178);

				FlightDetail fd1179 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 11, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1179.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1179);

				FlightDetail fd1180 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 12, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1180.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1180);

				FlightDetail fd1181 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 13, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1181.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1181);

				FlightDetail fd1182 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 14, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1182.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1182);

				FlightDetail fd1183 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 15, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1183.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1183);

				FlightDetail fd1184 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 16, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1184.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1184);

				FlightDetail fd1185 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 17, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1185.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1185);

				FlightDetail fd1186 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 18, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1186.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1186);

				FlightDetail fd1187 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 19, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1187.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1187);

				FlightDetail fd1188 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 20, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1188.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1188);

				FlightDetail fd1189 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 21, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1189.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1189);

				FlightDetail fd1190 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 22, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1190.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1190);

				FlightDetail fd1191 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 23, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1191.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1191);

				FlightDetail fd1192 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 24, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1192.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1192);

				FlightDetail fd1193 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 25, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1193.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1193);

				FlightDetail fd1194 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 26, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1194.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1194);

				FlightDetail fd1195 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 27, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1195.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1195);

				FlightDetail fd1196 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 28, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1196.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1196);

				FlightDetail fd1197 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 29, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1197.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1197);

				FlightDetail fd1198 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 30, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1198.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1198);

				FlightDetail fd1199 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 5, 31, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1199.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1199);

				FlightDetail fd1200 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 1, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1200.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1200);

				FlightDetail fd1201 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 2, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1201.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1201);

				FlightDetail fd1202 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 3, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1202.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1202);

				FlightDetail fd1203 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 4, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1203.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1203);

				FlightDetail fd1204 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 5, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1204.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1204);

				FlightDetail fd1205 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 6, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1205.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1205);

				FlightDetail fd1206 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 7, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1206.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1206);

				FlightDetail fd1207 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 8, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1207.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1207);

				FlightDetail fd1208 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 9, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1208.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1208);

				FlightDetail fd1209 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 10, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1209.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1209);

				FlightDetail fd1210 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 11, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1210.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1210);

				FlightDetail fd1211 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 12, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1211.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1211);

				FlightDetail fd1212 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 13, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1212.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1212);

				FlightDetail fd1213 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 14, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1213.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1213);

				FlightDetail fd1214 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 15, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1214.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1214);

				FlightDetail fd1215 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 16, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1215.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1215);

				FlightDetail fd1216 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 17, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1216.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1216);

				FlightDetail fd1217 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 18, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1217.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1217);

				FlightDetail fd1218 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 19, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1218.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1218);

				FlightDetail fd1219 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 20, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1219.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1219);

				FlightDetail fd1220 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 21, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1220.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1220);

				FlightDetail fd1221 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 22, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1221.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1221);

				FlightDetail fd1222 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 23, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1222.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1222);

				FlightDetail fd1223 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 24, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1223.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1223);

				FlightDetail fd1224 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 25, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1224.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1224);

				FlightDetail fd1225 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 26, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1225.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1225);

				FlightDetail fd1226 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 27, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1226.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1226);

				FlightDetail fd1227 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 28, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1227.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1227);

				FlightDetail fd1228 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 29, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1228.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1228);

				FlightDetail fd1229 = new FlightDetail()
				{
					FlightNum = 1005,
					Date = new DateTime(2020, 6, 30, 15, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 140,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1229.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1005);
				FlightDetails.Add(fd1229);

				FlightDetail fd463 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 15, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd463.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd463);

				FlightDetail fd464 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 16, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd464.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd464);

				FlightDetail fd465 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 17, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd465.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd465);

				FlightDetail fd468 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 20, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd468.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd468);

				FlightDetail fd469 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 21, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd469.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd469);

				FlightDetail fd470 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 22, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd470.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd470);

				FlightDetail fd471 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 23, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd471.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd471);

				FlightDetail fd472 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 24, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd472.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd472);

				FlightDetail fd475 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 27, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd475.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd475);

				FlightDetail fd476 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 28, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd476.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd476);

				FlightDetail fd477 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 29, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd477.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd477);

				FlightDetail fd478 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 4, 30, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd478.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd478);

				FlightDetail fd479 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 1, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd479.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd479);

				FlightDetail fd482 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 4, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd482.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd482);

				FlightDetail fd483 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 5, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd483.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd483);

				FlightDetail fd484 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 6, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd484.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd484);

				FlightDetail fd485 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 7, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd485.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd485);

				FlightDetail fd486 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 8, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd486.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd486);

				FlightDetail fd489 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 11, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd489.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd489);

				FlightDetail fd490 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 12, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd490.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd490);

				FlightDetail fd491 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 13, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd491.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd491);

				FlightDetail fd492 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 14, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd492.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd492);

				FlightDetail fd493 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 15, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd493.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd493);

				FlightDetail fd496 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 18, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd496.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd496);

				FlightDetail fd497 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 19, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd497.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd497);

				FlightDetail fd498 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 20, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd498.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd498);

				FlightDetail fd499 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 21, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd499.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd499);

				FlightDetail fd500 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 22, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd500.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd500);

				FlightDetail fd503 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 25, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd503.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd503);

				FlightDetail fd504 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 26, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd504.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd504);

				FlightDetail fd505 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 27, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd505.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd505);

				FlightDetail fd506 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 28, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd506.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd506);

				FlightDetail fd507 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 5, 29, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd507.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd507);

				FlightDetail fd510 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 1, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd510.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd510);

				FlightDetail fd511 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 2, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd511.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd511);

				FlightDetail fd512 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 3, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd512.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd512);

				FlightDetail fd513 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 4, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd513.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd513);

				FlightDetail fd514 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 5, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd514.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd514);

				FlightDetail fd517 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 8, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd517.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd517);

				FlightDetail fd518 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 9, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd518.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd518);

				FlightDetail fd519 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 10, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd519.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd519);

				FlightDetail fd520 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 11, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd520.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd520);

				FlightDetail fd521 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 12, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd521.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd521);

				FlightDetail fd524 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 15, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd524.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd524);

				FlightDetail fd525 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 16, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd525.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd525);

				FlightDetail fd526 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 17, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd526.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd526);

				FlightDetail fd527 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 18, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd527.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd527);

				FlightDetail fd528 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 19, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd528.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd528);

				FlightDetail fd531 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 22, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd531.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd531);

				FlightDetail fd532 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 23, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd532.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd532);

				FlightDetail fd533 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 24, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd533.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd533);

				FlightDetail fd534 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 25, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd534.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd534);

				FlightDetail fd535 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 26, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd535.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd535);

				FlightDetail fd538 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 29, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd538.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd538);

				FlightDetail fd539 = new FlightDetail()
				{
					FlightNum = 1006,
					Date = new DateTime(2020, 6, 30, 9, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 98,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd539.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1006);
				FlightDetails.Add(fd539);

				FlightDetail fd540 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 15, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd540.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd540);

				FlightDetail fd541 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 16, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd541.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd541);

				FlightDetail fd542 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 17, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd542.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd542);

				FlightDetail fd545 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 20, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd545.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd545);

				FlightDetail fd546 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 21, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd546.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd546);

				FlightDetail fd547 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 22, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd547.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd547);

				FlightDetail fd548 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 23, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd548.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd548);

				FlightDetail fd549 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 24, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd549.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd549);

				FlightDetail fd552 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 27, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd552.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd552);

				FlightDetail fd553 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 28, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd553.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd553);

				FlightDetail fd554 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 29, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd554.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd554);

				FlightDetail fd555 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 4, 30, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd555.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd555);

				FlightDetail fd556 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 1, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd556.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd556);

				FlightDetail fd559 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 4, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd559.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd559);

				FlightDetail fd560 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 5, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd560.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd560);

				FlightDetail fd561 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 6, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd561.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd561);

				FlightDetail fd562 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 7, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd562.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd562);

				FlightDetail fd563 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 8, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd563.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd563);

				FlightDetail fd566 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 11, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd566.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd566);

				FlightDetail fd567 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 12, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd567.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd567);

				FlightDetail fd568 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 13, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd568.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd568);

				FlightDetail fd569 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 14, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd569.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd569);

				FlightDetail fd570 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 15, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd570.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd570);

				FlightDetail fd573 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 18, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd573.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd573);

				FlightDetail fd574 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 19, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd574.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd574);

				FlightDetail fd575 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 20, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd575.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd575);

				FlightDetail fd576 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 21, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd576.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd576);

				FlightDetail fd577 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 22, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd577.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd577);

				FlightDetail fd580 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 25, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd580.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd580);

				FlightDetail fd581 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 26, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd581.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd581);

				FlightDetail fd582 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 27, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd582.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd582);

				FlightDetail fd583 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 28, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd583.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd583);

				FlightDetail fd584 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 5, 29, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd584.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd584);

				FlightDetail fd587 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 1, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd587.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd587);

				FlightDetail fd588 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 2, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd588.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd588);

				FlightDetail fd589 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 3, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd589.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd589);

				FlightDetail fd590 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 4, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd590.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd590);

				FlightDetail fd591 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 5, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd591.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd591);

				FlightDetail fd594 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 8, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd594.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd594);

				FlightDetail fd595 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 9, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd595.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd595);

				FlightDetail fd596 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 10, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd596.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd596);

				FlightDetail fd597 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 11, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd597.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd597);

				FlightDetail fd598 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 12, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd598.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd598);

				FlightDetail fd601 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 15, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd601.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd601);

				FlightDetail fd602 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 16, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd602.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd602);

				FlightDetail fd603 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 17, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd603.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd603);

				FlightDetail fd604 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 18, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd604.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd604);

				FlightDetail fd605 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 19, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd605.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd605);

				FlightDetail fd608 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 22, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd608.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd608);

				FlightDetail fd609 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 23, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd609.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd609);

				FlightDetail fd610 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 24, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd610.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd610);

				FlightDetail fd611 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 25, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd611.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd611);

				FlightDetail fd612 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 26, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd612.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd612);

				FlightDetail fd615 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 29, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd615.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd615);

				FlightDetail fd616 = new FlightDetail()
				{
					FlightNum = 1007,
					Date = new DateTime(2020, 6, 30, 10, 15, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 100,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd616.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1007);
				FlightDetails.Add(fd616);

				FlightDetail fd617 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 15, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd617.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd617);

				FlightDetail fd618 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 16, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd618.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd618);

				FlightDetail fd619 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 17, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd619.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd619);

				FlightDetail fd620 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 18, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd620.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd620);

				FlightDetail fd621 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 19, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd621.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd621);

				FlightDetail fd622 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 20, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd622.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd622);

				FlightDetail fd623 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 21, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd623.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd623);

				FlightDetail fd624 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 22, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd624.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd624);

				FlightDetail fd625 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 23, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd625.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd625);

				FlightDetail fd626 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 24, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd626.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd626);

				FlightDetail fd627 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 25, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd627.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd627);

				FlightDetail fd628 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 26, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd628.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd628);

				FlightDetail fd629 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 27, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd629.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd629);

				FlightDetail fd630 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 28, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd630.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd630);

				FlightDetail fd631 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 29, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd631.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd631);

				FlightDetail fd632 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 4, 30, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd632.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd632);

				FlightDetail fd633 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 1, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd633.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd633);

				FlightDetail fd634 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 2, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd634.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd634);

				FlightDetail fd635 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 3, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd635.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd635);

				FlightDetail fd636 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 4, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd636.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd636);

				FlightDetail fd637 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 5, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd637.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd637);

				FlightDetail fd638 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 6, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd638.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd638);

				FlightDetail fd639 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 7, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd639.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd639);

				FlightDetail fd640 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 8, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd640.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd640);

				FlightDetail fd641 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 9, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd641.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd641);

				FlightDetail fd642 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 10, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd642.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd642);

				FlightDetail fd643 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 11, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd643.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd643);

				FlightDetail fd644 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 12, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd644.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd644);

				FlightDetail fd645 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 13, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd645.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd645);

				FlightDetail fd646 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 14, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd646.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd646);

				FlightDetail fd647 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 15, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd647.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd647);

				FlightDetail fd648 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 16, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd648.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd648);

				FlightDetail fd649 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 17, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd649.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd649);

				FlightDetail fd650 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 18, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd650.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd650);

				FlightDetail fd651 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 19, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd651.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd651);

				FlightDetail fd652 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 20, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd652.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd652);

				FlightDetail fd653 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 21, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd653.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd653);

				FlightDetail fd654 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 22, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd654.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd654);

				FlightDetail fd655 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 23, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd655.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd655);

				FlightDetail fd656 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 24, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd656.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd656);

				FlightDetail fd657 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 25, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd657.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd657);

				FlightDetail fd658 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 26, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd658.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd658);

				FlightDetail fd659 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 27, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd659.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd659);

				FlightDetail fd660 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 28, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd660.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd660);

				FlightDetail fd661 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 29, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd661.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd661);

				FlightDetail fd662 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 30, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd662.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd662);

				FlightDetail fd663 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 5, 31, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd663.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd663);

				FlightDetail fd664 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 1, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd664.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd664);

				FlightDetail fd665 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 2, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd665.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd665);

				FlightDetail fd666 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 3, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd666.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd666);

				FlightDetail fd667 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 4, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd667.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd667);

				FlightDetail fd668 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 5, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd668.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd668);

				FlightDetail fd669 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 6, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd669.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd669);

				FlightDetail fd670 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 7, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd670.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd670);

				FlightDetail fd671 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 8, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd671.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd671);

				FlightDetail fd672 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 9, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd672.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd672);

				FlightDetail fd673 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 10, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd673.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd673);

				FlightDetail fd674 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 11, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd674.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd674);

				FlightDetail fd675 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 12, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd675.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd675);

				FlightDetail fd676 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 13, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd676.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd676);

				FlightDetail fd677 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 14, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd677.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd677);

				FlightDetail fd678 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 15, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd678.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd678);

				FlightDetail fd679 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 16, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd679.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd679);

				FlightDetail fd680 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 17, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd680.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd680);

				FlightDetail fd681 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 18, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd681.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd681);

				FlightDetail fd682 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 19, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd682.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd682);

				FlightDetail fd683 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 20, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd683.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd683);

				FlightDetail fd684 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 21, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd684.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd684);

				FlightDetail fd685 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 22, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd685.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd685);

				FlightDetail fd686 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 23, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd686.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd686);

				FlightDetail fd687 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 24, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd687.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd687);

				FlightDetail fd688 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 25, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd688.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd688);

				FlightDetail fd689 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 26, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd689.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd689);

				FlightDetail fd690 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 27, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd690.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd690);

				FlightDetail fd691 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 28, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd691.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd691);

				FlightDetail fd692 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 29, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd692.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd692);

				FlightDetail fd693 = new FlightDetail()
				{
					FlightNum = 1008,
					Date = new DateTime(2020, 6, 30, 13, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd693.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1008);
				FlightDetails.Add(fd693);

				FlightDetail fd694 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 15, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd694.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd694);

				FlightDetail fd695 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 16, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd695.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd695);

				FlightDetail fd696 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 17, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd696.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd696);

				FlightDetail fd697 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 18, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd697.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd697);

				FlightDetail fd698 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 19, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd698.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd698);

				FlightDetail fd699 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 20, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd699.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd699);

				FlightDetail fd700 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 21, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd700.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd700);

				FlightDetail fd701 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 22, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd701.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd701);

				FlightDetail fd702 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 23, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd702.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd702);

				FlightDetail fd703 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 24, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd703.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd703);

				FlightDetail fd704 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 25, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd704.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd704);

				FlightDetail fd705 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 26, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd705.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd705);

				FlightDetail fd706 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 27, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd706.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd706);

				FlightDetail fd707 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 28, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd707.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd707);

				FlightDetail fd708 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 29, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd708.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd708);

				FlightDetail fd709 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 4, 30, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd709.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd709);

				FlightDetail fd710 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 1, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd710.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd710);

				FlightDetail fd711 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 2, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd711.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd711);

				FlightDetail fd712 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 3, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd712.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd712);

				FlightDetail fd713 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 4, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd713.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd713);

				FlightDetail fd714 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 5, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd714.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd714);

				FlightDetail fd715 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 6, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd715.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd715);

				FlightDetail fd716 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 7, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd716.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd716);

				FlightDetail fd717 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 8, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd717.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd717);

				FlightDetail fd718 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 9, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd718.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd718);

				FlightDetail fd719 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 10, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd719.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd719);

				FlightDetail fd720 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 11, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd720.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd720);

				FlightDetail fd721 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 12, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd721.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd721);

				FlightDetail fd722 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 13, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd722.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd722);

				FlightDetail fd723 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 14, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd723.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd723);

				FlightDetail fd724 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 15, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd724.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd724);

				FlightDetail fd725 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 16, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd725.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd725);

				FlightDetail fd726 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 17, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd726.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd726);

				FlightDetail fd727 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 18, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd727.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd727);

				FlightDetail fd728 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 19, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd728.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd728);

				FlightDetail fd729 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 20, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd729.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd729);

				FlightDetail fd730 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 21, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd730.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd730);

				FlightDetail fd731 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 22, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd731.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd731);

				FlightDetail fd732 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 23, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd732.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd732);

				FlightDetail fd733 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 24, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd733.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd733);

				FlightDetail fd734 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 25, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd734.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd734);

				FlightDetail fd735 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 26, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd735.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd735);

				FlightDetail fd736 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 27, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd736.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd736);

				FlightDetail fd737 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 28, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd737.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd737);

				FlightDetail fd738 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 29, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd738.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd738);

				FlightDetail fd739 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 30, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd739.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd739);

				FlightDetail fd740 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 5, 31, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd740.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd740);

				FlightDetail fd741 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 1, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd741.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd741);

				FlightDetail fd742 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 2, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd742.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd742);

				FlightDetail fd743 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 3, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd743.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd743);

				FlightDetail fd744 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 4, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd744.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd744);

				FlightDetail fd745 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 5, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd745.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd745);

				FlightDetail fd746 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 6, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd746.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd746);

				FlightDetail fd747 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 7, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd747.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd747);

				FlightDetail fd748 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 8, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd748.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd748);

				FlightDetail fd749 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 9, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd749.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd749);

				FlightDetail fd750 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 10, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd750.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd750);

				FlightDetail fd751 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 11, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd751.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd751);

				FlightDetail fd752 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 12, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd752.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd752);

				FlightDetail fd753 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 13, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd753.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd753);

				FlightDetail fd754 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 14, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd754.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd754);

				FlightDetail fd755 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 15, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd755.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd755);

				FlightDetail fd756 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 16, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd756.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd756);

				FlightDetail fd757 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 17, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd757.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd757);

				FlightDetail fd758 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 18, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd758.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd758);

				FlightDetail fd759 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 19, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd759.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd759);

				FlightDetail fd760 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 20, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd760.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd760);

				FlightDetail fd761 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 21, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd761.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd761);

				FlightDetail fd762 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 22, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd762.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd762);

				FlightDetail fd763 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 23, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd763.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd763);

				FlightDetail fd764 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 24, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd764.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd764);

				FlightDetail fd765 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 25, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd765.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd765);

				FlightDetail fd766 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 26, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd766.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd766);

				FlightDetail fd767 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 27, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd767.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd767);

				FlightDetail fd768 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 28, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd768.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd768);

				FlightDetail fd769 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 29, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd769.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd769);

				FlightDetail fd770 = new FlightDetail()
				{
					FlightNum = 1009,
					Date = new DateTime(2020, 6, 30, 14, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 115,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd770.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1009);
				FlightDetails.Add(fd770);

				FlightDetail fd771 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 15, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd771.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd771);

				FlightDetail fd772 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 16, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd772.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd772);

				FlightDetail fd773 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 17, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd773.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd773);

				FlightDetail fd776 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 20, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd776.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd776);

				FlightDetail fd777 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 21, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd777.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd777);

				FlightDetail fd778 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 22, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd778.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd778);

				FlightDetail fd779 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 23, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd779.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd779);

				FlightDetail fd780 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 24, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd780.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd780);

				FlightDetail fd783 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 27, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd783.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd783);

				FlightDetail fd784 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 28, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd784.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd784);

				FlightDetail fd785 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 29, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd785.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd785);

				FlightDetail fd786 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 4, 30, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd786.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd786);

				FlightDetail fd787 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 1, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd787.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd787);

				FlightDetail fd790 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 4, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd790.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd790);

				FlightDetail fd791 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 5, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd791.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd791);

				FlightDetail fd792 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 6, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd792.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd792);

				FlightDetail fd793 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 7, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd793.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd793);

				FlightDetail fd794 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 8, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd794.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd794);

				FlightDetail fd797 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 11, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd797.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd797);

				FlightDetail fd798 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 12, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd798.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd798);

				FlightDetail fd799 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 13, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd799.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd799);

				FlightDetail fd800 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 14, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd800.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd800);

				FlightDetail fd801 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 15, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd801.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd801);

				FlightDetail fd804 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 18, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd804.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd804);

				FlightDetail fd805 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 19, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd805.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd805);

				FlightDetail fd806 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 20, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd806.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd806);

				FlightDetail fd807 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 21, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd807.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd807);

				FlightDetail fd808 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 22, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd808.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd808);

				FlightDetail fd811 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 25, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd811.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd811);

				FlightDetail fd812 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 26, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd812.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd812);

				FlightDetail fd813 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 27, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd813.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd813);

				FlightDetail fd814 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 28, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd814.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd814);

				FlightDetail fd815 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 5, 29, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd815.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd815);

				FlightDetail fd818 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 1, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd818.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd818);

				FlightDetail fd819 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 2, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd819.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd819);

				FlightDetail fd820 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 3, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd820.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd820);

				FlightDetail fd821 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 4, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd821.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd821);

				FlightDetail fd822 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 5, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd822.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd822);

				FlightDetail fd825 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 8, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd825.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd825);

				FlightDetail fd826 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 9, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd826.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd826);

				FlightDetail fd827 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 10, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd827.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd827);

				FlightDetail fd828 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 11, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd828.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd828);

				FlightDetail fd829 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 12, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd829.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd829);

				FlightDetail fd832 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 15, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd832.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd832);

				FlightDetail fd833 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 16, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd833.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd833);

				FlightDetail fd834 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 17, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd834.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd834);

				FlightDetail fd835 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 18, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd835.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd835);

				FlightDetail fd836 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 19, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd836.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd836);

				FlightDetail fd839 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 22, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd839.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd839);

				FlightDetail fd840 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 23, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd840.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd840);

				FlightDetail fd841 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 24, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd841.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd841);

				FlightDetail fd842 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 25, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd842.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd842);

				FlightDetail fd843 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 26, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd843.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd843);

				FlightDetail fd846 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 29, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd846.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd846);

				FlightDetail fd847 = new FlightDetail()
				{
					FlightNum = 1010,
					Date = new DateTime(2020, 6, 30, 14, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd847.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1010);
				FlightDetails.Add(fd847);

				FlightDetail fd848 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 15, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd848.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd848);

				FlightDetail fd849 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 16, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd849.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd849);

				FlightDetail fd850 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 17, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd850.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd850);

				FlightDetail fd853 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 20, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd853.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd853);

				FlightDetail fd854 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 21, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd854.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd854);

				FlightDetail fd855 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 22, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd855.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd855);

				FlightDetail fd856 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 23, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd856.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd856);

				FlightDetail fd857 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 24, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd857.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd857);

				FlightDetail fd860 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 27, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd860.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd860);

				FlightDetail fd861 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 28, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd861.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd861);

				FlightDetail fd862 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 29, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd862.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd862);

				FlightDetail fd863 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 4, 30, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd863.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd863);

				FlightDetail fd864 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 1, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd864.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd864);

				FlightDetail fd867 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 4, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd867.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd867);

				FlightDetail fd868 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 5, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd868.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd868);

				FlightDetail fd869 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 6, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd869.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd869);

				FlightDetail fd870 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 7, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd870.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd870);

				FlightDetail fd871 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 8, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd871.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd871);

				FlightDetail fd874 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 11, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd874.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd874);

				FlightDetail fd875 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 12, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd875.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd875);

				FlightDetail fd876 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 13, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd876.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd876);

				FlightDetail fd877 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 14, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd877.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd877);

				FlightDetail fd878 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 15, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd878.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd878);

				FlightDetail fd881 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 18, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd881.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd881);

				FlightDetail fd882 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 19, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd882.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd882);

				FlightDetail fd883 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 20, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd883.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd883);

				FlightDetail fd884 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 21, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd884.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd884);

				FlightDetail fd885 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 22, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd885.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd885);

				FlightDetail fd888 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 25, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd888.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd888);

				FlightDetail fd889 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 26, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd889.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd889);

				FlightDetail fd890 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 27, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd890.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd890);

				FlightDetail fd891 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 28, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd891.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd891);

				FlightDetail fd892 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 5, 29, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd892.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd892);

				FlightDetail fd895 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 1, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd895.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd895);

				FlightDetail fd896 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 2, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd896.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd896);

				FlightDetail fd897 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 3, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd897.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd897);

				FlightDetail fd898 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 4, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd898.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd898);

				FlightDetail fd899 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 5, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd899.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd899);

				FlightDetail fd902 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 8, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd902.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd902);

				FlightDetail fd903 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 9, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd903.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd903);

				FlightDetail fd904 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 10, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd904.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd904);

				FlightDetail fd905 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 11, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd905.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd905);

				FlightDetail fd906 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 12, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd906.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd906);

				FlightDetail fd909 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 15, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd909.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd909);

				FlightDetail fd910 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 16, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd910.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd910);

				FlightDetail fd911 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 17, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd911.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd911);

				FlightDetail fd912 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 18, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd912.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd912);

				FlightDetail fd913 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 19, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd913.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd913);

				FlightDetail fd916 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 22, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd916.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd916);

				FlightDetail fd917 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 23, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd917.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd917);

				FlightDetail fd918 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 24, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd918.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd918);

				FlightDetail fd919 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 25, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd919.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd919);

				FlightDetail fd920 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 26, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd920.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd920);

				FlightDetail fd923 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 29, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd923.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd923);

				FlightDetail fd924 = new FlightDetail()
				{
					FlightNum = 1011,
					Date = new DateTime(2020, 6, 30, 14, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 110,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd924.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1011);
				FlightDetails.Add(fd924);

				FlightDetail fd925 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 15, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd925.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd925);

				FlightDetail fd926 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 16, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd926.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd926);

				FlightDetail fd927 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 17, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd927.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd927);

				FlightDetail fd928 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 18, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd928.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd928);

				FlightDetail fd929 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 19, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd929.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd929);

				FlightDetail fd930 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 20, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd930.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd930);

				FlightDetail fd931 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 21, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd931.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd931);

				FlightDetail fd932 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 22, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd932.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd932);

				FlightDetail fd933 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 23, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd933.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd933);

				FlightDetail fd934 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 24, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd934.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd934);

				FlightDetail fd935 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 25, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd935.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd935);

				FlightDetail fd936 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 26, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd936.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd936);

				FlightDetail fd937 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 27, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd937.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd937);

				FlightDetail fd938 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 28, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd938.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd938);

				FlightDetail fd939 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 29, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd939.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd939);

				FlightDetail fd940 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 4, 30, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd940.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd940);

				FlightDetail fd941 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 1, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd941.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd941);

				FlightDetail fd942 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 2, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd942.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd942);

				FlightDetail fd943 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 3, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd943.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd943);

				FlightDetail fd944 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 4, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd944.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd944);

				FlightDetail fd945 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 5, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd945.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd945);

				FlightDetail fd946 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 6, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd946.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd946);

				FlightDetail fd947 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 7, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd947.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd947);

				FlightDetail fd948 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 8, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd948.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd948);

				FlightDetail fd949 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 9, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd949.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd949);

				FlightDetail fd950 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 10, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd950.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd950);

				FlightDetail fd951 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 11, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd951.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd951);

				FlightDetail fd952 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 12, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd952.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd952);

				FlightDetail fd953 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 13, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd953.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd953);

				FlightDetail fd954 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 14, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd954.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd954);

				FlightDetail fd955 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 15, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd955.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd955);

				FlightDetail fd956 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 16, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd956.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd956);

				FlightDetail fd957 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 17, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd957.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd957);

				FlightDetail fd958 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 18, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd958.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd958);

				FlightDetail fd959 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 19, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd959.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd959);

				FlightDetail fd960 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 20, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd960.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd960);

				FlightDetail fd961 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 21, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd961.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd961);

				FlightDetail fd962 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 22, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd962.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd962);

				FlightDetail fd963 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 23, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd963.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd963);

				FlightDetail fd964 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 24, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd964.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd964);

				FlightDetail fd965 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 25, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd965.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd965);

				FlightDetail fd966 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 26, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd966.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd966);

				FlightDetail fd967 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 27, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd967.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd967);

				FlightDetail fd968 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 28, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd968.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd968);

				FlightDetail fd969 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 29, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd969.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd969);

				FlightDetail fd970 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 30, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd970.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd970);

				FlightDetail fd971 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 5, 31, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd971.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd971);

				FlightDetail fd972 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 1, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd972.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd972);

				FlightDetail fd973 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 2, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd973.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd973);

				FlightDetail fd974 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 3, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd974.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd974);

				FlightDetail fd975 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 4, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd975.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd975);

				FlightDetail fd976 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 5, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd976.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd976);

				FlightDetail fd977 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 6, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd977.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd977);

				FlightDetail fd978 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 7, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd978.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd978);

				FlightDetail fd979 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 8, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd979.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd979);

				FlightDetail fd980 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 9, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd980.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd980);

				FlightDetail fd981 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 10, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd981.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd981);

				FlightDetail fd982 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 11, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd982.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd982);

				FlightDetail fd983 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 12, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd983.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd983);

				FlightDetail fd984 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 13, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd984.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd984);

				FlightDetail fd985 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 14, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd985.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd985);

				FlightDetail fd986 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 15, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd986.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd986);

				FlightDetail fd987 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 16, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd987.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd987);

				FlightDetail fd988 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 17, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd988.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd988);

				FlightDetail fd989 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 18, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd989.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd989);

				FlightDetail fd990 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 19, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd990.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd990);

				FlightDetail fd991 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 20, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd991.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd991);

				FlightDetail fd992 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 21, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd992.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd992);

				FlightDetail fd993 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 22, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd993.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd993);

				FlightDetail fd994 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 23, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd994.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd994);

				FlightDetail fd995 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 24, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd995.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd995);

				FlightDetail fd996 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 25, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd996.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd996);

				FlightDetail fd997 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 26, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd997.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd997);

				FlightDetail fd998 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 27, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd998.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd998);

				FlightDetail fd999 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 28, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd999.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd999);

				FlightDetail fd1000 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 29, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1000.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd1000);

				FlightDetail fd1001 = new FlightDetail()
				{
					FlightNum = 1012,
					Date = new DateTime(2020, 6, 30, 18, 0, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1001.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1012);
				FlightDetails.Add(fd1001);

				FlightDetail fd1002 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 15, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1002.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1002);

				FlightDetail fd1003 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 16, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1003.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1003);

				FlightDetail fd1004 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 17, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1004.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1004);

				FlightDetail fd1005 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 18, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1005.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1005);

				FlightDetail fd1006 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 19, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1006.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1006);

				FlightDetail fd1007 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 20, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1007.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1007);

				FlightDetail fd1008 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 21, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1008.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1008);

				FlightDetail fd1009 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 22, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1009.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1009);

				FlightDetail fd1010 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 23, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1010.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1010);

				FlightDetail fd1011 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 24, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1011.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1011);

				FlightDetail fd1012 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 25, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1012.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1012);

				FlightDetail fd1013 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 26, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1013.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1013);

				FlightDetail fd1014 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 27, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1014.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1014);

				FlightDetail fd1015 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 28, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1015.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1015);

				FlightDetail fd1016 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 29, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1016.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1016);

				FlightDetail fd1017 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 4, 30, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1017.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1017);

				FlightDetail fd1018 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 1, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1018.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1018);

				FlightDetail fd1019 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 2, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1019.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1019);

				FlightDetail fd1020 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 3, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1020.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1020);

				FlightDetail fd1021 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 4, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1021.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1021);

				FlightDetail fd1022 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 5, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1022.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1022);

				FlightDetail fd1023 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 6, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1023.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1023);

				FlightDetail fd1024 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 7, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1024.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1024);

				FlightDetail fd1025 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 8, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1025.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1025);

				FlightDetail fd1026 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 9, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1026.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1026);

				FlightDetail fd1027 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 10, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1027.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1027);

				FlightDetail fd1028 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 11, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1028.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1028);

				FlightDetail fd1029 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 12, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1029.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1029);

				FlightDetail fd1030 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 13, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1030.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1030);

				FlightDetail fd1031 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 14, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1031.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1031);

				FlightDetail fd1032 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 15, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1032.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1032);

				FlightDetail fd1033 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 16, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1033.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1033);

				FlightDetail fd1034 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 17, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1034.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1034);

				FlightDetail fd1035 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 18, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1035.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1035);

				FlightDetail fd1036 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 19, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1036.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1036);

				FlightDetail fd1037 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 20, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1037.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1037);

				FlightDetail fd1038 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 21, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1038.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1038);

				FlightDetail fd1039 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 22, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1039.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1039);

				FlightDetail fd1040 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 23, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1040.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1040);

				FlightDetail fd1041 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 24, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1041.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1041);

				FlightDetail fd1042 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 25, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1042.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1042);

				FlightDetail fd1043 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 26, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1043.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1043);

				FlightDetail fd1044 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 27, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1044.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1044);

				FlightDetail fd1045 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 28, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1045.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1045);

				FlightDetail fd1046 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 29, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1046.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1046);

				FlightDetail fd1047 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 30, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1047.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1047);

				FlightDetail fd1048 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 5, 31, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1048.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1048);

				FlightDetail fd1049 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 1, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1049.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1049);

				FlightDetail fd1050 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 2, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1050.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1050);

				FlightDetail fd1051 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 3, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1051.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1051);

				FlightDetail fd1052 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 4, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1052.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1052);

				FlightDetail fd1053 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 5, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1053.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1053);

				FlightDetail fd1054 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 6, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1054.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1054);

				FlightDetail fd1055 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 7, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1055.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1055);

				FlightDetail fd1056 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 8, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1056.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1056);

				FlightDetail fd1057 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 9, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1057.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1057);

				FlightDetail fd1058 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 10, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1058.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1058);

				FlightDetail fd1059 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 11, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1059.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1059);

				FlightDetail fd1060 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 12, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1060.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1060);

				FlightDetail fd1061 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 13, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1061.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1061);

				FlightDetail fd1062 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 14, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1062.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1062);

				FlightDetail fd1063 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 15, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1063.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1063);

				FlightDetail fd1064 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 16, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1064.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1064);

				FlightDetail fd1065 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 17, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1065.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1065);

				FlightDetail fd1066 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 18, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1066.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1066);

				FlightDetail fd1067 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 19, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1067.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1067);

				FlightDetail fd1068 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 20, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1068.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1068);

				FlightDetail fd1069 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 21, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1069.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1069);

				FlightDetail fd1070 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 22, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1070.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1070);

				FlightDetail fd1071 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 23, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1071.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1071);

				FlightDetail fd1072 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 24, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1072.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1072);

				FlightDetail fd1073 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 25, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1073.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1073);

				FlightDetail fd1074 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 26, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1074.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1074);

				FlightDetail fd1075 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 27, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1075.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1075);

				FlightDetail fd1076 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 28, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1076.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1076);

				FlightDetail fd1077 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 29, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1077.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1077);

				FlightDetail fd1078 = new FlightDetail()
				{
					FlightNum = 1013,
					Date = new DateTime(2020, 6, 30, 19, 45, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 105,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1078.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1013);
				FlightDetails.Add(fd1078);

				FlightDetail fd1082 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 4, 18, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1082.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1082);

				FlightDetail fd1089 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 4, 25, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1089.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1089);

				FlightDetail fd1096 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 5, 2, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)1

				};
				// Navigational Properties
				fd1096.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1096);

				FlightDetail fd1103 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 5, 9, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1103.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1103);

				FlightDetail fd1110 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 5, 16, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1110.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1110);

				FlightDetail fd1117 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 5, 23, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1117.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1117);

				FlightDetail fd1124 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 5, 30, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1124.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1124);

				FlightDetail fd1131 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 6, 6, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1131.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1131);

				FlightDetail fd1138 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 6, 13, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1138.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1138);

				FlightDetail fd1145 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 6, 20, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1145.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1145);

				FlightDetail fd1152 = new FlightDetail()
				{
					FlightNum = 1014,
					Date = new DateTime(2020, 6, 27, 10, 30, 0),
					Pilot = "",
					CoPilot = "",
					FlightAttendant = "",
					BaseFare = 225,
					flightStatus = (FlightStatus)0

				};
				// Navigational Properties
				fd1152.Flight = db.Flights.FirstOrDefault(f => f.FlightNum == 1014);
				FlightDetails.Add(fd1152);

				try
				{
					foreach (FlightDetail flightDetailToAdd in FlightDetails)
					{
						intFlightDetailNum = flightDetailToAdd.FlightDetailID;
						FlightDetail dbFlightDetail = db.FlightDetails.FirstOrDefault(f => f.FlightDetailID == flightDetailToAdd.FlightDetailID);
						if (dbFlightDetail == null) //this title doesn't exist
						{
							db.FlightDetails.Add(flightDetailToAdd);
							db.SaveChanges();
							intFlightDetailsAdded += 1;
						}
						else //book exists - update values
						{
							dbFlightDetail.FlightNum = flightDetailToAdd.FlightNum;
							dbFlightDetail.Date = flightDetailToAdd.Date;
							dbFlightDetail.Pilot = flightDetailToAdd.Pilot;
							dbFlightDetail.CoPilot = flightDetailToAdd.CoPilot;
							dbFlightDetail.FlightAttendant = flightDetailToAdd.FlightAttendant;
							dbFlightDetail.BaseFare = flightDetailToAdd.BaseFare;
							dbFlightDetail.flightStatus = flightDetailToAdd.flightStatus;
							dbFlightDetail.Flight = flightDetailToAdd.Flight;
							db.Update(dbFlightDetail);
							db.SaveChanges();
							intFlightDetailsAdded += 1;
						}
					}
				}
				catch (Exception ex)
				{
					String msg = "  Repositories added:" + intFlightDetailsAdded + "; Error on " + intFlightDetailNum;
					throw new InvalidOperationException(ex.Message + msg);
				}
			}
			catch (Exception e)
			{
				throw new InvalidOperationException(e.Message);
			}
		}
	}
}
