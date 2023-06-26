using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice.GreedyApproach
{


    public  class KnapSackProblemGreedy
    {
        public class Item
        {
            public double Profit;
            public double Weight;
            public Item(double _Profit, double _Weight)
            {
                Profit = _Profit;
                Weight = _Weight;
            }
        }

        class cprCompare : IComparer
        {
            public int Compare(Object x, Object y)
            {
                Item item1 = (Item)x;
                Item item2 = (Item)y;
                double cpr1 = (double)item1.Profit
                              / (double)item1.Weight;
                double cpr2 = (double)item2.Profit
                              / (double)item2.Weight;

                if (cpr1 < cpr2)
                    return 1;

                return cpr1 > cpr2 ? -1 : 0;
            }
        }

        public double FindOutWight(double[] profit, double[] weights,int BagSize)
        {
            Item[] mergedArray = new Item[profit.Length];
            for (int i = 0; i < profit.Length; i++)
            {
                Item obj = new Item(profit[i],weights[i]);
                mergedArray[0] = obj;
            }

            cprCompare cmp = new cprCompare();
            Array.Sort(mergedArray, cmp);

            double totalValue = 0;
            double currentWeigth = 0;

            foreach (var item in mergedArray)
            {
                double remaining = BagSize - currentWeigth;

                if (item.Weight < remaining)
                {
                    totalValue += item.Profit;
                    currentWeigth += item.Weight;
                }
                else
                {
                    if (remaining == 0) break; ;
                    double fraction = remaining / item.Weight;
                    totalValue += fraction * item.Profit;
                    currentWeigth += fraction + item.Weight;
                }
            }
            return totalValue;

        }
    }
}
