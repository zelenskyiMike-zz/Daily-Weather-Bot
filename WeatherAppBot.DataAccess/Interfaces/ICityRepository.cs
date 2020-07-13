using System.Threading.Tasks;

namespace WeatherAppBot.DataAccess.Interfaces
{
    public interface ICityRepository
    {
        Task<int> GetCityId(string cityName);
    }
}
