using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greedy_act_selector
{
    class ActSelector
    {
        private int next_act , prev_act;
        public int activitynum;
        public Activity[] listof_act;
        public List<Activity> B = new List<Activity>();

        public ActSelector(int size)
        {
            listof_act = new Activity[size];
            //B = new Activity[size];
            activitynum = size;
        }

        public ActSelector()
        { }

        public List<Activity> greedy_selector(Activity[] listofact)
        {
            

            HeapSort(listofact);
            
            List<Activity> final_list = new List<Activity>();
            final_list.Add(listofact[0]);
            prev_act = 0;
            for(int i = 1;i < listofact.Length; i++)
            {
                next_act = i;

                if (listofact[next_act].start_time >= listofact[prev_act].finish_time)
                {
                    final_list.Add(listofact[next_act]);
                    prev_act = next_act;
                }
            }
            return final_list;
        }


        void CreateMaxHeap(Activity[] listof_act)
        {
            activitynum = listof_act.Length;
            //Console.WriteLine(activitynum);
            for (int i = (activitynum / 2); i >= 0; i--)
            {
                MaxHeapify(listof_act, i);
            }
            
        }

        void MaxHeapify(Activity[] listof_act, int index)
        {
            var left = 2 * index+1;
            var right = 2 * index + 2;
            int smallest ;
            
            

            if (left < activitynum && listof_act[left].finish_time > listof_act[index].finish_time)
            {
                smallest = left;
            }
            else
            {
                smallest = index;
            }

            if (right < activitynum && listof_act[right].finish_time > listof_act[smallest].finish_time)
            {
                smallest = right;

            }
            
            

            if (smallest != index)
            {
                Swap(smallest, index, listof_act);
                MaxHeapify(listof_act, smallest);
            }
        }

        public void HeapSort(Activity[] listof_act)
        {
            CreateMaxHeap(listof_act);
            //Console.WriteLine(activitynum);
            for (int i = activitynum - 1; i >= 1; i--)
            {
                Swap(0, i, listof_act);
                activitynum--;
                MaxHeapify(listof_act, 0);
            }
        }

        public void Swap(int smallest, int index, Activity[] listof_act)
        {
            Activity temp = listof_act[smallest];
            listof_act[smallest] = listof_act[index];
            listof_act[index] = temp;

        }




    }
}
