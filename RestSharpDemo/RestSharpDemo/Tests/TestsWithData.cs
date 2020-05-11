using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Serialization.Json;
using RestSharpDemo.Model;
using RestSharpDemo.Utilities;

namespace RestSharpDemo.Tests
{
    
    public class TestWithData
    {
        [TestFixture]
        public class Tests
        {
            private RestClient _restClient;
            private RestRequest _restRequest;
            private const string BaseUrl = "http://api.zippopotam.us/";

            [SetUp]
            public void SetUp()
            {
                _restClient = new RestClient(BaseUrl);
            }
            
            [TestCase("IN", "110001", HttpStatusCode.OK,TestName = "Check status code for IN with pin code 110001")]
            [TestCase("CH", "1001", HttpStatusCode.OK,TestName = "Check the status code for CH with pin code 1001")]
            [TestCase("CA", "A0A", HttpStatusCode.OK,TestName = "Check the status code for CA with pin code A0A")]
            [TestCase("IN", "9999909", HttpStatusCode.NotFound,TestName = "Check status code for IN with pin code 9999909")]
            public void TestPostCallWithData(string countryCode, string pinCode, HttpStatusCode expectedHttpStatusCode)
            {
                //http://api.zippopotam.us/us/90210
                _restRequest = new RestRequest($"{countryCode}/{pinCode}",Method.GET);
                var response = _restClient.Execute(_restRequest);
                
                
                Assert.That(response.StatusCode, Is.EqualTo(expectedHttpStatusCode));
            }
            
            [TestCaseSource("placesTestData")]
            public void TestPostCallWithSource(string countryCode, string pinCode,string placeName)
            {
                //http://api.zippopotam.us/us/90210
                _restRequest = new RestRequest($"{countryCode}/{pinCode}",Method.GET);
                var response = _restClient.Execute(_restRequest);
                var output = new JsonDeserializer().Deserialize<LocationResponse>(response);

                Console.WriteLine(output.Places[0].PlaceName);
                Assert.That(output.Places[0].PlaceName,Is.EqualTo(placeName));
            }

            private static IEnumerable<TestCaseData> placesTestData()
            {
                yield return new TestCaseData("AU","2140","Homebush").SetName("Check the status code for 2140 that has place name as Homebush");
            }
        }

    }
}