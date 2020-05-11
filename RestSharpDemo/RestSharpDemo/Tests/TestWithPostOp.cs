using System;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Extensions;
using RestSharpDemo.Model;
using RestSharpDemo.Utilities;

namespace RestSharpDemo.Tests
{
    
    public class TestWithPostOp
    {
        [TestFixture]
        public class Tests
        {
            private RestClient _restClient;
            private RestRequest _restRequest;
            private const string BaseUrl = "https://reqres.in/";

            [SetUp]
            public void SetUp()
            {
                _restClient = new RestClient(BaseUrl);
            }

            [Test]
            public void TestWithPostCall()
            {
                _restRequest = new RestRequest("/api/users",Method.POST);
                _restRequest.AddJsonBody(new {name = "morpheus", job = "leader"});
                var response = _restClient.Execute(_restRequest);
                Console.WriteLine(response.Content);

                var outputId = response.DeserializeResponseUsingJObject("id");
                Console.WriteLine("The ID of the newly created user is : " + outputId);

                var rResult = response.DeserializerResponse();
                var output = rResult["name"];

                Assert.That(output, Is.EqualTo("morpheus"));
            }

            [Test]
            public void TestPostAgain()
            {
                _restClient = new RestClient("http://dummy.restapiexample.com/");
                _restRequest = new RestRequest("api/v1/create", Method.POST);
                _restRequest.AddJsonBody(new {name = "Sasuke", salary = "123", age = "23"});

                var response = _restClient.Execute(_restRequest);
                Console.WriteLine(response.Content);
                Console.WriteLine();

                var output = response.DeserializeResponseUsingJObject("data");
                Console.WriteLine(output);
                
                JObject dataFields = JObject.Parse(output);
                var name = dataFields["name"].ToString();
                
                Assert.That(name, Is.EqualTo("Sasuke"));

                //Using extension classes
                _restRequest.AddJsonBody((new RegisterUserRequest() {name = "Sasuke", salary = "123", age = "23"}));
                var newResponse = _restClient.Execute<RegisterUserResponse>(_restRequest);
                Assert.That(newResponse.Data.data.name,Is.EqualTo("Sasuke"));
            }

            [Test]
            public void TestWithTypeClass()
            {
                _restRequest = new RestRequest("/api/register",Method.POST);
                _restRequest.AddJsonBody(new Users() {email = "eve.holt@reqres.in", password = "pistol"});

                var response = _restClient.Execute<Users>(_restRequest);
                Console.WriteLine("The token is : " + response.Data.token);
                Assert.That(response.Data.token, Is.EqualTo("QpwL5tke4Pnpja7X4"));
            }
        }

    }
}