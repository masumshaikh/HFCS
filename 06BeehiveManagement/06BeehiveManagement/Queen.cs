using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06BeehiveManagement
{
    public class Queen
    {
        private readonly Worker[] fWorkers = new Worker[4];
        private int fCurrentShiftNumber;

        public Queen()
        {
            fWorkers[0] = new Worker(new[] { "Nectar Collecting", "Honey Manufacturing" });
            fWorkers[1] = new Worker(new[] { "Egg Care", "Baby Bee Tutoring" });
            fWorkers[2] = new Worker(new[] { "Hive Maintenance", "Sting Patrol" });
            fWorkers[3] = new Worker(new[] { "Nectar Collecting", "Egg Care", "Hive Maintenance", "Baby Bee Tutoring", "Honey Manufacturing", "Sting Patrol"});
            
            fCurrentShiftNumber = 0;
        }

        public string HiveReport { get; private set; }

        public bool TryAssignJob(string job, int numShiftsRequired)
        {
            bool foundWorker = false;

            int i = 0;
            while (i < fWorkers.Length && !foundWorker)
            {
                foundWorker = fWorkers[i].TryReceiveJob(job, numShiftsRequired);
                i++;
            }

            return foundWorker;
        }

        public void WorkNextShift()
        {
            fCurrentShiftNumber++;
            HiveReport = "Report for Shift #" + fCurrentShiftNumber.ToString() + ":\r\n\n";

            for (int i = 0; i < fWorkers.Length; i++)
            {
                fWorkers[i].WorkOneShift();
                HiveReport += "Bee " + i + " " + fWorkers[i].Report + "\r\n";
            }
        }
    }
}
