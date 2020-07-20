using System.Runtime.Serialization;

namespace WeatherAppBot.Entities.Models
{
    [DataContract]
    public class Wind
    {
        [DataMember]
        public double Speed { get; set; }
    }
}
