using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.ArrayProblems
{
    public class SolveMinimumPlatFormProblem
    {


        public int FindMiniMumPlatForm(int[] startTime, int[] departureTime)
        {
            Array.Sort(startTime);
            Array.Sort(departureTime);
            int countArrival=0;
            int countDeparture=0;
            int minimumPlatForm = 1;
            int initialPlatformTaken = 1;

            for (int i = 0; i < startTime.Length; i++)
            {

                if(startTime[countArrival] <= departureTime[countDeparture])
                {
                    minimumPlatForm += 1;
                    countArrival++;
                }
                else if (startTime[countArrival] > departureTime[countDeparture])
                {
                    minimumPlatForm -= 1;
                    countDeparture++;
                }
            }

            if (minimumPlatForm > initialPlatformTaken)
            {
                initialPlatformTaken = minimumPlatForm;
            }

            return initialPlatformTaken;



        }
    }



}
