using System;
using System.Collections.Generic;
using System.Net;
using BusBoard.ConsoleApp.Models;
using RestSharp;

namespace BusBoard.ConsoleApp.Client
{
    public class TflClient
    {
        private const string AppKey = "4a212c35b632ba9d2f43c5e1fcb7c3e6";
        private RestClient _client;

        public TflClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            _client = new RestClient("https://api.tfl.gov.uk");
        }
        
        public List<ArrivalPrediction> GetArrivalPredictions(string stopCode)
        {
            var request = new RestRequest(
                String.Format("StopPoint/{0}/Arrivals?app_key={1}", stopCode, AppKey)
            );
            var response = _client.Get<List<ArrivalPrediction>>(request);
            return response.Data;
        }
    }
}