using BuildView.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuildView.Jenkins.Tests
{
    class JenkinsConnectorTests
    {
        [Test]
        public void testParseTopLevelConfig()
        {
            string content = ResourceHelper.GetEmbeddedResource("/top_level_projects.json");
            string url = "http://test";

            HttpClient moqClient = HttpClientMoqHelper.CreateHttpClientMoq(url, content);

            JenkinsConnector connector = new JenkinsConnector(moqClient, url, null, null);
            JobsModel modelTask = connector.GetModel("/").Result;
            Assert.AreEqual(modelTask.Jobs.Count, 3);
        }
    }
}
