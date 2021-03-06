using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace Catalog.DigiKey
{
    public static class Utils
    {
        public static FormUrlEncodedContent FormUrlEncodeData(object data) => new FormUrlEncodedContent(JsonConvert.DeserializeObject<Dictionary<string, string>>(JsonConvert.SerializeObject(data)));

        public static StringContent JsonEncodeData(object data) => new StringContent(JsonConvert.SerializeObject(data));
    }

    public static class Extensions
    {
        public static string GetBody(this HttpListenerRequest req)
        {
            using (var sr = new StreamReader(req.InputStream))
            {
                return sr.ReadToEnd();
            }
        }
    }
}