using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WeatherAppBot.Entities.Models
{
    [DataContract]
    public class WeatherResponse
    {
        [DataMember]
        public IList<Weather> Weather { get; set; }
        [DataMember]
        public Main Main { get; set; }
        [DataMember]
        public Wind Wind { get; set; }
        [DataMember]
        public Sys Sys { get; set; }
       // public Image ImageDownloaded { get; set; }
    }
}
