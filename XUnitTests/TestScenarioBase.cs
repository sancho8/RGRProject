using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Text;
using RGRProject;

namespace XUnitTests
{
    public class TestScenarioBase
    {
        public TestServer CreateServer()
        {
            var webHostBuilder = WebHost.CreateDefaultBuilder();
            webHostBuilder.UseStartup<Startup>();
            var testServer = new TestServer(webHostBuilder);

            return testServer;
        }
    }
}
