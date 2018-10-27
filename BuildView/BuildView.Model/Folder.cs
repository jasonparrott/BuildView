using System;
using System.Collections.Generic;
using System.Text;

namespace BuildView.Model
{
    public class Folder : Project
    {
        private List<Project> projects;

        public List<Project> Projects { get => projects; set => projects = value; }
    }
}
