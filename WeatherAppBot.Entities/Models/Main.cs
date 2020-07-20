using System.Runtime.Serialization;

namespace WeatherAppBot.Entities.Models
{
    [DataContract]
    public class Main
    {
        [DataMember]
        public double Temp { get; set; }
        [DataMember]
        public double Feels_Like { get; set; }
        [DataMember]
        public int Humidity { get; set; }
    }
}
