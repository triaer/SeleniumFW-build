using SeleniumFW.Helper.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFW.SeleniumCore.DriverManagement
{
    public class DriverProperties
    {
        public DriverProperties(string filePath)
        {
            var jParser = JsonParser.ParseJsonToObject(filePath);
            
        }
    }
}
