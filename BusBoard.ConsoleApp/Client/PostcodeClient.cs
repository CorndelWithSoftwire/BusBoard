using System;
using System.Net;
using BusBoard.ConsoleApp.Models.Postcode;
using RestSharp;

namespace BusBoard.ConsoleApp.Client
{
    public class PostcodeClient
    {
        private RestClient _client;

        public PostcodeClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _client = new RestClient("https://api.postcodes.io");
        }
        
        public PostcodeData GetPostcodeData(string postcode)
        {
            var request = new RestRequest(
                String.Format("postcodes/{0}", postcode)
            );
            var response = _client.Get<PostcodeLookupResponse>(request);
            return response.Data.Result;
        }
    }
}