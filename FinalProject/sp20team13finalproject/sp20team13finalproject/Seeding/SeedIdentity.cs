using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using sp20team13finalproject.DAL;
using sp20team13finalproject.Models;
using static sp20team13finalproject.Models.AppUser;

//This code will be run when you start the project
//It will add a single admin user to your database.  

namespace sp20team13finalproject.Seeding
{
    //add identity data
    public static class SeedIdentity
    {
        // Function Used To Add Identity Roles and Seed The First User of Each Role (Called In Startup.cs)
        public static async Task AddRolesAndUsers(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //Add the needed roles
            //if role doesn't exist, add it
            //1. Customers – these users have access to the external (customer) site only.  
            if (await _roleManager.RoleExistsAsync("Customer") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Customer"));
            }
            //2. Crew – these are employees of Longhorn Airlines who do NOT have the ability to create / modify reservation.Crew members only have access to their own employee profiles.
            if (await _roleManager.RoleExistsAsync("Crew") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Crew"));
            }
            //3. Ticket Agents – Ticket agents have all reservation functions as well as the ability to add or modify customer profiles.  
            //They also have the ability to perform the airport counter, gate checking, and flight departure functions.
            if (await _roleManager.RoleExistsAsync("TicketAgent") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("TicketAgent"));
            }
            //4. Management – Mangers have access to all ticket agent functionality, plus the ability to view reports, change flight information, and modify profiles for all employees and customers.
            if (await _roleManager.RoleExistsAsync("Management") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Management"));
            }


            // FIRST CUSTOMER
            //check to see if the admin has been added
            AppUser newCustomer = _db.Users.FirstOrDefault(u => u.Email == "cbaker@freserve.co.uk");

            //if admin hasn't been created, then add them
            if (newCustomer == null)
            {
                newCustomer = new AppUser();
                //UserID
                newCustomer.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
                newCustomer.UserName = "cbaker@freserve.co.uk";
                //Password
                newCustomer.Email = "cbaker@freserve.co.uk";
                newCustomer.FirstName = "Christopher";
                //MI
                newCustomer.LastName = "Baker";
                newCustomer.DOB = "11231949";
                newCustomer.Address = "1245 Lake Anchorage Blvd.";
                newCustomer.City = "Dallas";
                newCustomer.State = "TX";
                newCustomer.Zip = "75001";
                newCustomer.PhoneNumber = "4695571146"; // From Identity
                newCustomer.Miles = 5000;
                newCustomer.empType = (EmpType)0; 

                //Add additional fields that you created on the AppUser class

                //NOTE: This creates the user - "Abc123!" is the password for this user
                var result = await _userManager.CreateAsync(newCustomer, "hello");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                newCustomer = _db.Users.FirstOrDefault(u => u.UserName == "cbaker@freserve.co.uk");
            }

            //Add the new user we just created to the Admin role
            if (await _userManager.IsInRoleAsync(newCustomer, "Customer") == false)
            {
                await _userManager.AddToRoleAsync(newCustomer, "Customer");
            }

            AppUser newCustomer0 = _db.Users.FirstOrDefault(u => u.Email == "banker@longhorn.net");

            if (newCustomer0 == null)
            {
                newCustomer0 = new AppUser();
                newCustomer0.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
                newCustomer0.UserName = "banker@longhorn.net";
                newCustomer0.Email = "banker@longhorn.net";
                newCustomer0.FirstName = "Michelle";
                newCustomer0.LastName = "Banks";
                newCustomer0.DOB = "112762";
                newCustomer0.Address = "1300 Tall Pine Lane";
                newCustomer0.City = "Dallas";
                newCustomer0.State = "TX";
                newCustomer0.Zip = "75002";
                newCustomer0.PhoneNumber = "4692678873";
                newCustomer0.Miles = 0;
                newCustomer0.empType = (EmpType)0;


                var result = await _userManager.CreateAsync(newCustomer0, "potato");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user cannot be added - " + result.ToString());
                }
                _db.SaveChanges();
                newCustomer0 = _db.Users.FirstOrDefault(u => u.UserName == "banker@longhorn.net");
            }

            if (await _userManager.IsInRoleAsync(newCustomer0, "Customer") == false)
            {
                await _userManager.AddToRoleAsync(newCustomer0, "Customer");
            }

			AppUser newCustomer1 = _db.Users.FirstOrDefault(u => u.Email == "franco@aoll.com");

			if (newCustomer1 == null)
			{
				newCustomer1 = new AppUser();
				newCustomer1.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer1.UserName = "franco@aoll.com";
				newCustomer1.Email = "franco@aoll.com";
				newCustomer1.FirstName = "Franco";
				newCustomer1.LastName = "Broccolo";
				newCustomer1.DOB = "101192";
				newCustomer1.Address = "62 Browning Road";
				newCustomer1.City = "Houston";
				newCustomer1.State = "TX";
				newCustomer1.Zip = "77003";
				newCustomer1.PhoneNumber = "2815659699";
				newCustomer1.Miles = 10000;
				newCustomer1.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer1, "painting");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer1 = _db.Users.FirstOrDefault(u => u.UserName == "franco@aoll.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer1, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer1, "Customer");
			}

			AppUser newCustomer2 = _db.Users.FirstOrDefault(u => u.Email == "wchang@gogle.com");

			if (newCustomer2 == null)
			{
				newCustomer2 = new AppUser();
				newCustomer2.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer2.UserName = "wchang@gogle.com";
				newCustomer2.Email = "wchang@gogle.com";
				newCustomer2.FirstName = "Wendy";
				newCustomer2.LastName = "Chang";
				newCustomer2.DOB = "051697";
				newCustomer2.Address = "202 Bellmont Hall";
				newCustomer2.City = "Austin";
				newCustomer2.State = "TX";
				newCustomer2.Zip = "78719";
				newCustomer2.PhoneNumber = "5125943222";
				newCustomer2.Miles = 5000;
				newCustomer2.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer2, "texas");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer2 = _db.Users.FirstOrDefault(u => u.UserName == "wchang@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer2, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer2, "Customer");
			}

			AppUser newCustomer3 = _db.Users.FirstOrDefault(u => u.Email == "limchou@yoho.com");

			if (newCustomer3 == null)
			{
				newCustomer3 = new AppUser();
				newCustomer3.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer3.UserName = "limchou@yoho.com";
				newCustomer3.Email = "limchou@yoho.com";
				newCustomer3.FirstName = "Lim";
				newCustomer3.LastName = "Chou";
				newCustomer3.DOB = "040670";
				newCustomer3.Address = "1600 Teresa Lane";
				newCustomer3.City = "Fort Meyers";
				newCustomer3.State = "FL";
				newCustomer3.Zip = "33917";
				newCustomer3.PhoneNumber = "8137724599";
				newCustomer3.Miles = 0;
				newCustomer3.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer3, "Anchorage");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer3 = _db.Users.FirstOrDefault(u => u.UserName == "limchou@yoho.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer3, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer3, "Customer");
			}

			AppUser newCustomer4 = _db.Users.FirstOrDefault(u => u.Email == "shdixon@utx.edu");

			if (newCustomer4 == null)
			{
				newCustomer4 = new AppUser();
				newCustomer4.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer4.UserName = "shdixon@utx.edu";
				newCustomer4.Email = "shdixon@utx.edu";
				newCustomer4.FirstName = "Shan";
				newCustomer4.LastName = "Dixon";
				newCustomer4.DOB = "011284";
				newCustomer4.Address = "234 Holston Circle";
				newCustomer4.City = "Sheffield";
				newCustomer4.State = "AL";
				newCustomer4.Zip = "35662";
				newCustomer4.PhoneNumber = "2052643255";
				newCustomer4.Miles = 0;
				newCustomer4.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer4, "pepperoni");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer4 = _db.Users.FirstOrDefault(u => u.UserName == "shdixon@utx.edu");
			}

			if (await _userManager.IsInRoleAsync(newCustomer4, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer4, "Customer");
			}

			AppUser newCustomer5 = _db.Users.FirstOrDefault(u => u.Email == "j.b.evans@aheca.org");

			if (newCustomer5 == null)
			{
				newCustomer5 = new AppUser();
				newCustomer5.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer5.UserName = "j.b.evans@aheca.org";
				newCustomer5.Email = "j.b.evans@aheca.org";
				newCustomer5.FirstName = "Jim Bob";
				newCustomer5.LastName = "Evans";
				newCustomer5.DOB = "090959";
				newCustomer5.Address = "506 Farrell Circle";
				newCustomer5.City = "Austin";
				newCustomer5.State = "TX";
				newCustomer5.Zip = "78705";
				newCustomer5.PhoneNumber = "5122565834";
				newCustomer5.Miles = 9000;
				newCustomer5.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer5, "longhorns");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer5 = _db.Users.FirstOrDefault(u => u.UserName == "j.b.evans@aheca.org");
			}

			if (await _userManager.IsInRoleAsync(newCustomer5, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer5, "Customer");
			}

			AppUser newCustomer6 = _db.Users.FirstOrDefault(u => u.Email == "feeley@longhorn.org");

			if (newCustomer6 == null)
			{
				newCustomer6 = new AppUser();
				newCustomer6.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer6.UserName = "feeley@longhorn.org";
				newCustomer6.Email = "feeley@longhorn.org";
				newCustomer6.FirstName = "Lou Ann";
				newCustomer6.LastName = "Feeley";
				newCustomer6.DOB = "011202";
				newCustomer6.Address = "600 S 8th Street W";
				newCustomer6.City = "El Paso";
				newCustomer6.State = "TX";
				newCustomer6.Zip = "79901";
				newCustomer6.PhoneNumber = "9152556749";
				newCustomer6.Miles = 6000;
				newCustomer6.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer6, "aggies");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer6 = _db.Users.FirstOrDefault(u => u.UserName == "feeley@longhorn.org");
			}

			if (await _userManager.IsInRoleAsync(newCustomer6, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer6, "Customer");
			}

			AppUser newCustomer7 = _db.Users.FirstOrDefault(u => u.Email == "tfreeley@minnetonka.ci.us");

			if (newCustomer7 == null)
			{
				newCustomer7 = new AppUser();
				newCustomer7.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer7.UserName = "tfreeley@minnetonka.ci.us";
				newCustomer7.Email = "tfreeley@minnetonka.ci.us";
				newCustomer7.FirstName = "Tesa";
				newCustomer7.LastName = "Freeley";
				newCustomer7.DOB = "020491";
				newCustomer7.Address = "4448 Fairview Ave.";
				newCustomer7.City = "Minnetonka";
				newCustomer7.State = "MN";
				newCustomer7.Zip = "55343";
				newCustomer7.PhoneNumber = "6123255687";
				newCustomer7.Miles = 0;
				newCustomer7.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer7, "raiders");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer7 = _db.Users.FirstOrDefault(u => u.UserName == "tfreeley@minnetonka.ci.us");
			}

			if (await _userManager.IsInRoleAsync(newCustomer7, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer7, "Customer");
			}

			AppUser newCustomer8 = _db.Users.FirstOrDefault(u => u.Email == "mgarcia@gogle.com");

			if (newCustomer8 == null)
			{
				newCustomer8 = new AppUser();
				newCustomer8.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer8.UserName = "mgarcia@gogle.com";
				newCustomer8.Email = "mgarcia@gogle.com";
				newCustomer8.FirstName = "Margaret";
				newCustomer8.LastName = "Garcia";
				newCustomer8.DOB = "100291";
				newCustomer8.Address = "594 Longview";
				newCustomer8.City = "Dallas";
				newCustomer8.State = "TX";
				newCustomer8.Zip = "75043";
				newCustomer8.PhoneNumber = "4696593544";
				newCustomer8.Miles = 4000;
				newCustomer8.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer8, "mustangs");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer8 = _db.Users.FirstOrDefault(u => u.UserName == "mgarcia@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer8, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer8, "Customer");
			}

			AppUser newCustomer9 = _db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com");

			if (newCustomer9 == null)
			{
				newCustomer9 = new AppUser();
				newCustomer9.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer9.UserName = "chaley@thug.com";
				newCustomer9.Email = "chaley@thug.com";
				newCustomer9.FirstName = "Charles";
				newCustomer9.LastName = "Haley";
				newCustomer9.DOB = "071074";
				newCustomer9.Address = "One Cowboy Pkwy";
				newCustomer9.City = "Dallas";
				newCustomer9.State = "TX";
				newCustomer9.Zip = "75032";
				newCustomer9.PhoneNumber = "4698475583";
				newCustomer9.Miles = 7000;
				newCustomer9.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer9, "onetime");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer9 = _db.Users.FirstOrDefault(u => u.UserName == "chaley@thug.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer9, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer9, "Customer");
			}

			AppUser newCustomer10 = _db.Users.FirstOrDefault(u => u.Email == "jeffh@sonic.com");

			if (newCustomer10 == null)
			{
				newCustomer10 = new AppUser();
				newCustomer10.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer10.UserName = "jeffh@sonic.com";
				newCustomer10.Email = "jeffh@sonic.com";
				newCustomer10.FirstName = "Jeffrey";
				newCustomer10.LastName = "Hampton";
				newCustomer10.DOB = "031014";
				newCustomer10.Address = "337 38th St.";
				newCustomer10.City = "Dallas";
				newCustomer10.State = "TX";
				newCustomer10.Zip = "75209";
				newCustomer10.PhoneNumber = "4696978613";
				newCustomer10.Miles = 5000;
				newCustomer10.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer10, "hampton1");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer10 = _db.Users.FirstOrDefault(u => u.UserName == "jeffh@sonic.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer10, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer10, "Customer");
			}

			AppUser newCustomer11 = _db.Users.FirstOrDefault(u => u.Email == "wjhearniii@umich.org");

			if (newCustomer11 == null)
			{
				newCustomer11 = new AppUser();
				newCustomer11.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer11.UserName = "wjhearniii@umich.org";
				newCustomer11.Email = "wjhearniii@umich.org";
				newCustomer11.FirstName = "John";
				newCustomer11.LastName = "Hearn";
				newCustomer11.DOB = "080550";
				newCustomer11.Address = "4225 North First";
				newCustomer11.City = "Houston";
				newCustomer11.State = "TX";
				newCustomer11.Zip = "77010";
				newCustomer11.PhoneNumber = "2818965621";
				newCustomer11.Miles = 7000;
				newCustomer11.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer11, "jhearn22");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer11 = _db.Users.FirstOrDefault(u => u.UserName == "wjhearniii@umich.org");
			}

			if (await _userManager.IsInRoleAsync(newCustomer11, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer11, "Customer");
			}

			AppUser newCustomer12 = _db.Users.FirstOrDefault(u => u.Email == "ahick@yaho.com");

			if (newCustomer12 == null)
			{
				newCustomer12 = new AppUser();
				newCustomer12.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer12.UserName = "ahick@yaho.com";
				newCustomer12.Email = "ahick@yaho.com";
				newCustomer12.FirstName = "Anthony";
				newCustomer12.LastName = "Hicks";
				newCustomer12.DOB = "120805";
				newCustomer12.Address = "32 NE Garden Ln., Ste 910";
				newCustomer12.City = "Houston";
				newCustomer12.State = "TX";
				newCustomer12.Zip = "77012";
				newCustomer12.PhoneNumber = "2815788965";
				newCustomer12.Miles = 6000;
				newCustomer12.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer12, "hickhickup");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer12 = _db.Users.FirstOrDefault(u => u.UserName == "ahick@yaho.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer12, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer12, "Customer");
			}

			AppUser newCustomer13 = _db.Users.FirstOrDefault(u => u.Email == "ingram@jack.com");

			if (newCustomer13 == null)
			{
				newCustomer13 = new AppUser();
				newCustomer13.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer13.UserName = "ingram@jack.com";
				newCustomer13.Email = "ingram@jack.com";
				newCustomer13.FirstName = "Brad";
				newCustomer13.LastName = "Ingram";
				newCustomer13.DOB = "090516";
				newCustomer13.Address = "6548 La Posada Ct.";
				newCustomer13.City = "Austin";
				newCustomer13.State = "TX";
				newCustomer13.Zip = "78613";
				newCustomer13.PhoneNumber = "5124678821";
				newCustomer13.Miles = 8000;
				newCustomer13.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer13, "ingram2015");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer13 = _db.Users.FirstOrDefault(u => u.UserName == "ingram@jack.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer13, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer13, "Customer");
			}

			AppUser newCustomer14 = _db.Users.FirstOrDefault(u => u.Email == "toddj@yourmom.com");

			if (newCustomer14 == null)
			{
				newCustomer14 = new AppUser();
				newCustomer14.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer14.UserName = "toddj@yourmom.com";
				newCustomer14.Email = "toddj@yourmom.com";
				newCustomer14.FirstName = "Todd";
				newCustomer14.LastName = "Jacobs";
				newCustomer14.DOB = "012099";
				newCustomer14.Address = "4564 Elm St.";
				newCustomer14.City = "El Paso";
				newCustomer14.State = "TX";
				newCustomer14.Zip = "79991";
				newCustomer14.PhoneNumber = "9154653365";
				newCustomer14.Miles = 5000;
				newCustomer14.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer14, "toddy25");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer14 = _db.Users.FirstOrDefault(u => u.UserName == "toddj@yourmom.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer14, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer14, "Customer");
			}

			AppUser newCustomer15 = _db.Users.FirstOrDefault(u => u.Email == "thequeen@aska.net");

			if (newCustomer15 == null)
			{
				newCustomer15 = new AppUser();
				newCustomer15.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer15.UserName = "thequeen@aska.net";
				newCustomer15.Email = "thequeen@aska.net";
				newCustomer15.FirstName = "Victoria";
				newCustomer15.LastName = "Lawrence";
				newCustomer15.DOB = "041400";
				newCustomer15.Address = "6639 Butterfly Ln.";
				newCustomer15.City = "El Paso";
				newCustomer15.State = "TX";
				newCustomer15.Zip = "79930";
				newCustomer15.PhoneNumber = "9159457399";
				newCustomer15.Miles = 0;
				newCustomer15.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer15, "something");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer15 = _db.Users.FirstOrDefault(u => u.UserName == "thequeen@aska.net");
			}

			if (await _userManager.IsInRoleAsync(newCustomer15, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer15, "Customer");
			}

			AppUser newCustomer16 = _db.Users.FirstOrDefault(u => u.Email == "linebacker@gogle.com");

			if (newCustomer16 == null)
			{
				newCustomer16 = new AppUser();
				newCustomer16.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer16.UserName = "linebacker@gogle.com";
				newCustomer16.Email = "linebacker@gogle.com";
				newCustomer16.FirstName = "Erik";
				newCustomer16.LastName = "Lineback";
				newCustomer16.DOB = "120213";
				newCustomer16.Address = "1300 Netherland St";
				newCustomer16.City = "Austin";
				newCustomer16.State = "TX";
				newCustomer16.Zip = "78613";
				newCustomer16.PhoneNumber = "5122449976";
				newCustomer16.Miles = 6000;
				newCustomer16.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer16, "Password1");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer16 = _db.Users.FirstOrDefault(u => u.UserName == "linebacker@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer16, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer16, "Customer");
			}

			AppUser newCustomer17 = _db.Users.FirstOrDefault(u => u.Email == "elowe@netscare.net");

			if (newCustomer17 == null)
			{
				newCustomer17 = new AppUser();
				newCustomer17.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer17.UserName = "elowe@netscare.net";
				newCustomer17.Email = "elowe@netscare.net";
				newCustomer17.FirstName = "Ernest";
				newCustomer17.LastName = "Lowe";
				newCustomer17.DOB = "120777";
				newCustomer17.Address = "3201 Pine Drive";
				newCustomer17.City = "Dallas";
				newCustomer17.State = "TX";
				newCustomer17.Zip = "75039";
				newCustomer17.PhoneNumber = "4695344627";
				newCustomer17.Miles = 2000;
				newCustomer17.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer17, "aclfest2017");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer17 = _db.Users.FirstOrDefault(u => u.UserName == "elowe@netscare.net");
			}

			if (await _userManager.IsInRoleAsync(newCustomer17, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer17, "Customer");
			}

			AppUser newCustomer18 = _db.Users.FirstOrDefault(u => u.Email == "cluce@gogle.com");

			if (newCustomer18 == null)
			{
				newCustomer18 = new AppUser();
				newCustomer18.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer18.UserName = "cluce@gogle.com";
				newCustomer18.Email = "cluce@gogle.com";
				newCustomer18.FirstName = "Chuck";
				newCustomer18.LastName = "Luce";
				newCustomer18.DOB = "031649";
				newCustomer18.Address = "2345 Rolling Clouds";
				newCustomer18.City = "Austin";
				newCustomer18.State = "TX";
				newCustomer18.Zip = "78712";
				newCustomer18.PhoneNumber = "5126983548";
				newCustomer18.Miles = 8000;
				newCustomer18.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer18, "nothinggood");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer18 = _db.Users.FirstOrDefault(u => u.UserName == "cluce@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer18, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer18, "Customer");
			}

			AppUser newCustomer19 = _db.Users.FirstOrDefault(u => u.Email == "mackcloud@george.com");

			if (newCustomer19 == null)
			{
				newCustomer19 = new AppUser();
				newCustomer19.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer19.UserName = "mackcloud@george.com";
				newCustomer19.Email = "mackcloud@george.com";
				newCustomer19.FirstName = "Jennifer";
				newCustomer19.LastName = "MacLeod";
				newCustomer19.DOB = "022147";
				newCustomer19.Address = "2504 Far West Blvd.";
				newCustomer19.City = "Houston";
				newCustomer19.State = "TX";
				newCustomer19.Zip = "77012";
				newCustomer19.PhoneNumber = "2814748138";
				newCustomer19.Miles = 5000;
				newCustomer19.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer19, "whatever");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer19 = _db.Users.FirstOrDefault(u => u.UserName == "mackcloud@george.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer19, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer19, "Customer");
			}

			AppUser newCustomer20 = _db.Users.FirstOrDefault(u => u.Email == "cmartin@beets.com");

			if (newCustomer20 == null)
			{
				newCustomer20 = new AppUser();
				newCustomer20.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer20.UserName = "cmartin@beets.com";
				newCustomer20.Email = "cmartin@beets.com";
				newCustomer20.FirstName = "Elizabeth";
				newCustomer20.LastName = "Markham";
				newCustomer20.DOB = "032072";
				newCustomer20.Address = "7861 Chevy Chase";
				newCustomer20.City = "Dallas";
				newCustomer20.State = "TX";
				newCustomer20.Zip = "75249";
				newCustomer20.PhoneNumber = "4694579845";
				newCustomer20.Miles = 7000;
				newCustomer20.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer20, "whocares");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer20 = _db.Users.FirstOrDefault(u => u.UserName == "cmartin@beets.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer20, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer20, "Customer");
			}

			AppUser newCustomer21 = _db.Users.FirstOrDefault(u => u.Email == "clarence@yoho.com");

			if (newCustomer21 == null)
			{
				newCustomer21 = new AppUser();
				newCustomer21.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer21.UserName = "clarence@yoho.com";
				newCustomer21.Email = "clarence@yoho.com";
				newCustomer21.FirstName = "Clarence";
				newCustomer21.LastName = "Martin";
				newCustomer21.DOB = "071992";
				newCustomer21.Address = "87 Alcedo St.";
				newCustomer21.City = "San Diego";
				newCustomer21.State = "CA";
				newCustomer21.Zip = "82448";
				newCustomer21.PhoneNumber = "9204955201";
				newCustomer21.Miles = 2000;
				newCustomer21.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer21, "xcellent");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer21 = _db.Users.FirstOrDefault(u => u.UserName == "clarence@yoho.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer21, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer21, "Customer");
			}

			AppUser newCustomer22 = _db.Users.FirstOrDefault(u => u.Email == "gregmartinez@drdre.com");

			if (newCustomer22 == null)
			{
				newCustomer22 = new AppUser();
				newCustomer22.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer22.UserName = "gregmartinez@drdre.com";
				newCustomer22.Email = "gregmartinez@drdre.com";
				newCustomer22.FirstName = "Gregory";
				newCustomer22.LastName = "Martinez";
				newCustomer22.DOB = "052847";
				newCustomer22.Address = "8295 Sunset Blvd.";
				newCustomer22.City = "Austin";
				newCustomer22.State = "TX";
				newCustomer22.Zip = "78708";
				newCustomer22.PhoneNumber = "5128746718";
				newCustomer22.Miles = 1000;
				newCustomer22.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer22, "snowsnow");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer22 = _db.Users.FirstOrDefault(u => u.UserName == "gregmartinez@drdre.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer22, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer22, "Customer");
			}

			AppUser newCustomer23 = _db.Users.FirstOrDefault(u => u.Email == "cmiller@bob.com");

			if (newCustomer23 == null)
			{
				newCustomer23 = new AppUser();
				newCustomer23.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer23.UserName = "cmiller@bob.com";
				newCustomer23.Email = "cmiller@bob.com";
				newCustomer23.FirstName = "Charles";
				newCustomer23.LastName = "Miller";
				newCustomer23.DOB = "101590";
				newCustomer23.Address = "8962 Main St.";
				newCustomer23.City = "Dallas";
				newCustomer23.State = "TX";
				newCustomer23.Zip = "75215";
				newCustomer23.PhoneNumber = "4697458615";
				newCustomer23.Miles = 2000;
				newCustomer23.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer23, "mydogspot");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer23 = _db.Users.FirstOrDefault(u => u.UserName == "cmiller@bob.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer23, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer23, "Customer");
			}

			AppUser newCustomer24 = _db.Users.FirstOrDefault(u => u.Email == "knelson@aoll.com");

			if (newCustomer24 == null)
			{
				newCustomer24 = new AppUser();
				newCustomer24.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer24.UserName = "knelson@aoll.com";
				newCustomer24.Email = "knelson@aoll.com";
				newCustomer24.FirstName = "Kelly";
				newCustomer24.LastName = "Nelson";
				newCustomer24.DOB = "071371";
				newCustomer24.Address = "2601 Red River";
				newCustomer24.City = "Dallas";
				newCustomer24.State = "TX";
				newCustomer24.Zip = "75252";
				newCustomer24.PhoneNumber = "4692926966";
				newCustomer24.Miles = 0;
				newCustomer24.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer24, "spotmydog");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer24 = _db.Users.FirstOrDefault(u => u.UserName == "knelson@aoll.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer24, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer24, "Customer");
			}

			AppUser newCustomer25 = _db.Users.FirstOrDefault(u => u.Email == "joewin@xfactor.com");

			if (newCustomer25 == null)
			{
				newCustomer25 = new AppUser();
				newCustomer25.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer25.UserName = "joewin@xfactor.com";
				newCustomer25.Email = "joewin@xfactor.com";
				newCustomer25.FirstName = "Joe";
				newCustomer25.LastName = "Nguyen";
				newCustomer25.DOB = "031708";
				newCustomer25.Address = "1249 4th SW St.";
				newCustomer25.City = "Dallas";
				newCustomer25.State = "TX";
				newCustomer25.Zip = "75263";
				newCustomer25.PhoneNumber = "4693125897";
				newCustomer25.Miles = 9000;
				newCustomer25.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer25, "joejoejoe");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer25 = _db.Users.FirstOrDefault(u => u.UserName == "joewin@xfactor.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer25, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer25, "Customer");
			}

			AppUser newCustomer26 = _db.Users.FirstOrDefault(u => u.Email == "orielly@foxnews.cnn");

			if (newCustomer26 == null)
			{
				newCustomer26 = new AppUser();
				newCustomer26.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer26.UserName = "orielly@foxnews.cnn";
				newCustomer26.Email = "orielly@foxnews.cnn";
				newCustomer26.FirstName = "Bill";
				newCustomer26.LastName = "O'Reilly";
				newCustomer26.DOB = "070859";
				newCustomer26.Address = "8800 Gringo Drive";
				newCustomer26.City = "Dallas";
				newCustomer26.State = "TX";
				newCustomer26.Zip = "75263";
				newCustomer26.PhoneNumber = "4693450925";
				newCustomer26.Miles = 5000;
				newCustomer26.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer26, "billyboy");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer26 = _db.Users.FirstOrDefault(u => u.UserName == "orielly@foxnews.cnn");
			}

			if (await _userManager.IsInRoleAsync(newCustomer26, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer26, "Customer");
			}

			AppUser newCustomer27 = _db.Users.FirstOrDefault(u => u.Email == "ankaisrad@gogle.com");

			if (newCustomer27 == null)
			{
				newCustomer27 = new AppUser();
				newCustomer27.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer27.UserName = "ankaisrad@gogle.com";
				newCustomer27.Email = "ankaisrad@gogle.com";
				newCustomer27.FirstName = "Anka";
				newCustomer27.LastName = "Radkovich";
				newCustomer27.DOB = "051966";
				newCustomer27.Address = "1300 Elliott Pl";
				newCustomer27.City = "Houston";
				newCustomer27.State = "TX";
				newCustomer27.Zip = "77010";
				newCustomer27.PhoneNumber = "2812345566";
				newCustomer27.Miles = 0;
				newCustomer27.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer27, "radgirl");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer27 = _db.Users.FirstOrDefault(u => u.UserName == "ankaisrad@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer27, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer27, "Customer");
			}

			AppUser newCustomer28 = _db.Users.FirstOrDefault(u => u.Email == "megrhodes@freserve.co.uk");

			if (newCustomer28 == null)
			{
				newCustomer28 = new AppUser();
				newCustomer28.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer28.UserName = "megrhodes@freserve.co.uk";
				newCustomer28.Email = "megrhodes@freserve.co.uk";
				newCustomer28.FirstName = "Megan";
				newCustomer28.LastName = "Rhodes";
				newCustomer28.DOB = "031265";
				newCustomer28.Address = "4587 Enfield Rd.";
				newCustomer28.City = "Houston";
				newCustomer28.State = "TX";
				newCustomer28.Zip = "77013";
				newCustomer28.PhoneNumber = "2813744746";
				newCustomer28.Miles = 6000;
				newCustomer28.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer28, "meganr34");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer28 = _db.Users.FirstOrDefault(u => u.UserName == "megrhodes@freserve.co.uk");
			}

			if (await _userManager.IsInRoleAsync(newCustomer28, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer28, "Customer");
			}

			AppUser newCustomer29 = _db.Users.FirstOrDefault(u => u.Email == "erynrice@aoll.com");

			if (newCustomer29 == null)
			{
				newCustomer29 = new AppUser();
				newCustomer29.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer29.UserName = "erynrice@aoll.com";
				newCustomer29.Email = "erynrice@aoll.com";
				newCustomer29.FirstName = "Eryn";
				newCustomer29.LastName = "Rice";
				newCustomer29.DOB = "042875";
				newCustomer29.Address = "3405 Rio Grande";
				newCustomer29.City = "Houston";
				newCustomer29.State = "TX";
				newCustomer29.Zip = "77015";
				newCustomer29.PhoneNumber = "2813876657";
				newCustomer29.Miles = 3000;
				newCustomer29.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer29, "ricearoni");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer29 = _db.Users.FirstOrDefault(u => u.UserName == "erynrice@aoll.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer29, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer29, "Customer");
			}

			AppUser newCustomer30 = _db.Users.FirstOrDefault(u => u.Email == "jorge@noclue.com");

			if (newCustomer30 == null)
			{
				newCustomer30 = new AppUser();
				newCustomer30.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer30.UserName = "jorge@noclue.com";
				newCustomer30.Email = "jorge@noclue.com";
				newCustomer30.FirstName = "Jorge";
				newCustomer30.LastName = "Rodriguez";
				newCustomer30.DOB = "120853";
				newCustomer30.Address = "6788 Cotter Street";
				newCustomer30.City = "Houston";
				newCustomer30.State = "TX";
				newCustomer30.Zip = "77000";
				newCustomer30.PhoneNumber = "2818904374";
				newCustomer30.Miles = 5000;
				newCustomer30.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer30, "jrod2017");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer30 = _db.Users.FirstOrDefault(u => u.UserName == "jorge@noclue.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer30, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer30, "Customer");
			}

			AppUser newCustomer31 = _db.Users.FirstOrDefault(u => u.Email == "mrrogers@lovelyday.com");

			if (newCustomer31 == null)
			{
				newCustomer31 = new AppUser();
				newCustomer31.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer31.UserName = "mrrogers@lovelyday.com";
				newCustomer31.Email = "mrrogers@lovelyday.com";
				newCustomer31.FirstName = "Allen";
				newCustomer31.LastName = "Rogers";
				newCustomer31.DOB = "042273";
				newCustomer31.Address = "4965 Oak Hill";
				newCustomer31.City = "Houston";
				newCustomer31.State = "TX";
				newCustomer31.Zip = "77010";
				newCustomer31.PhoneNumber = "2818752943";
				newCustomer31.Miles = 8000;
				newCustomer31.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer31, "rogerthat");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer31 = _db.Users.FirstOrDefault(u => u.UserName == "mrrogers@lovelyday.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer31, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer31, "Customer");
			}

			AppUser newCustomer32 = _db.Users.FirstOrDefault(u => u.Email == "stjean@athome.com");

			if (newCustomer32 == null)
			{
				newCustomer32 = new AppUser();
				newCustomer32.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer32.UserName = "stjean@athome.com";
				newCustomer32.Email = "stjean@athome.com";
				newCustomer32.FirstName = "Olivier";
				newCustomer32.LastName = "Saint-Jean";
				newCustomer32.DOB = "021995";
				newCustomer32.Address = "255 Toncray Dr.";
				newCustomer32.City = "Blacksburg";
				newCustomer32.State = "VA";
				newCustomer32.Zip = "24060";
				newCustomer32.PhoneNumber = "3434145678";
				newCustomer32.Miles = 0;
				newCustomer32.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer32, "bunnyhop");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer32 = _db.Users.FirstOrDefault(u => u.UserName == "stjean@athome.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer32, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer32, "Customer");
			}

			AppUser newCustomer33 = _db.Users.FirstOrDefault(u => u.Email == "saunders@pen.com");

			if (newCustomer33 == null)
			{
				newCustomer33 = new AppUser();
				newCustomer33.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer33.UserName = "saunders@pen.com";
				newCustomer33.Email = "saunders@pen.com";
				newCustomer33.FirstName = "Sarah";
				newCustomer33.LastName = "Saunders";
				newCustomer33.DOB = "021978";
				newCustomer33.Address = "332 Avenue C";
				newCustomer33.City = "El Paso";
				newCustomer33.State = "TX";
				newCustomer33.Zip = "79945";
				newCustomer33.PhoneNumber = "9153497810";
				newCustomer33.Miles = 8000;
				newCustomer33.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer33, "penguin12");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer33 = _db.Users.FirstOrDefault(u => u.UserName == "saunders@pen.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer33, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer33, "Customer");
			}

			AppUser newCustomer34 = _db.Users.FirstOrDefault(u => u.Email == "willsheff@email.com");

			if (newCustomer34 == null)
			{
				newCustomer34 = new AppUser();
				newCustomer34.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer34.UserName = "willsheff@email.com";
				newCustomer34.Email = "willsheff@email.com";
				newCustomer34.FirstName = "William";
				newCustomer34.LastName = "Sewell";
				newCustomer34.DOB = "122314";
				newCustomer34.Address = "2365 51st St.";
				newCustomer34.City = "El Paso";
				newCustomer34.State = "TX";
				newCustomer34.Zip = "79946";
				newCustomer34.PhoneNumber = "9154510084";
				newCustomer34.Miles = 8000;
				newCustomer34.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer34, "alaskaboy");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer34 = _db.Users.FirstOrDefault(u => u.UserName == "willsheff@email.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer34, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer34, "Customer");
			}

			AppUser newCustomer35 = _db.Users.FirstOrDefault(u => u.Email == "sheffiled@gogle.com");

			if (newCustomer35 == null)
			{
				newCustomer35 = new AppUser();
				newCustomer35.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer35.UserName = "sheffiled@gogle.com";
				newCustomer35.Email = "sheffiled@gogle.com";
				newCustomer35.FirstName = "Martin";
				newCustomer35.LastName = "Sheffield";
				newCustomer35.DOB = "050860";
				newCustomer35.Address = "3886 Avenue A";
				newCustomer35.City = "El Paso";
				newCustomer35.State = "TX";
				newCustomer35.Zip = "79950";
				newCustomer35.PhoneNumber = "9155479167";
				newCustomer35.Miles = 0;
				newCustomer35.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer35, "martin1234");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer35 = _db.Users.FirstOrDefault(u => u.UserName == "sheffiled@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer35, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer35, "Customer");
			}

			AppUser newCustomer36 = _db.Users.FirstOrDefault(u => u.Email == "johnsmith187@aoll.com");

			if (newCustomer36 == null)
			{
				newCustomer36 = new AppUser();
				newCustomer36.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer36.UserName = "johnsmith187@aoll.com";
				newCustomer36.Email = "johnsmith187@aoll.com";
				newCustomer36.FirstName = "John";
				newCustomer36.LastName = "Smith";
				newCustomer36.DOB = "062555";
				newCustomer36.Address = "23 Hidden Forge Dr.";
				newCustomer36.City = "Fayetteville";
				newCustomer36.State = "NC";
				newCustomer36.Zip = "28304";
				newCustomer36.PhoneNumber = "2838321888";
				newCustomer36.Miles = 3000;
				newCustomer36.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer36, "smitty444");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer36 = _db.Users.FirstOrDefault(u => u.UserName == "johnsmith187@aoll.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer36, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer36, "Customer");
			}

			AppUser newCustomer37 = _db.Users.FirstOrDefault(u => u.Email == "dustroud@mail.com");

			if (newCustomer37 == null)
			{
				newCustomer37 = new AppUser();
				newCustomer37.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer37.UserName = "dustroud@mail.com";
				newCustomer37.Email = "dustroud@mail.com";
				newCustomer37.FirstName = "Dustin";
				newCustomer37.LastName = "Stroud";
				newCustomer37.DOB = "072667";
				newCustomer37.Address = "1212 Rita Rd";
				newCustomer37.City = "Springfield";
				newCustomer37.State = "IL";
				newCustomer37.Zip = "62707";
				newCustomer37.PhoneNumber = "2172346667";
				newCustomer37.Miles = 6000;
				newCustomer37.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer37, "dustydusty");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer37 = _db.Users.FirstOrDefault(u => u.UserName == "dustroud@mail.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer37, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer37, "Customer");
			}

			AppUser newCustomer38 = _db.Users.FirstOrDefault(u => u.Email == "estuart@mail.net");

			if (newCustomer38 == null)
			{
				newCustomer38 = new AppUser();
				newCustomer38.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer38.UserName = "estuart@mail.net";
				newCustomer38.Email = "estuart@mail.net";
				newCustomer38.FirstName = "Eric";
				newCustomer38.LastName = "Stuart";
				newCustomer38.DOB = "120447";
				newCustomer38.Address = "5576 Toro Ring";
				newCustomer38.City = "Austin";
				newCustomer38.State = "TX";
				newCustomer38.Zip = "78720";
				newCustomer38.PhoneNumber = "5128178335";
				newCustomer38.Miles = 0;
				newCustomer38.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer38, "stewball");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer38 = _db.Users.FirstOrDefault(u => u.UserName == "estuart@mail.net");
			}

			if (await _userManager.IsInRoleAsync(newCustomer38, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer38, "Customer");
			}

			AppUser newCustomer39 = _db.Users.FirstOrDefault(u => u.Email == "peterstump@noclue.com");

			if (newCustomer39 == null)
			{
				newCustomer39 = new AppUser();
				newCustomer39.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer39.UserName = "peterstump@noclue.com";
				newCustomer39.Email = "peterstump@noclue.com";
				newCustomer39.FirstName = "Peter";
				newCustomer39.LastName = "Stump";
				newCustomer39.DOB = "071074";
				newCustomer39.Address = "1300 Kellen Circle";
				newCustomer39.City = "Austin";
				newCustomer39.State = "TX";
				newCustomer39.Zip = "78721";
				newCustomer39.PhoneNumber = "5124560903";
				newCustomer39.Miles = 2000;
				newCustomer39.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer39, "slowwind");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer39 = _db.Users.FirstOrDefault(u => u.UserName == "peterstump@noclue.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer39, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer39, "Customer");
			}

			AppUser newCustomer40 = _db.Users.FirstOrDefault(u => u.Email == "jtanner@mustang.net");

			if (newCustomer40 == null)
			{
				newCustomer40 = new AppUser();
				newCustomer40.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer40.UserName = "jtanner@mustang.net";
				newCustomer40.Email = "jtanner@mustang.net";
				newCustomer40.FirstName = "Jeremy";
				newCustomer40.LastName = "Tanner";
				newCustomer40.DOB = "011144";
				newCustomer40.Address = "4347 Almstead";
				newCustomer40.City = "Austin";
				newCustomer40.State = "TX";
				newCustomer40.Zip = "78735";
				newCustomer40.PhoneNumber = "5124590929";
				newCustomer40.Miles = 5000;
				newCustomer40.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer40, "tanner5454");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer40 = _db.Users.FirstOrDefault(u => u.UserName == "jtanner@mustang.net");
			}

			if (await _userManager.IsInRoleAsync(newCustomer40, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer40, "Customer");
			}

			AppUser newCustomer41 = _db.Users.FirstOrDefault(u => u.Email == "taylordjay@aoll.com");

			if (newCustomer41 == null)
			{
				newCustomer41 = new AppUser();
				newCustomer41.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer41.UserName = "taylordjay@aoll.com";
				newCustomer41.Email = "taylordjay@aoll.com";
				newCustomer41.FirstName = "Allison";
				newCustomer41.LastName = "Taylor";
				newCustomer41.DOB = "111490";
				newCustomer41.Address = "467 Nueces St.";
				newCustomer41.City = "Austin";
				newCustomer41.State = "TX";
				newCustomer41.Zip = "78710";
				newCustomer41.PhoneNumber = "5124748452";
				newCustomer41.Miles = 0;
				newCustomer41.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer41, "allyrally");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer41 = _db.Users.FirstOrDefault(u => u.UserName == "taylordjay@aoll.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer41, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer41, "Customer");
			}

			AppUser newCustomer42 = _db.Users.FirstOrDefault(u => u.Email == "rtaylor@gogle.com");

			if (newCustomer42 == null)
			{
				newCustomer42 = new AppUser();
				newCustomer42.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer42.UserName = "rtaylor@gogle.com";
				newCustomer42.Email = "rtaylor@gogle.com";
				newCustomer42.FirstName = "Rachel";
				newCustomer42.LastName = "Taylor";
				newCustomer42.DOB = "011876";
				newCustomer42.Address = "345 Longview Dr.";
				newCustomer42.City = "Dallas";
				newCustomer42.State = "TX";
				newCustomer42.Zip = "75001";
				newCustomer42.PhoneNumber = "4694907631";
				newCustomer42.Miles = 10000;
				newCustomer42.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer42, "taylorbaylor");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer42 = _db.Users.FirstOrDefault(u => u.UserName == "rtaylor@gogle.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer42, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer42, "Customer");
			}

			AppUser newCustomer43 = _db.Users.FirstOrDefault(u => u.Email == "teefrank@noclue.com");

			if (newCustomer43 == null)
			{
				newCustomer43 = new AppUser();
				newCustomer43.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer43.UserName = "teefrank@noclue.com";
				newCustomer43.Email = "teefrank@noclue.com";
				newCustomer43.FirstName = "Frank";
				newCustomer43.LastName = "Tee";
				newCustomer43.DOB = "090698";
				newCustomer43.Address = "5590 Lavell Dr";
				newCustomer43.City = "Dallas";
				newCustomer43.State = "TX";
				newCustomer43.Zip = "75063";
				newCustomer43.PhoneNumber = "4698765543";
				newCustomer43.Miles = 0;
				newCustomer43.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer43, "teeoff22");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer43 = _db.Users.FirstOrDefault(u => u.UserName == "teefrank@noclue.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer43, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer43, "Customer");
			}

			AppUser newCustomer44 = _db.Users.FirstOrDefault(u => u.Email == "ctucker@alphabet.co.uk");

			if (newCustomer44 == null)
			{
				newCustomer44 = new AppUser();
				newCustomer44.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer44.UserName = "ctucker@alphabet.co.uk";
				newCustomer44.Email = "ctucker@alphabet.co.uk";
				newCustomer44.FirstName = "Clent";
				newCustomer44.LastName = "Tucker";
				newCustomer44.DOB = "022543";
				newCustomer44.Address = "312 Main St.";
				newCustomer44.City = "Dallas";
				newCustomer44.State = "TX";
				newCustomer44.Zip = "75206";
				newCustomer44.PhoneNumber = "4698471154";
				newCustomer44.Miles = 7000;
				newCustomer44.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer44, "tucksack1");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer44 = _db.Users.FirstOrDefault(u => u.UserName == "ctucker@alphabet.co.uk");
			}

			if (await _userManager.IsInRoleAsync(newCustomer44, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer44, "Customer");
			}

			AppUser newCustomer45 = _db.Users.FirstOrDefault(u => u.Email == "avelasco@yoho.com");

			if (newCustomer45 == null)
			{
				newCustomer45 = new AppUser();
				newCustomer45.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer45.UserName = "avelasco@yoho.com";
				newCustomer45.Email = "avelasco@yoho.com";
				newCustomer45.FirstName = "Allen";
				newCustomer45.LastName = "Velasco";
				newCustomer45.DOB = "091085";
				newCustomer45.Address = "679 W. 4th";
				newCustomer45.City = "Dallas";
				newCustomer45.State = "TX";
				newCustomer45.Zip = "75215";
				newCustomer45.PhoneNumber = "4693985638";
				newCustomer45.Miles = 8000;
				newCustomer45.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer45, "meow88");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer45 = _db.Users.FirstOrDefault(u => u.UserName == "avelasco@yoho.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer45, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer45, "Customer");
			}

			AppUser newCustomer46 = _db.Users.FirstOrDefault(u => u.Email == "vinovino@grapes.com");

			if (newCustomer46 == null)
			{
				newCustomer46 = new AppUser();
				newCustomer46.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer46.UserName = "vinovino@grapes.com";
				newCustomer46.Email = "vinovino@grapes.com";
				newCustomer46.FirstName = "Janet";
				newCustomer46.LastName = "Vino";
				newCustomer46.DOB = "020785";
				newCustomer46.Address = "189 Grape Road";
				newCustomer46.City = "Houston";
				newCustomer46.State = "TX";
				newCustomer46.Zip = "77010";
				newCustomer46.PhoneNumber = "2815643832";
				newCustomer46.Miles = 0;
				newCustomer46.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer46, "vinovino");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer46 = _db.Users.FirstOrDefault(u => u.UserName == "vinovino@grapes.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer46, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer46, "Customer");
			}

			AppUser newCustomer47 = _db.Users.FirstOrDefault(u => u.Email == "westj@pioneer.net");

			if (newCustomer47 == null)
			{
				newCustomer47 = new AppUser();
				newCustomer47.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer47.UserName = "westj@pioneer.net";
				newCustomer47.Email = "westj@pioneer.net";
				newCustomer47.FirstName = "Jake";
				newCustomer47.LastName = "West";
				newCustomer47.DOB = "010976";
				newCustomer47.Address = "RR 3287";
				newCustomer47.City = "Houston";
				newCustomer47.State = "TX";
				newCustomer47.Zip = "77025";
				newCustomer47.PhoneNumber = "2818475244";
				newCustomer47.Miles = 8000;
				newCustomer47.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer47, "gowest");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer47 = _db.Users.FirstOrDefault(u => u.UserName == "westj@pioneer.net");
			}

			if (await _userManager.IsInRoleAsync(newCustomer47, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer47, "Customer");
			}

			AppUser newCustomer48 = _db.Users.FirstOrDefault(u => u.Email == "winner@hootmail.com");

			if (newCustomer48 == null)
			{
				newCustomer48 = new AppUser();
				newCustomer48.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer48.UserName = "winner@hootmail.com";
				newCustomer48.Email = "winner@hootmail.com";
				newCustomer48.FirstName = "Louis";
				newCustomer48.LastName = "Winthorpe";
				newCustomer48.DOB = "041953";
				newCustomer48.Address = "2500 Padre Blvd";
				newCustomer48.City = "Houston";
				newCustomer48.State = "TX";
				newCustomer48.Zip = "77010";
				newCustomer48.PhoneNumber = "2815650098";
				newCustomer48.Miles = 6000;
				newCustomer48.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer48, "louielouie");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer48 = _db.Users.FirstOrDefault(u => u.UserName == "winner@hootmail.com");
			}

			if (await _userManager.IsInRoleAsync(newCustomer48, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer48, "Customer");
			}

			AppUser newCustomer49 = _db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net");

			if (newCustomer49 == null)
			{
				newCustomer49 = new AppUser();
				newCustomer49.AdvantageNum = Utilities.GenerateNextAdvantageNumber.GetNextAdvantageNumber(_db);
				newCustomer49.UserName = "rwood@voyager.net";
				newCustomer49.Email = "rwood@voyager.net";
				newCustomer49.FirstName = "Reagan";
				newCustomer49.LastName = "Wood";
				newCustomer49.DOB = "122802";
				newCustomer49.Address = "447 Westlake Dr.";
				newCustomer49.City = "Houston";
				newCustomer49.State = "TX";
				newCustomer49.Zip = "77010";
				newCustomer49.PhoneNumber = "2814545242";
				newCustomer49.Miles = 0;
				newCustomer49.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newCustomer49, "woodyman1");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCustomer49 = _db.Users.FirstOrDefault(u => u.UserName == "rwood@voyager.net");
			}

			if (await _userManager.IsInRoleAsync(newCustomer49, "Customer") == false)
			{
				await _userManager.AddToRoleAsync(newCustomer49, "Customer");
			}

            // FIRST CREW
            AppUser newCrew = _db.Users.FirstOrDefault(u => u.Email == "b.ingram@longhornairlines.neet");

            //if admin hasn't been created, then add them
            if (newCrew == null)
            {
                newCrew = new AppUser();
                //UserID
                newCrew.UserName = "b.ingram@longhornairlines.neet";
                //Password
                //SSN
                newCrew.Email = "b.ingram@longhornairlines.neet";
                newCrew.FirstName = "Brad";
                newCrew.LastName = "Ingram";
				newCrew.DOB = "";
				newCrew.Address = "6548 La Posada Ct.";
                newCrew.City = "Dallas";
                newCrew.State = "TX";
                newCrew.Zip = "75209";
                newCrew.PhoneNumber = "4694678821"; // From Identity
                newCrew.empType = (EmpType)1; 

                //Add additional fields that you created on the AppUser class

                //NOTE: This creates the user - "Abc123!" is the password for this user
                var result = await _userManager.CreateAsync(newCrew, "ingram45");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                newCrew = _db.Users.FirstOrDefault(u => u.UserName == "b.ingram@longhornairlines.neet");
            }

            //Add the new user we just created to the Admin role
            if (await _userManager.IsInRoleAsync(newCrew, "Crew") == false)
            {
                await _userManager.AddToRoleAsync(newCrew, "Crew");
            }

			AppUser newCrew0 = _db.Users.FirstOrDefault(u => u.Email == "m.nguyen@longhornairlines.neet");

			if (newCrew0 == null)
			{
				newCrew0 = new AppUser();
				newCrew0.UserName = "m.nguyen@longhornairlines.neet";
				newCrew0.Email = "m.nguyen@longhornairlines.neet";
				newCrew0.FirstName = "Mary";
				newCrew0.LastName = "Nguyen";
				newCrew0.DOB = "";
				newCrew0.Address = "465 N. Bear Cub";
				newCrew0.City = "Dallas";
				newCrew0.State = "TX";
				newCrew0.Zip = "75001";
				newCrew0.PhoneNumber = "4695524141";
				newCrew0.empType = (EmpType)1;


				var result = await _userManager.CreateAsync(newCrew0, "landus");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew0 = _db.Users.FirstOrDefault(u => u.UserName == "m.nguyen@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew0, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew0, "Crew");
			}

			AppUser newCrew1 = _db.Users.FirstOrDefault(u => u.Email == "h.garcia@longhornairlines.neet");

			if (newCrew1 == null)
			{
				newCrew1 = new AppUser();
				newCrew1.UserName = "h.garcia@longhornairlines.neet";
				newCrew1.Email = "h.garcia@longhornairlines.neet";
				newCrew1.FirstName = "Hector";
				newCrew1.LastName = "Garcia";
				newCrew1.DOB = "";
				newCrew1.Address = "777 PBR Drive";
				newCrew1.City = "Houston";
				newCrew1.State = "TX";
				newCrew1.Zip = "77012";
				newCrew1.PhoneNumber = "2811114444";
				newCrew1.empType = (EmpType)1;


				var result = await _userManager.CreateAsync(newCrew1, "instrument");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew1 = _db.Users.FirstOrDefault(u => u.UserName == "h.garcia@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew1, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew1, "Crew");
			}

			AppUser newCrew2 = _db.Users.FirstOrDefault(u => u.Email == "b.larson@longhornairlines.neet");

			if (newCrew2 == null)
			{
				newCrew2 = new AppUser();
				newCrew2.UserName = "b.larson@longhornairlines.neet";
				newCrew2.Email = "b.larson@longhornairlines.neet";
				newCrew2.FirstName = "Bill";
				newCrew2.LastName = "Larson";
				newCrew2.DOB = "";
				newCrew2.Address = "1212 N. First Ave";
				newCrew2.City = "Houston";
				newCrew2.State = "TX";
				newCrew2.Zip = "77025";
				newCrew2.PhoneNumber = "2815554444";
				newCrew2.empType = (EmpType)1;


				var result = await _userManager.CreateAsync(newCrew2, "approval");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew2 = _db.Users.FirstOrDefault(u => u.UserName == "b.larson@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew2, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew2, "Crew");
			}

			AppUser newCrew3 = _db.Users.FirstOrDefault(u => u.Email == "g.martinez@longhornairlines.neet");

			if (newCrew3 == null)
			{
				newCrew3 = new AppUser();
				newCrew3.UserName = "g.martinez@longhornairlines.neet";
				newCrew3.Email = "g.martinez@longhornairlines.neet";
				newCrew3.FirstName = "Gregory";
				newCrew3.LastName = "Martinez";
				newCrew3.DOB = "";
				newCrew3.Address = "8295 Sunset Blvd.";
				newCrew3.City = "Austin";
				newCrew3.State = "TX";
				newCrew3.Zip = "78653";
				newCrew3.PhoneNumber = "5128746718";
				newCrew3.empType = (EmpType)2;


				var result = await _userManager.CreateAsync(newCrew3, "fungus");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew3 = _db.Users.FirstOrDefault(u => u.UserName == "g.martinez@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew3, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew3, "Crew");
			}

			AppUser newCrew4 = _db.Users.FirstOrDefault(u => u.Email == "j.jackson@longhornairlines.neet");

			if (newCrew4 == null)
			{
				newCrew4 = new AppUser();
				newCrew4.UserName = "j.jackson@longhornairlines.neet";
				newCrew4.Email = "j.jackson@longhornairlines.neet";
				newCrew4.FirstName = "Jack";
				newCrew4.LastName = "Jackson";
				newCrew4.DOB = "";
				newCrew4.Address = "222 Main";
				newCrew4.City = "Houston";
				newCrew4.State = "TX";
				newCrew4.Zip = "77004";
				newCrew4.PhoneNumber = "2815554545";
				newCrew4.empType = (EmpType)2;


				var result = await _userManager.CreateAsync(newCrew4, "offbeat");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew4 = _db.Users.FirstOrDefault(u => u.UserName == "j.jackson@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew4, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew4, "Crew");
			}

			AppUser newCrew5 = _db.Users.FirstOrDefault(u => u.Email == "l.jones@longhornairlines.neet");

			if (newCrew5 == null)
			{
				newCrew5 = new AppUser();
				newCrew5.UserName = "l.jones@longhornairlines.neet";
				newCrew5.Email = "l.jones@longhornairlines.neet";
				newCrew5.FirstName = "Lester";
				newCrew5.LastName = "Jones";
				newCrew5.DOB = "";
				newCrew5.Address = "999 LeBlat";
				newCrew5.City = "Houston";
				newCrew5.State = "TX";
				newCrew5.Zip = "77011";
				newCrew5.PhoneNumber = "2816662222";
				newCrew5.empType = (EmpType)2;


				var result = await _userManager.CreateAsync(newCrew5, "kindly");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew5 = _db.Users.FirstOrDefault(u => u.UserName == "l.jones@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew5, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew5, "Crew");
			}

			AppUser newCrew6 = _db.Users.FirstOrDefault(u => u.Email == "m.lopez@longhornairlines.neet");

			if (newCrew6 == null)
			{
				newCrew6 = new AppUser();
				newCrew6.UserName = "m.lopez@longhornairlines.neet";
				newCrew6.Email = "m.lopez@longhornairlines.neet";
				newCrew6.FirstName = "Marshall";
				newCrew6.LastName = "Lopez";
				newCrew6.DOB = "";
				newCrew6.Address = "90 SW North St";
				newCrew6.City = "Austin";
				newCrew6.State = "TX";
				newCrew6.Zip = "78719";
				newCrew6.PhoneNumber = "5124442222";
				newCrew6.empType = (EmpType)2;


				var result = await _userManager.CreateAsync(newCrew6, "median");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew6 = _db.Users.FirstOrDefault(u => u.UserName == "m.lopez@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew6, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew6, "Crew");
			}

			AppUser newCrew7 = _db.Users.FirstOrDefault(u => u.Email == "m.rhodes@longhornairlines.neet");

			if (newCrew7 == null)
			{
				newCrew7 = new AppUser();
				newCrew7.UserName = "m.rhodes@longhornairlines.neet";
				newCrew7.Email = "m.rhodes@longhornairlines.neet";
				newCrew7.FirstName = "Megan";
				newCrew7.LastName = "Rhodes";
				newCrew7.DOB = "";
				newCrew7.Address = "4587 Enfield Rd.";
				newCrew7.City = "Dallas";
				newCrew7.State = "TX";
				newCrew7.Zip = "75039";
				newCrew7.PhoneNumber = "4693744746";
				newCrew7.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newCrew7, "countryrhodes");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew7 = _db.Users.FirstOrDefault(u => u.UserName == "m.rhodes@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew7, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew7, "Crew");
			}

			AppUser newCrew8 = _db.Users.FirstOrDefault(u => u.Email == "c.baker@longhornairlines.neet");

			if (newCrew8 == null)
			{
				newCrew8 = new AppUser();
				newCrew8.UserName = "c.baker@longhornairlines.neet";
				newCrew8.Email = "c.baker@longhornairlines.neet";
				newCrew8.FirstName = "Christopher";
				newCrew8.LastName = "Baker";
				newCrew8.DOB = "";
				newCrew8.Address = "1245 Lake Anchorage Blvd.";
				newCrew8.City = "Austin";
				newCrew8.State = "TX";
				newCrew8.Zip = "78710";
				newCrew8.PhoneNumber = "5125571146";
				newCrew8.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newCrew8, "hecktour");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew8 = _db.Users.FirstOrDefault(u => u.UserName == "c.baker@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew8, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew8, "Crew");
			}

			AppUser newCrew9 = _db.Users.FirstOrDefault(u => u.Email == "j.mason@longhornairlines.neet");

			if (newCrew9 == null)
			{
				newCrew9 = new AppUser();
				newCrew9.UserName = "j.mason@longhornairlines.neet";
				newCrew9.Email = "j.mason@longhornairlines.neet";
				newCrew9.FirstName = "Jack";
				newCrew9.LastName = "Mason";
				newCrew9.DOB = "";
				newCrew9.Address = "444 45th St";
				newCrew9.City = "Houston";
				newCrew9.State = "TX";
				newCrew9.Zip = "77012";
				newCrew9.PhoneNumber = "2818833432";
				newCrew9.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newCrew9, "changalang");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew9 = _db.Users.FirstOrDefault(u => u.UserName == "j.mason@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew9, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew9, "Crew");
			}

			AppUser newCrew10 = _db.Users.FirstOrDefault(u => u.Email == "s.barnes@longhornairlines.neet");

			if (newCrew10 == null)
			{
				newCrew10 = new AppUser();
				newCrew10.UserName = "s.barnes@longhornairlines.neet";
				newCrew10.Email = "s.barnes@longhornairlines.neet";
				newCrew10.FirstName = "Susan";
				newCrew10.LastName = "Barnes";
				newCrew10.DOB = "";
				newCrew10.Address = "888 S. Main";
				newCrew10.City = "Houston";
				newCrew10.State = "TX";
				newCrew10.Zip = "77010";
				newCrew10.PhoneNumber = "2816662323";
				newCrew10.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newCrew10, "rhythm");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew10 = _db.Users.FirstOrDefault(u => u.UserName == "s.barnes@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew10, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew10, "Crew");
			}

			AppUser newCrew11 = _db.Users.FirstOrDefault(u => u.Email == "c.silva@longhornairlines.neet");

			if (newCrew11 == null)
			{
				newCrew11 = new AppUser();
				newCrew11.UserName = "c.silva@longhornairlines.neet";
				newCrew11.Email = "c.silva@longhornairlines.neet";
				newCrew11.FirstName = "Cindy";
				newCrew11.LastName = "Silva";
				newCrew11.DOB = "";
				newCrew11.Address = "900 4th St";
				newCrew11.City = "Austin";
				newCrew11.State = "TX";
				newCrew11.Zip = "78718";
				newCrew11.PhoneNumber = "5121113333";
				newCrew11.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newCrew11, "arched");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew11 = _db.Users.FirstOrDefault(u => u.UserName == "c.silva@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew11, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew11, "Crew");
			}

			AppUser newCrew12 = _db.Users.FirstOrDefault(u => u.Email == "s.rankin@longhornairlines.neet");

			if (newCrew12 == null)
			{
				newCrew12 = new AppUser();
				newCrew12.UserName = "s.rankin@longhornairlines.neet";
				newCrew12.Email = "s.rankin@longhornairlines.neet";
				newCrew12.FirstName = "Suzie";
				newCrew12.LastName = "Rankin";
				newCrew12.DOB = "";
				newCrew12.Address = "23 Polar Bear Road";
				newCrew12.City = "Dallas";
				newCrew12.State = "TX";
				newCrew12.Zip = "75088";
				newCrew12.PhoneNumber = "4693336666";
				newCrew12.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newCrew12, "decorate");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newCrew12 = _db.Users.FirstOrDefault(u => u.UserName == "s.rankin@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newCrew12, "Crew") == false)
			{
				await _userManager.AddToRoleAsync(newCrew12, "Crew");
			}

			// FIRST TICKET AGENT
			AppUser newTA = _db.Users.FirstOrDefault(u => u.Email == "t.jacobs@longhornairlines.neet");

            //if admin hasn't been created, then add them
            if (newTA == null)
            {
                newTA = new AppUser();
                //UserID
                newTA.UserName = "t.jacobs@longhornairlines.neet";
                //Password
                //SSN
                newTA.Email = "t.jacobs@longhornairlines.neet";
                newTA.FirstName = "Todd";
                newTA.LastName = "Jacobs";
				newTA.DOB = "";
				newTA.Address = "4564 Elm St.";
                newTA.City = "Dallas";
                newTA.State = "TX";
                newTA.Zip = "75032";
                newTA.PhoneNumber = "4694653365"; // From Identity
                newTA.empType = (EmpType)0;

                //Add additional fields that you created on the AppUser class

                //NOTE: This creates the user - "Abc123!" is the password for this user
                var result = await _userManager.CreateAsync(newTA, "society");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                newTA = _db.Users.FirstOrDefault(u => u.UserName == "t.jacobs@longhornairlines.neet");
            }

            //Add the new user we just created to the Admin role
            if (await _userManager.IsInRoleAsync(newTA, "TicketAgent") == false)
            {
                await _userManager.AddToRoleAsync(newTA, "TicketAgent");
            }

			AppUser newTA0 = _db.Users.FirstOrDefault(u => u.Email == "a.taylor@longhornairlines.neet");

			if (newTA0 == null)
			{
				newTA0 = new AppUser();
				newTA0.UserName = "a.taylor@longhornairlines.neet";
				newTA0.Email = "a.taylor@longhornairlines.neet";
				newTA0.FirstName = "Allison";
				newTA0.LastName = "Taylor";
				newTA0.DOB = "";
				newTA0.Address = "467 Nueces St.";
				newTA0.City = "Dallas";
				newTA0.State = "TX";
				newTA0.Zip = "75206";
				newTA0.PhoneNumber = "4694748452";
				newTA0.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA0, "nostalgic");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA0 = _db.Users.FirstOrDefault(u => u.UserName == "a.taylor@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA0, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA0, "TicketAgent");
			}

			AppUser newTA1 = _db.Users.FirstOrDefault(u => u.Email == "m.sheffield@longhornairlines.neet");

			if (newTA1 == null)
			{
				newTA1 = new AppUser();
				newTA1.UserName = "m.sheffield@longhornairlines.neet";
				newTA1.Email = "m.sheffield@longhornairlines.neet";
				newTA1.FirstName = "Martin";
				newTA1.LastName = "Sheffield";
				newTA1.DOB = "";
				newTA1.Address = "3886 Avenue A";
				newTA1.City = "Dallas";
				newTA1.State = "TX";
				newTA1.Zip = "75032";
				newTA1.PhoneNumber = "4695479167";
				newTA1.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA1, "longhorns");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA1 = _db.Users.FirstOrDefault(u => u.UserName == "m.sheffield@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA1, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA1, "TicketAgent");
			}

			AppUser newTA2 = _db.Users.FirstOrDefault(u => u.Email == "j.macleod@longhornairlines.neet");

			if (newTA2 == null)
			{
				newTA2 = new AppUser();
				newTA2.UserName = "j.macleod@longhornairlines.neet";
				newTA2.Email = "j.macleod@longhornairlines.neet";
				newTA2.FirstName = "Jennifer";
				newTA2.LastName = "MacLeod";
				newTA2.DOB = "";
				newTA2.Address = "2504 Far West Blvd.";
				newTA2.City = "Houston";
				newTA2.State = "TX";
				newTA2.Zip = "77001";
				newTA2.PhoneNumber = "2814748138";
				newTA2.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA2, "smitty");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA2 = _db.Users.FirstOrDefault(u => u.UserName == "j.macleod@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA2, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA2, "TicketAgent");
			}

			AppUser newTA3 = _db.Users.FirstOrDefault(u => u.Email == "j.tanner@longhornairlines.neet");

			if (newTA3 == null)
			{
				newTA3 = new AppUser();
				newTA3.UserName = "j.tanner@longhornairlines.neet";
				newTA3.Email = "j.tanner@longhornairlines.neet";
				newTA3.FirstName = "Jeremy";
				newTA3.LastName = "Tanner";
				newTA3.DOB = "";
				newTA3.Address = "4347 Almstead";
				newTA3.City = "Austin";
				newTA3.State = "TX";
				newTA3.Zip = "78705";
				newTA3.PhoneNumber = "5124590929";
				newTA3.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA3, "tanman");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA3 = _db.Users.FirstOrDefault(u => u.UserName == "j.tanner@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA3, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA3, "TicketAgent");
			}

			AppUser newTA4 = _db.Users.FirstOrDefault(u => u.Email == "e.stuart@longhornairlines.neet");

			if (newTA4 == null)
			{
				newTA4 = new AppUser();
				newTA4.UserName = "e.stuart@longhornairlines.neet";
				newTA4.Email = "e.stuart@longhornairlines.neet";
				newTA4.FirstName = "Eric";
				newTA4.LastName = "Stuart";
				newTA4.DOB = "";
				newTA4.Address = "5576 Toro Ring";
				newTA4.City = "Austin";
				newTA4.State = "TX";
				newTA4.Zip = "78710";
				newTA4.PhoneNumber = "5128178335";
				newTA4.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA4, "stewboy");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA4 = _db.Users.FirstOrDefault(u => u.UserName == "e.stuart@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA4, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA4, "TicketAgent");
			}

			AppUser newTA5 = _db.Users.FirstOrDefault(u => u.Email == "c.miller@longhornairlines.neet");

			if (newTA5 == null)
			{
				newTA5 = new AppUser();
				newTA5.UserName = "c.miller@longhornairlines.neet";
				newTA5.Email = "c.miller@longhornairlines.neet";
				newTA5.FirstName = "Charles";
				newTA5.LastName = "Miller";
				newTA5.DOB = "";
				newTA5.Address = "8962 Main St.";
				newTA5.City = "El Paso";
				newTA5.State = "TX";
				newTA5.Zip = "79901";
				newTA5.PhoneNumber = "9157458615";
				newTA5.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA5, "squirrel");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA5 = _db.Users.FirstOrDefault(u => u.UserName == "c.miller@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA5, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA5, "TicketAgent");
			}

			AppUser newTA6 = _db.Users.FirstOrDefault(u => u.Email == "v.lawrence@longhornairlines.neet");

			if (newTA6 == null)
			{
				newTA6 = new AppUser();
				newTA6.UserName = "v.lawrence@longhornairlines.neet";
				newTA6.Email = "v.lawrence@longhornairlines.neet";
				newTA6.FirstName = "Victoria";
				newTA6.LastName = "Lawrence";
				newTA6.DOB = "";
				newTA6.Address = "6639 Butterfly Ln.";
				newTA6.City = "Houston";
				newTA6.State = "TX";
				newTA6.Zip = "77003";
				newTA6.PhoneNumber = "2819457399";
				newTA6.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA6, "lottery");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA6 = _db.Users.FirstOrDefault(u => u.UserName == "v.lawrence@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA6, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA6, "TicketAgent");
			}

			AppUser newTA7 = _db.Users.FirstOrDefault(u => u.Email == "e.markham@longhornairlines.neet");

			if (newTA7 == null)
			{
				newTA7 = new AppUser();
				newTA7.UserName = "e.markham@longhornairlines.neet";
				newTA7.Email = "e.markham@longhornairlines.neet";
				newTA7.FirstName = "Elizabeth";
				newTA7.LastName = "Markham";
				newTA7.DOB = "";
				newTA7.Address = "7861 Chevy Chase";
				newTA7.City = "Austin";
				newTA7.State = "TX";
				newTA7.Zip = "78712";
				newTA7.PhoneNumber = "5124579845";
				newTA7.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA7, "monty3");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA7 = _db.Users.FirstOrDefault(u => u.UserName == "e.markham@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA7, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA7, "TicketAgent");
			}

			AppUser newTA8 = _db.Users.FirstOrDefault(u => u.Email == "s.saunders@longhornairlines.neet");

			if (newTA8 == null)
			{
				newTA8 = new AppUser();
				newTA8.UserName = "s.saunders@longhornairlines.neet";
				newTA8.Email = "s.saunders@longhornairlines.neet";
				newTA8.FirstName = "Sarah";
				newTA8.LastName = "Saunders";
				newTA8.DOB = "";
				newTA8.Address = "332 Avenue C";
				newTA8.City = "Austin";
				newTA8.State = "TX";
				newTA8.Zip = "78613";
				newTA8.PhoneNumber = "5123497810";
				newTA8.empType = (EmpType)0;


				var result = await _userManager.CreateAsync(newTA8, "rankmary");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newTA8 = _db.Users.FirstOrDefault(u => u.UserName == "s.saunders@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newTA8, "TicketAgent") == false)
			{
				await _userManager.AddToRoleAsync(newTA8, "TicketAgent");
			}

			// FIRST MANAGEMENT
			AppUser newMan = _db.Users.FirstOrDefault(u => u.Email == "e.rice@longhornairlines.neet");

            //if admin hasn't been created, then add them
            if (newMan == null)
            {
                newMan = new AppUser();
                //UserID
                newMan.UserName = "e.rice@longhornairlines.neet";
				//Password
				//SSN
				newMan.Email = "e.rice@longhornairlines.neet";
				newMan.FirstName = "Eryn";
				newMan.LastName = "Rice";
				newMan.DOB = "";
				newMan.Address = "3405 Rio Grande";
				newMan.City = "Dallas";
				newMan.State = "TX";
				newMan.Zip = "75043";
				newMan.PhoneNumber = "4693876657"; // From Identity
				newMan.empType = (EmpType)0;

                //Add additional fields that you created on the AppUser class

                //NOTE: This creates the user - "Abc123!" is the password for this user
                var result = await _userManager.CreateAsync(newMan, "ricearoni");
                if (result.Succeeded == false)
                {
                    throw new Exception("This user can't be added - " + result.ToString());
                }
                _db.SaveChanges();
                newMan = _db.Users.FirstOrDefault(u => u.UserName == "e.rice@longhornairlines.neet");
            }

            //Add the new user we just created to the Admin role
            if (await _userManager.IsInRoleAsync(newMan, "Management") == false)
            {
                await _userManager.AddToRoleAsync(newMan, "Management");
            }

			AppUser newMan0 = _db.Users.FirstOrDefault(u => u.Email == "r.taylor@longhornairlines.neet");

			if (newMan0 == null)
			{
				newMan0 = new AppUser();
				newMan0.UserName = "r.taylor@longhornairlines.neet";
				newMan0.Email = "r.taylor@longhornairlines.neet";
				newMan0.FirstName = "Rachel";
				newMan0.LastName = "Taylor";
				newMan0.DOB = "";
				newMan0.Address = "345 Longview Dr.";
				newMan0.City = "Houston";
				newMan0.State = "TX";
				newMan0.Zip = "77002";
				newMan0.PhoneNumber = "2814512631";
				newMan0.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newMan0, "swansong");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newMan0 = _db.Users.FirstOrDefault(u => u.UserName == "r.taylor@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newMan0, "Management") == false)
			{
				await _userManager.AddToRoleAsync(newMan0, "Management");
			}

			AppUser newMan1 = _db.Users.FirstOrDefault(u => u.Email == "a.rogers@longhornairlines.neet");

			if (newMan1 == null)
			{
				newMan1 = new AppUser();
				newMan1.UserName = "a.rogers@longhornairlines.neet";
				newMan1.Email = "a.rogers@longhornairlines.neet";
				newMan1.FirstName = "Allen";
				newMan1.LastName = "Rogers";
				newMan1.DOB = "";
				newMan1.Address = "4965 Oak Hill";
				newMan1.City = "Dallas";
				newMan1.State = "TX";
				newMan1.Zip = "75043";
				newMan1.PhoneNumber = "4698752943";
				newMan1.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newMan1, "evanescent");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newMan1 = _db.Users.FirstOrDefault(u => u.UserName == "a.rogers@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newMan1, "Management") == false)
			{
				await _userManager.AddToRoleAsync(newMan1, "Management");
			}

			AppUser newMan2 = _db.Users.FirstOrDefault(u => u.Email == "w.sewell@longhornairlines.neet");

			if (newMan2 == null)
			{
				newMan2 = new AppUser();
				newMan2.UserName = "w.sewell@longhornairlines.neet";
				newMan2.Email = "w.sewell@longhornairlines.neet";
				newMan2.FirstName = "William";
				newMan2.LastName = "Sewell";
				newMan2.DOB = "";
				newMan2.Address = "2365 51st St.";
				newMan2.City = "Austin";
				newMan2.State = "TX";
				newMan2.Zip = "78705";
				newMan2.PhoneNumber = "5124510084";
				newMan2.empType = (EmpType)3;


				var result = await _userManager.CreateAsync(newMan2, "walkamile");
				if (result.Succeeded == false)
				{
					throw new Exception("This user cannot be added - " + result.ToString());
				}
				_db.SaveChanges();
				newMan2 = _db.Users.FirstOrDefault(u => u.UserName == "w.sewell@longhornairlines.neet");
			}

			if (await _userManager.IsInRoleAsync(newMan2, "Management") == false)
			{
				await _userManager.AddToRoleAsync(newMan2, "Management");
			}

			//save changes
			_db.SaveChanges();
        }

    }
}