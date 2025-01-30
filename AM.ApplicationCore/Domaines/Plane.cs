using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaine
{
    //method 1 : creation of en enum
    //method 2 : create an enum under directory domain
    public enum PlaneType
    {
        Boeing,Airbus
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId {  get; set; }
        public PlaneType PlaneType { get; set; }
    }
}
