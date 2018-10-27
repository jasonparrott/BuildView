using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildView.Model
{
    public class JobsModel
    {
        private List<Job> jobs;

        public List<Job> Jobs { get => jobs; set => jobs = value; }
    }
}
