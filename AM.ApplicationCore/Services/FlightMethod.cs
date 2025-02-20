using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Domaines;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class FlightMethod : IFlightMethod
    {
        List<Flight> flightss = new List<Flight>();

        List<Flight> flights = TestData.listFlights ?? new List<Flight>();

        public List<DateTime> GetFlightDate(string Destination)
        {
            List<DateTime> date = new List<DateTime>();

            for (int i = 0; i < flights.Count; i++)
            {
                if (flights[i].Destination == Destination)
                { date.Add(flights[i].FlightDate); }

            }
            return date;
        }

        public List<Flight> GetFlights(string filterType, string filterValue)
        {
            List<Flight> filtredFlights = new List<Flight>();
            foreach (Flight flight in flights)
            {
                switch (filterType)
                {
                    case "destination":
                        if (flight.Destination.Equals(filterValue))
                        { filtredFlights.Add(flight); }

                        break;
                    case "date":

                        if (DateTime.TryParse(filterValue, out DateTime filterDate))
                        {
                            if (flight.FlightDate == filterDate)

                            { filtredFlights.Add(flight); }
                        }

                        break;

                }
            }

            return filtredFlights;
        }

        public List<DateTime> GetDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            if (flights == null)
            {
                return new List<DateTime>();
            }
            dates = flights
                    .Where(x => x.Destination == destination)
                    .Select(x => x.FlightDate)
                    .ToList();

            return dates;
        }
        //. Afficher les dates et les destinations des vols d’un avion passé en paramètre




        public void ShowFlightDetails(Plane plane)
        {

            //List<Flight> listDatesDest = new List<Flight>();
            //listDatesDest = flights
            //                .Where(f => f.Plane == plane)
            //                .ToList();
            var query = from f in flights
                        where f.Plane == plane
                        select new { f.Destination, f.FlightDate };
            foreach (var flight in query)
            {
                Console.WriteLine("Destination:" + flight.Destination + " flight date:" + flight.FlightDate);
            }

        }
        // 11.retourner le nombre de vols programmés pour une semaine(7jours) à partir d’une date donnée

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            //List<DateTime> seven = new List<DateTime>();
            //for (int i = 0; i < 7; i++)
            //{
            //    seven.Add(startDate.AddDays(i));
            //}
            //int res = flights
            //    .Where(f => seven.Contains(f.FlightDate))
            //    .Count();
            //return res;

            var query = from f in flights
                        where f.FlightDate < startDate.AddDays(7) | f.FlightDate > startDate
                        select f;
            return query.Count();


            //where DateTime.compare(startDate,f.FlightDate) <= 0
            //    && 



        }
        // 12. Retourner la moyenne de durée estimées des vols d’une destination 

        public double DurationAverage(string destination)
        {
            return flights
                         .Where(x => x.Destination == destination)
                         .Select(f => f.EstimatedDuration)
                         .Average();

            



        }

        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from flight in flights
                        orderby flight.EstimatedDuration descending
                        select flight;
            return query;
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from f in flight.Passengers.OfType<Traveller>()
                        orderby f.BirthDate
                        select f;
            return query.Take(3);

        }

        public void DestinationGroupedFlights()
        {
            var query = from f in flights
                        group f by f.Destination;
            foreach (var g in query)
            {
                Console.WriteLine("Destination" + g.Key);
                foreach (var H in g)
                {
                    Console.WriteLine("Decollage" + H.FlightDate);
                }

            }
        }
    }


}
