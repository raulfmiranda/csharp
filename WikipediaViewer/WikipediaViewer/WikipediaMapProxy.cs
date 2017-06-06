using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WikipediaViewer
{
    public class WikipediaMapProxy
    {
        public async static Task<RootObject> GetResult(string searchedString)
        {
            // public async static Task<RootObject> GetResult(string searchedString)
            // public async static Task<Dictionary<string, object>> GetResult(string searchedString)
            string jsonSource = "https://en.wikipedia.org/w/api.php?format=json&action=query&generator=search&gsrnamespace=0&gsrlimit=1&prop=pageimages|extracts&pilimit=max&exintro&explaintext&exsentences=1&exlimit=max&gsrsearch=gandhi&origin=*";
            var http = new HttpClient();
            var response = await http.GetAsync(jsonSource);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            // JavaScriptSerializer serializer = new JavaScriptSerializer();

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));
            var data = (RootObject)serializer.ReadObject(ms);
            // Dictionary<string, object> rootDic = serializer.Deserialize<Dictionary<string, object>>(result);

            return data;
            // return rootDic;
        }
    }

    public class Thumbnail
    {
        public string source { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Item
    {
        public int pageid { get; set; }
        public int ns { get; set; }
        public string title { get; set; }
        public int index { get; set; }
        public Thumbnail thumbnail { get; set; }
        public string pageimage { get; set; }
        public string extract { get; set; }
    }
    
    public class Pages
    {
        public Item  item { get; set; }
    }
    
    public class Query
    {
        public Pages pages { get; set; }
    }
    
    public class RootObject
    {
        public Query query { get; set; }
    }
}
