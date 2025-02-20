using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Domaines;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightMethod
    {
        List<DateTime> GetFlightDate(string Destination);
        List<Flight> GetFlights(string filterType, string filterValue);
        List<DateTime> GetDates(string destination);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IEnumerable<Flight> OrderedDurationFlights();
        IEnumerable<Traveller> SeniorTravellers(Flight flight);
       void DestinationGroupedFlights();



    }
}
