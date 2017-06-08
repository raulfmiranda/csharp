using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Weather4U
{
    public class WeatherBox
    {
        public async static Task<RootObject> GetWeather(string city)
        {
            string baseUrl = "http://api.openweathermap.org/data/2.5/weather?q=";
            string appid = "&appid=7a5e5a9bf8edc47e4495899a55ebd6bb";
            string jsonSource = baseUrl + city + appid; 
            // string jsonSource = "http://api.openweathermap.org/data/2.5/weather?q=Fortaleza&appid=7a5e5a9bf8edc47e4495899a55ebd6bb";
            var http = new HttpClient();
            var response = await http.GetAsync(jsonSource);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);

            return data;
        }
    }

    [DataContract]
    public class Coord
    {
        [DataMember]
        public double lon { get; set; }
        [DataMember]
        public double lat { get; set; }
    }

    [DataContract]
    public class Weather
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string main { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string icon { get; set; }
    }

    [DataContract]
    public class Main
    {
        [DataMember]
        public double temp { get; set; }
        [DataMember]
        public int pressure { get; set; }
        [DataMember]
        public int humidity { get; set; }
        [DataMember]
        public double temp_min { get; set; }
        [DataMember]
        public double temp_max { get; set; }
    }

    [DataContract]
    public class Wind
    {
        [DataMember]
        public double speed { get; set; }
        [DataMember]
        public int deg { get; set; }
    }

    [DataContract]
    public class Clouds
    {
        [DataMember]
        public int all { get; set; }
    }

    [DataContract]
    public class Sys
    {
        [DataMember]
        public int type { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public double message { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public int sunrise { get; set; }
        [DataMember]
        public int sunset { get; set; }
    }

    [DataContract]
    public class RootObject
    {        
        [DataMember]
        public Coord coord { get; set; }
        [DataMember]
        public List<Weather> weather { get; set; }
        [DataMember]
        public string @base { get; set; }
        [DataMember]
        public Main main { get; set; }
        [DataMember]
        public int visibility { get; set; }
        [DataMember]
        public Wind wind { get; set; }
        [DataMember]
        public Clouds clouds { get; set; }
        [DataMember]
        public int dt { get; set; }
        [DataMember]
        public Sys sys { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int cod { get; set; }

        public DateTime dateTime { get; set; }

        public string dateTimeStr { get { return dateTime.ToString(); } }

        public string nameCountry
        {
            get { return this.name + " - " + sys.country; }
        }

        public BitmapImage iconImage
        {
            get
            {
                string imagePath = "ms-appx:///Assets/" + weather[0].icon + ".png";
                Uri uri = new Uri(imagePath, UriKind.RelativeOrAbsolute);
                return new BitmapImage(uri);
            }
        }

        public string mainDescription
        {
            get { return weather[0].main + ": " + weather[0].description; }
        }

        public string temp
        {
            get
            {
                string tempStr = main.temp + "";
                double kelvin = double.Parse(tempStr);
                return kelvin + " K ( " + (kelvin - 273.15) + " ºC )";
            }
        }

        public string tempMin
        {
            get
            {
                string tempStr = main.temp_min + "";
                double kelvin = double.Parse(tempStr);
                return kelvin + " K ( " + (kelvin - 273.15) + " ºC )";
            }
        }

        public string tempMax
        {
            get
            {
                string tempStr = main.temp_max + "";
                double kelvin = double.Parse(tempStr);
                return kelvin + " K ( " + (kelvin - 273.15) + " ºC )";
            }
        }
        
    }
}
