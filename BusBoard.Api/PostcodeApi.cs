﻿using System;
using System.Data;
using System.Net;
using RestSharp;

namespace BusBoard.Api {
    public class PostcodeApi {
        RestClient Client = new RestClient("http://api.postcodes.io");

        public Coords GetCoordsIfExists(string postcode) {
            var request = new RestRequest("postcodes/{postcode}", Method.GET);
            request.AddUrlSegment("postcode", postcode);
            var result = Client.Execute<PostcodeResults>(request);
            if (result.StatusCode != HttpStatusCode.OK) {
                return null;
            }
            return result.Data.Result;
        }
    }
}