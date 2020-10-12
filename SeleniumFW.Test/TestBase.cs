using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFW.Test
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }

        protected string browser;
        protected string mode;
        protected string configPath;

        [TestInitialize]
        public void TestInitialize()
        {
            browser = TestContext.Properties["browser"].ToString();
            mode = TestContext.Properties["mode"].ToString();
            configPath = TestContext.Properties["configPath"].ToString();


        }
    }
}
