using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domaines
{
    public class Passenger
    {   public Passenger() { }
        public DateTime BirthDate { get; set; }
        public string EmailAddress {  get; set; }
        public string FirstName {  get; set; }
        public int Id {  get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }
        public int TelNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"Passenger: {FirstName} {LastName}, Email: {EmailAddress}, Passport: {PassportNumber}, DOB: {BirthDate:yyyy-MM-dd}";
        }
        public bool ckeckProfile(string nom, string prenom)
        { return nom == LastName && prenom == FirstName; }
        public bool ckeckProfile(string nom, string prenom, string email=null)
        { if (email == null) 
            return nom == LastName && prenom == FirstName;
            else return nom == LastName && prenom == FirstName && email == EmailAddress;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i am passenger");
        }

    }
}
