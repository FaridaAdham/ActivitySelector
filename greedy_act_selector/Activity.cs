using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greedy_act_selector
{
    class Activity
    {
        public string name;
        public int start_time , finish_time;

        public Activity(string name, int start_time, int finish_time)
        {
            this.name = name;
            this.start_time = start_time;
            this.finish_time = finish_time;
        }
    }
}
