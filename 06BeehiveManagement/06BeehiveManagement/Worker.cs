using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06BeehiveManagement
{
    public class Worker
    {
        private string[] fJobsICanDo;
        private string fCurrentJob;
        private bool fIsBusy;
        private int fTotalShiftsRequiredForCurrentJob;
        private int fShiftsDoneOnCurrentJob;
        private string fReport;

        public Worker(string[] jobsICanDo)
        {
            fIsBusy = false; 
            fJobsICanDo = jobsICanDo; // todo but isn't jobsICanDo a reference which is destroyed when the constructor is finished?
            Report = " is idle.";
        }

        public string CurrentJob
        {
            get
            {
                return fCurrentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return fTotalShiftsRequiredForCurrentJob - fShiftsDoneOnCurrentJob;
            }
        }

        public string Report
        {
            get
            {
                if (!fIsBusy)
                    fReport = " is idle.";
                else
                {
                    if (ShiftsLeft == 1)
                        fReport = " will be done with " + fCurrentJob + " after the next shift.";
                    else
                        fReport = " was working on " + fCurrentJob + " this shift, and has " + ShiftsLeft + " shifts left.";
                }

                return fReport;
            }

            private set
            {
                fReport = value;
            }
        }

        public bool TryReceiveJob(string job, int numShiftsRequired)
        {
            if (!fIsBusy)
            {
                if (fJobsICanDo.Any(t => string.Equals(job, t)))
                    StartJob(job, numShiftsRequired);

                return fIsBusy;
            }
            else
                return false;
        }

        public void WorkOneShift()
        {
            fShiftsDoneOnCurrentJob++;
            if (fShiftsDoneOnCurrentJob == fTotalShiftsRequiredForCurrentJob)
                CompleteJob();
        }

        private void StartJob(string job, int numShiftsRequired)
        {
            fIsBusy = true;
            fCurrentJob = job;
            fTotalShiftsRequiredForCurrentJob = numShiftsRequired;
            fShiftsDoneOnCurrentJob = 0;
        }

        private void CompleteJob()
        {
            fIsBusy = false;
            fCurrentJob = string.Empty;
        }
    }
}
