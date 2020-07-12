using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppBot.DataAccess.Interfaces
{
    public interface ICityRepository
    {
        Task<int> GetCityId(string cityName);
    }
}
