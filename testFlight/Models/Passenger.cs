
using System.Xml.Serialization;

namespace testFlight.Models
{
    public class Passenger
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string? Patronymic { get; set; }

        public string FIO => $"{Surname} {Name} {Patronymic}";

        [XmlIgnore]
        public Flight Flight { get; set; }
    }
}
