using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather4U
{
    class WeatherController
    {
        public ObservableCollection<RootObject> weathers { get; set; }
        

        public WeatherController()
        {
            weathers = new ObservableCollection<RootObject>();
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

        public async void updateWeather(RootObject weather)
        {
            RootObject newWeather = null;
            try
            {
                for (int i = 0; i < weathers.Count; i++)
                {
                    if (weathers[i].id == weather.id)
                    {
                        newWeather = await WeatherBox.GetWeather(weather.name);
                        weathers[i] = newWeather;
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}
