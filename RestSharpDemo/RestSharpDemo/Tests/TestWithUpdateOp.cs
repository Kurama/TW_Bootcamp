using System;
using NUnit.Framework;
using RestSharp;
using RestSharpDemo.Utilities;

namespace RestSharpDemo.Tests
{
    [TestFixture]
    public class TestWithUpdateOp
    {
        private RestClient _restClient;
        private RestRequest _restRequest;
        
        [SetUp]
        public void SetUp()
        {
            _restClient = new RestClient("https://reqres.in/");
        }

        [Test]
        public void TestPutOperation()
        {
            _restRequest = new RestRequest("api/users/2",Method.PUT);
            _restRequest.AddJsonBody(new
            {
                name= "morpheus",
                job= "zion resident"
            });

            var restResponse = _restClient.Execute(_restRequest);
            var response = restResponse.DeserializeResponseUsingJObject("job");
            
            Assert.That(response,Is.EqualTo("zion resident"));
        }

        [Test]
        public void TestPatchOperation()
        {
            _restRequest = new RestRequest("api/users/2",Method.PATCH);
            _restRequest.AddJsonBody(new {name= "morpheus", job = "Analyst"});
            var restResponse = _restClient.Execute(_restRequest);
            var response = restResponse.DeserializeResponseUsingJObject("job");
            
            Assert.AreEqual(response,"Analyst");
        }
        
    }
}