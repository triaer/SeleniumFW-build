using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFW.SeleniumCore.DriverManagement
{
    public abstract class DriverManager
    {
        private readonly Dictionary<string, IWebDriver> _drivers = new Dictionary<string, IWebDriver>();
        private readonly Dictionary<string, DriverProperties> _properties = new Dictionary<string, DriverProperties>();

        public DriverManager ()
        {

        }

        /// <summary>
        /// Set drivers properties
        /// </summary>
        /// 
        /// <param name="key"></param>
        /// <param name="properties"></param>
        public void SetDriversProperties(string key, DriverProperties properties)
        {
            _properties.Add(key, properties);
        }

        /// <summary>
        /// Get drivers properties
        /// </summary>
        /// 
        /// <param name="key"></param>
        public DriverProperties GetDriversProperties(string key)
        {
            return _properties[key];
        }

        /// <summary>
        /// Keep web driver instance by key
        /// </summary>
        public void SetWebDriver(string key, IWebDriver driver)
        {
            _drivers.Add(key, driver);
        }

        /// <summary>
        /// Get web driver instance by key
        /// </summary>
        /// 
        /// <param name="key"></param>
        public IWebDriver GetWebDriver(string key)
        {
            return _drivers[key];
        }

        public abstract void CreateDriver(string key, string downloadLocation = null);
    }
}
