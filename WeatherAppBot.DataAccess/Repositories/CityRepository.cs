using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WeatherAppBot.DataAccess.Interfaces;

namespace WeatherAppBot.DataAccess.Repositories
{
    public class CityRepository : ICityRepository
    {
        AppDbContext _context;
        public CityRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> GetCityId(string cityName)
        {
            int cityId = 0;

            var city = await _context.Cities.FirstOrDefaultAsync(x => x.CityName.Equals(cityName));
            if (city != null)
            {
                cityId = city.CityId;
            }

            return cityId;
        }
    }
}
