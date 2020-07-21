using System.Runtime.Serialization;

namespace WeatherAppBot.BusinessLogic.Models
{
    [DataContract]
    public class Wind
    {
        [DataMember]
        public double Speed { get; set; }
    }
}
