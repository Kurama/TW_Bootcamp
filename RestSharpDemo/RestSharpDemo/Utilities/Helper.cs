using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Serialization.Json;

namespace RestSharpDemo.Utilities
{
    public static class Helper
    {
        public static Dictionary<string, string> DeserializerResponse(this IRestResponse restResponse)
        {
            var jsonObj = new JsonDeserializer().Deserialize<Dictionary<string, string>>(restResponse);
            return jsonObj;
        }

        public static string DeserializeResponseUsingJObject(this IRestResponse restResponse,string responseObj)
        {
            var jObj = JObject.Parse(restResponse.Content);
            return jObj[responseObj]?.ToString();
        }            
    }
}