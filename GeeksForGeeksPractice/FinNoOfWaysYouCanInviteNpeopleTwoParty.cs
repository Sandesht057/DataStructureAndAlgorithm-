
using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class FinNoOfWaysYouCanInviteNpeopleTwoParty
    {
        //you have to invite people in pair or single

        public int FindWaysToInvitePeople(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            int waysOne = FindWaysToInvitePeople(n - 1);
            int waystwo = FindWaysToInvitePeople(n - 2) * (n - 1);
            return waysOne + waystwo;
        }
    }
}
