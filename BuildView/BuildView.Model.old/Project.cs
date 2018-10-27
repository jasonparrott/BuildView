using System;
using System.Collections.Generic;
using System.Text;

namespace BuildView.Model
{
    public class Project
    {
        private String name;
        private String url;

        public string Url { get => url; set => url = value; }
        public string Name { get => name; set => name = value; }
    }
}
