using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays
{
    public class ReturnIntArray
    {
        /*
        You have some tasks in your Asana account. For each ith of 
        them you know its deadlinesi, which is the last day by which 
        it should be completed. As you can see in your calendar, today's 
        date is day. Asana labels each task in accordance with its due date:

        If the task is due today or it's already overdue, it is labeled as Today;
        If the task is due within a week but not today - that is, its deadline is 
        somewhere between day + 1 and day + 7 both inclusive - it is labeled as Upcoming;
        All other tasks are labeled as Later;
        Given an array of deadlines and today's date day, your goal is to find 
        the number of tasks with each label type and return it as an array with 
        the format [Today, Upcoming, Later], where Today, Upcoming and Later 
        are the number of tasks that correspond to that label.
        */
        int[] tasksTypes(int[] deadlines, int day)
        {
            int[] taskLabels = new int[3];

            int Today = 0;
            int Upcoming = 0;
            int Later = 0;

            for (int i = 0; i < deadlines.Length; i++)
            {
                if (deadlines[i] == day || deadlines[i] < day)
                    Today = Today + 1;

                else if (deadlines[i] >= day + 1 && deadlines[i] <= day + 7)
                    Upcoming = Upcoming + 1;

                else
                    Later++;
            }

            taskLabels[0] = Today;
            taskLabels[1] = Upcoming;
            taskLabels[2] = Later;

            return taskLabels;
        }

    }
}
