using BuildView.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuildView.Jenkins
{
    public class JenkinsConnector
    {
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

        
    }
}
