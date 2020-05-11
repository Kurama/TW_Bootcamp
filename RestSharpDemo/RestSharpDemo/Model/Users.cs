using Newtonsoft.Json;

namespace RestSharpDemo.Model
{
    public class Users
    {
        // Request payload
        public string email { get; set; }
        public string password { get; set; }
        
        // Response payload
        public string id { get; set; }
        public string token { get; set; }
    }
}