using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;
using RestSharpDemo.Utilities;


namespace RestSharpDemo.Tests
{
    [TestFixture]
    public class Tests
    {
        private RestClient _restClient;
        private RestRequest _restRequest;

        [SetUp]
        public void SetUp()
        {
            _restClient = new RestClient("https://reqres.in/");
        }

        [Test]
        public void simpleGetRequest()
        {
            //Arrange
            _restRequest = new RestRequest("/api/users/{user}",Method.GET);
            _restRequest.AddUrlSegment("user", 2);
            
            //Act
            var restResponse = _restClient.Execute(_restRequest).Content;

            //Assert
            Console.WriteLine("The response is : " + restResponse);
        }

        [Test]
        public void verifyTotalNumberOfRecords()
        {
            _restRequest = new RestRequest("/api/users?page=2",Method.GET);
            var restResponse = _restClient.Execute(_restRequest);
            
            /*var result = Helper.DeserializerResponse(restResponse);
            var finalOutput = result["total"];
            Console.WriteLine("the Deserialized value is : " + finalOutput);*/

            var result = Helper.DeserializeResponseUsingJObject(restResponse, "total");
            Console.WriteLine("the Deserialized value is : " + result);

            Assert.That(result.ToString(),Is.EqualTo("12"));
        }

        [Test]
        public void GetRequestWithAuthentication()
        {
            _restClient.Authenticator = new HttpBasicAuthenticator("eve.holt@reqres.in","cityslicka");
            _restRequest = new RestRequest("api/login",Method.GET);

            var response = _restClient.Execute(_restRequest);

            Console.WriteLine("the content is : " + response.Content);
            Console.WriteLine("Status is : " + response.StatusCode);
            
            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));
            
            Assert.That((int)response.StatusCode,Is.EqualTo(200));
        }

        [TearDown]
        public void Close()
        {
            Console.WriteLine("All the tests have been executed");
        }

    }
}