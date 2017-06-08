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

        public bool delWeather(RootObject weather)
        {
            for(int i = 0; i < weathers.Count; i++)
            {
                if(weathers[i].id == weather.id)
                {
                    weathers.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
