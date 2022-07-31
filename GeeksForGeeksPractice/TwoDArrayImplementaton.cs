using System;
using System.Collections.Generic;
using System.Text;

namespace GeeksForGeeksPractice
{
    public class TwoDArrayImplementaton
    {

        public void PrintTwoDArray()
        {
            Console.WriteLine("Please Enter the Row of Two D Array");
            int R = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the Column of Two D Array");
            int C = Int32.Parse(Console.ReadLine());

            int[,] userInputArray = new int[R,C];
            int value = 0;

             for(int i=0; i<R; i++)
            {
                for(int j=0; j<C; j++)
                {
                
                    userInputArray[i, j] = value;
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, userInputArray[i, j]);
                    value++;
                }
                

            } 

        }
    }
}
