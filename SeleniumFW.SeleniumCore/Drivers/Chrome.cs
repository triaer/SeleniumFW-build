using OpenQA.Selenium.Chrome;
using SeleniumFW.SeleniumCore.DriverManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFW.SeleniumCore.Drivers
{
    public class Chrome : DriverManager
    {
        public override void CreateDriver(string key, string downloadLocation = null)
        {
            var props = GetDriversProperties(key);
        }
    }
}
