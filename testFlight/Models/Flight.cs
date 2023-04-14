using System;
using System.Collections.Generic;

namespace testFlight.Models
{
    public class Flight
    {
        public int Number { get; set; }

        public DateTime DepartureTime { get; set; }

        public List<Passenger> Passengers { get; set; }

        public Flight()
        {            
            Passengers =  new List<Passenger>();           
        }

        public void UpdatePassengers()
        {
            foreach (var p in Passengers)
            {
                p.Flight ??= this;
            }
        }
    }
}
