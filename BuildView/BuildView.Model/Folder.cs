﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildView.Model
{
    public class Folder : Job
    {
        private List<Job> jobs;

        public List<Job> Jobs { get => jobs; set => jobs = value; }
    }
}
