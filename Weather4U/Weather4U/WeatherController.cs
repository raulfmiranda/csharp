using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather4U
{
    class WeatherController
    {
        public List<RootObject> weathers { get; set; }

        public WeatherController()
        {
            weathers = new List<RootObject>();
        }

        public void addWeather(RootObject weather)
        {
            weathers.Add(weather);
        }
    }
}
