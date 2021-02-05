using System.Collections.Generic;
using System;
using System.Linq;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;

namespace sp20team13finalproject.Seeding
{
	public static class SeedAirports
	{
		public static void SeedAllAirports(AppDbContext db)
		{
			if (db.Airports.Count() == 4)
			{
				throw new NotSupportedException("The database already contains all 4 airports!");
			}

			Int32 intAirportsAdded = 0;
			String strAirportCity= "Begin"; //helps to keep track of error on books
			List<Airport> Airports = new List<Airport>();

			try
			{
				Airport a1 = new Airport()
				{
					// AirportID
					CityNum = "8001",
					City = "Austin",
					APCode = "AUS",
					State = "TX",
					DisToAus = 0,
					DisToDal = 190,
					DisToEP = 527,
					DisToHou = 148,
					DurToAus = TimeSpan.Parse("00:00:00"),
					DurToDal = TimeSpan.Parse("00:55:00"),
					DurToEP = TimeSpan.Parse("01:40:00"),
					DurToHou = TimeSpan.Parse("01:00:00")
				};
				Airports.Add(a1);

				Airport a2 = new Airport()
				{
					// AirportID
					CityNum = "8002",
					City = "Dallas",
					APCode = "DAL",
					State = "TX",
					DisToAus = 190,
					DisToDal = 0,
					DisToEP = 551,
					DisToHou = 224,
					DurToAus = TimeSpan.Parse("00:55:00"),
					DurToDal = TimeSpan.Parse("00:00:00"),
					DurToEP = TimeSpan.Parse("01:53:00"),
					DurToHou = TimeSpan.Parse("01:13:00")
				};
				Airports.Add(a2);

				Airport a3 = new Airport()
				{
					// AirportID
					CityNum = "8003",
					City = "Houston",
					APCode = "HOU",
					State = "TX",
					DisToAus = 148,
					DisToDal = 224,
					DisToEP = 667,
					DisToHou = 0,
					DurToAus = TimeSpan.Parse("01:00:00"),
					DurToDal = TimeSpan.Parse("01:13:00"),
					DurToEP = TimeSpan.Parse("02:09:00"),
					DurToHou = TimeSpan.Parse("00:00:00")
				};
				Airports.Add(a3);

				Airport a4 = new Airport()
				{
					// AirportID
					CityNum = "8004",
					City = "El Paso",
					APCode = "ELP",
					State = "TX",
					DisToAus = 527,
					DisToDal = 551,
					DisToEP = 0,
					DisToHou = 667,
					DurToAus = TimeSpan.Parse("01:40:00"),
					DurToDal = TimeSpan.Parse("01:53:00"),
					DurToEP = TimeSpan.Parse("00:00:00"),
					DurToHou = TimeSpan.Parse("02:09:00")
				};
				Airports.Add(a4);

				try
				{
					foreach (Airport airportToAdd in Airports)
					{
						strAirportCity = airportToAdd.City;
						Airport dbAirport = db.Airports.FirstOrDefault(b => b.City == airportToAdd.City);
						if (dbAirport == null) //this city doesn't exist
						{
							db.Airports.Add(airportToAdd);
							db.SaveChanges();
							intAirportsAdded += 1;
						}
						else //city exists - update values
						{
							dbAirport.City = airportToAdd.City;
							dbAirport.CityNum = airportToAdd.CityNum;
							dbAirport.APCode = airportToAdd.APCode;
							dbAirport.State = airportToAdd.State;
							dbAirport.DisToAus = airportToAdd.DisToAus;
							dbAirport.DisToDal = airportToAdd.DisToDal;
							dbAirport.DisToEP = airportToAdd.DisToEP;
							dbAirport.DisToHou = airportToAdd.DisToHou;
							dbAirport.DurToAus = airportToAdd.DurToAus;
							dbAirport.DurToDal = airportToAdd.DurToDal;
							dbAirport.DurToEP = airportToAdd.DurToEP;
							dbAirport.DurToHou = airportToAdd.DurToHou;
							db.Update(dbAirport);
							db.SaveChanges();
							intAirportsAdded += 1;
						}
					}
				}
				catch (Exception ex)
				{
					String msg = "  Repositories added:" + intAirportsAdded + "; Error on " + strAirportCity;
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
