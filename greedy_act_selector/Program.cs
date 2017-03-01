using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greedy_act_selector
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int start_time;
            int finish_time;
            Console.WriteLine("enter number of Activities :");
            int number = Convert.ToInt16(Console.ReadLine());
            ActSelector act = new ActSelector(number);
            for (int y = 0; y < number; y++)
            {
                Console.WriteLine("enter name of activity : ");
                name = Console.ReadLine();
                Console.WriteLine("enter the start time : ");
                start_time = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("enter the finish time : ");
                finish_time = Convert.ToInt16(Console.ReadLine());
                Activity a = new Activity(name, start_time, finish_time);
                act.listof_act[y] = a;
            }
            List<Activity> list = act.greedy_selector(act.listof_act);

            foreach (Activity a in list)
            {
                Console.WriteLine(a.name + "prograam");
            }

            Console.ReadLine();
        }
    }
}
