// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Domaines;
using AM.ApplicationCore.Services;

//Plane P = new Plane();
//P.Capacity = 50;
//P.PlaneType = PlaneType.Boeing;
//P.ManufactureDate = DateTime.Now;
//Console.WriteLine(P.ToString());
///////////////////////////////////////////////////////////


////Flight flight = TestData.flight1;

//Console.WriteLine(TestData.flight1);


//Passenger passenger1 = new Passenger();
//Console.WriteLine(passenger1.ckeckProfile("safa", "azizi"));
//Staff staff1 = new Staff();
//Traveller traveller1 = new Traveller();
//passenger1.PassengerType;
//List<Flight> test = TestData.listFlights;
FlightMethod flightMethod1 = new FlightMethod();
//List<Flight> results = flightMethod1.GetFlights("date", "2022-01-01 15:10:10");
//if (results.Count == 0)
//{
//    Console.WriteLine("Aucun vol trouvé.");
//}
//foreach (Flight result in results)
//{
//    Console.WriteLine($"Flight to {result.Destination} at {result.FlightDate}");
//}
//List<DateTime> dates = flightMethod1.GetDates("Paris");

//foreach (var date in dates)
//{
//    Console.WriteLine(date);
//}

//10.
//List<Flight> res =flightMethod1.ShowFlightDetails(TestData.Airbusplane);
//foreach (Flight r in res)
//{ 
//Console.WriteLine($"destination: {r.Destination} , date: {r.FlightDate}");
//}


//int res1=flightMethod1.ProgrammedFlightNumber(DateTime.Parse("2022-01-01 15:10:10"));
//Console.WriteLine($"le nbr de vols est: {res1}");
Console.WriteLine(flightMethod1.DurationAverage("Paris"));
flightMethod1.ShowFlightDetails(TestData.Airbusplane);
Console.WriteLine(flightMethod1.ProgrammedFlightNumber(DateTime.Parse("2022-01-01")));

Console.WriteLine("estimation:" + flightMethod1.DurationAverage("Paris"));
foreach (var f in flightMethod1.OrderedDurationFlights())
{ Console.WriteLine(f.EstimatedDuration);  }
foreach (var f in flightMethod1.SeniorTravellers(TestData.flight1))
{ Console.WriteLine(f.FirstName + "age:" + f.BirthDate); }
Console.WriteLine(flightMethod1.DestinationGroupedFlights());

