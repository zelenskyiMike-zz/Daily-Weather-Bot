using System.Runtime.Serialization;

namespace WeatherAppBot.Entities.Models
{
    [DataContract]
    public class Sys
    {
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public int Sunrise { get; set; }
        [DataMember]
        public int Sunset { get; set; }
    }
}
