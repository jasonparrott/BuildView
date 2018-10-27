using BuildView.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BuildView.Jenkins
{
    public class JenkinsConnector
    {
        private HttpClient httpClient = new HttpClient();

        private readonly String jenkinsUrl;
        private readonly String username;
        private readonly String password;

        public JenkinsConnector(String jenkinsUrl) : this(jenkinsUrl, null, null)
        {
            
        }

        public JenkinsConnector(String jenkinsUrl, String username, String password) :
            this(new HttpClient(), jenkinsUrl, username, password)
        {

        }


        public JenkinsConnector(HttpClient client, String jenkinsUrl, String username, String password)
        {
            this.httpClient = client;
            this.jenkinsUrl = jenkinsUrl;
            this.username = username;
            this.password = password;
        }

        public async Task<JobsModel> GetModel(string path)
        {
            JobsModel model = null;
            HttpResponseMessage response = await httpClient.GetAsync(jenkinsUrl);
            if ( response.IsSuccessStatusCode )
            {
                model = await response.Content.ReadAsAsync<JobsModel>();
            }

            return model;
        }
        
    }
}
