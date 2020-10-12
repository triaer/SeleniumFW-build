using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumFW.Helper.Utilities
{
    public static class JsonParser
    {
        public static JObject ParseJsonToObject(string filePath)
        {
            var reader = new StreamReader(filePath);
            var json = reader.ReadToEnd();
            var jobj = JObject.Parse(json);

            return jobj;
        }
    }
}
