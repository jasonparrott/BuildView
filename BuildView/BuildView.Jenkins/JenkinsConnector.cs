using BuildView.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuildView.Jenkins
{
    public class JenkinsConnector
    {
        private static HttpClient httpClient = new HttpClient();

        private readonly String jenkinsUrl;
        private readonly String username;
        private readonly String password;

        public JenkinsConnector(String jenkinsUrl) : this(jenkinsUrl, null, null)
        {
            
        }

        public JenkinsConnector(String jenkinsUrl, String username, String password)
        {
            this.jenkinsUrl = jenkinsUrl;
            this.username = username;
            this.password = password;
        }
        
        public async Task<List<Project>> GetProjects(string path)
        {
            List<Project> projects = null;
            HttpResponseMessage response = await httpClient.GetAsync(jenkinsUrl);
            if ( response.IsSuccessStatusCode )
            {
                projects = await response.Content.ReadAsAsync<List<Project>>();
            }

            return projects;
            

        }
        
    }
}
