using System.Collections.Generic;
using System;
using System.Linq;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;

namespace sp20team13finalproject.Seeding
{
	public static class SeedFlights
	{
		public static void SeedAllFlights(AppDbContext db)
		{
			if (db.Flights.Count() == 15)
			{
				throw new NotSupportedException("The database already contains all 15 flights!");
			}

			Int32 intFlightsAdded = 0;
			
			List<Flight> Flights = new List<Flight>();

			try
			{
				Flight f1 = new Flight()
				{
					//FlightID
					FlightNum = 1000,
					DepCity = "Austin",
					DepTime = new TimeSpan(8, 0, 0), //Time: 8:00
					ArrivalCity = "Dallas",
					Days = "MTWRF"
				};
				f1.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				f1.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				Flights.Add(f1);

				Flight f2 = new Flight()
				{
					//FlightID
					FlightNum = 1001,
					DepCity = "Dallas",
					DepTime = new TimeSpan(9, 0, 0), //Time: 9:00
					ArrivalCity = "Austin",
					Days = "MTWRF"
				};
				f2.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				f2.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				Flights.Add(f2);

				Flight f3 = new Flight()
				{
					//FlightID
					FlightNum = 1002,
					DepCity = "Austin",
					DepTime = new TimeSpan(11, 15, 0), //Time: 11:15
					ArrivalCity = "Houston",
					Days = "MTWRFAU"
				};
				f3.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				f3.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				Flights.Add(f3);

				Flight f4 = new Flight()
				{
					//FlightID
					FlightNum = 1003,
					DepCity = "Houston",
					DepTime = new TimeSpan(12, 0, 0), //Time: 12:00
					ArrivalCity = "Austin",
					Days = "MTWRFAU"
				};
				f4.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				f4.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				Flights.Add(f4);

				Flight f5 = new Flight()
				{
					//FlightID
					FlightNum = 1004,
					DepCity = "Houston",
					DepTime = new TimeSpan(13, 0, 0), //Time: 13:00
					ArrivalCity = "El Paso",
					Days = "MTWRFAU"
				};
				f5.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				f5.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				Flights.Add(f5);

				Flight f6 = new Flight()
				{
					//FlightID
					FlightNum = 1005,
					DepCity = "El Paso",
					DepTime = new TimeSpan(15, 0, 0), //Time: 15:00
					ArrivalCity = "Houston",
					Days = "MTWRFAU"
				};
				f6.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				f6.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				Flights.Add(f6);

				Flight f7 = new Flight()
				{
					//FlightID
					FlightNum = 1006,
					DepCity = "Dallas",
					DepTime = new TimeSpan(9, 0, 0), //Time: 9:00
					ArrivalCity = "El Paso",
					Days = "MTWRF"
				};
				f7.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				f7.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				Flights.Add(f7);

				Flight f8 = new Flight()
				{
					//FlightID
					FlightNum = 1007,
					DepCity = "El Paso",
					DepTime = new TimeSpan(10, 15, 0), //Time: 10:15
					ArrivalCity = "Dallas",
					Days = "MTWRF"
				};
				f8.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				f8.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				Flights.Add(f8);

				Flight f9 = new Flight()
				{
					//FlightID
					FlightNum = 1008,
					DepCity = "Austin",
					DepTime = new TimeSpan(13, 0, 0), //Time: 13:00
					ArrivalCity = "El Paso",
					Days = "MTWRFAU"
				};
				f9.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				f9.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				Flights.Add(f9);

				Flight f10 = new Flight()
				{
					//FlightID
					FlightNum = 1009,
					DepCity = "El Paso",
					DepTime = new TimeSpan(14, 30, 0), //Time: 14:30
					ArrivalCity = "Austin",
					Days = "MTWRFAU"
				};
				f10.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				f10.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				Flights.Add(f10);

				Flight f11 = new Flight()
				{
					//FlightID
					FlightNum = 1010,
					DepCity = "Dallas",
					DepTime = new TimeSpan(14, 0, 0), //Time: 14:00
					ArrivalCity = "Houston",
					Days = "MTWRF"
				};
				f11.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				f11.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				Flights.Add(f11);

				Flight f12 = new Flight()
				{
					//FlightID
					FlightNum = 1011,
					DepCity = "Houston",
					DepTime = new TimeSpan(14, 45, 0), //Time: 14:45
					ArrivalCity = "Dallas",
					Days = "MTWRF"
				};
				f12.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				f12.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				Flights.Add(f12);

				Flight f13 = new Flight()
				{
					//FlightID
					FlightNum = 1012,
					DepCity = "Austin",
					DepTime = new TimeSpan(18, 0, 0), //Time: 18:00
					ArrivalCity = "El Paso",
					Days = "MTWRFAU"
				};
				f13.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				f13.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				Flights.Add(f13);

				Flight f14 = new Flight()
				{
					//FlightID
					FlightNum = 1013,
					DepCity = "El Paso",
					DepTime = new TimeSpan(19, 45, 0), //Time: 19:45
					ArrivalCity = "Austin",
					Days = "MTWRFAU"
				};
				f14.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8004");
				f14.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8001");
				Flights.Add(f14);

				Flight f15 = new Flight()
				{
					//FlightID
					FlightNum = 1014,
					DepCity = "Dallas",
					DepTime = new TimeSpan(10, 30, 0), //Time: 10:30
					ArrivalCity = "Houston",
					Days = "A"
				};
				f15.DepartingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8002");
				f15.ArrivingAirport = db.Airports.FirstOrDefault(a => a.CityNum == "8003");
				Flights.Add(f15);

				foreach (Flight flightToAdd in Flights)
				{
					Flight dbFlight = db.Flights.FirstOrDefault(f => f.FlightNum == flightToAdd.FlightNum);
					if (dbFlight == null)
					{
						db.Flights.Add(flightToAdd);
						db.SaveChanges();
						intFlightsAdded += 1;
					}
				}
			}
			catch
			{
				String msg = "Flights Added: " + intFlightsAdded.ToString();
				throw new InvalidOperationException(msg);
			}
		}
	}
}