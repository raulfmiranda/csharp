using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaViewer
{
    public class WikipediaMapProxy
    {
        public async static Task<RootObject> GetResult(string searchedString)
        {
            string jsonSource = "https://en.wikipedia.org/w/api.php?format=json&action=query&generator=search&gsrnamespace=0&gsrlimit=2&prop=pageimages|extracts&pilimit=max&exintro&explaintext&exsentences=1&exlimit=max&gsrsearch=gandhi&origin=*";
            var http = new HttpClient();
            var response = await http.GetAsync(jsonSource);
            var result = response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(RootObject));

            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result.Result));
            var data = (RootObject) serializer.ReadObject(ms);
                        
            return data;
        }
    }

    [DataContract]
    public class Thumbnail
    {
        [DataMember]
        public string source { get; set; }
        [DataMember]
        public int width { get; set; }
        [DataMember]
        public int height { get; set; }
    }

    [DataContract]
    public class Item
    {
        [DataMember]
        public int pageid { get; set; }
        [DataMember]
        public int ns { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public int index { get; set; }
        [DataMember]
        public Thumbnail thumbnail { get; set; }
        [DataMember]
        public string pageimage { get; set; }
        [DataMember]
        public string extract { get; set; }
    }

    [DataContract]
    public class Pages
    {
        [DataMember]
        public List<Item>  item { get; set; }
    }

    [DataContract]
    public class Query
    {
        [DataMember]
        public Pages pages { get; set; }
    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public Query query { get; set; }
    }
}
