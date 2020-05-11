namespace RestSharpDemo.Model
{
    //Request payload
    public class RegisterUserRequest
    {
        public string name { get; set; }
        public string salary { get; set; }
        public string age { get; set; }
        public string id { get; set; }
    }

    //Response payload
    public class RegisterUserResponse
    {
        public string status { get; set; }
        public RegisterUserRequest data { get; set; }
    }
        
}