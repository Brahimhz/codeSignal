using System;

namespace codeSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isLucky(261534));

           /* foreach(int item in (sortByHeight(new int[] { -1, 150, 190, 170, -1, -1, 160, 180 })))
                Console.WriteLine(item);*/



            Console.ReadLine();
        }

        private static int[] sortByHeight(int[] a)
        {
            int changePoint = 0;

            for (int i = 0; i < a.Length ; i++)
                if (a[i] == -1)
                    continue;
                else
                    for(int j=i+1; j < a.Length; j++)
                        if (a[j] == -1)
                            continue;
                        else
                            if(a[i] > a[j])
                            {
                                changePoint = a[i];
                                a[i] = a[j];
                                a[j] = changePoint;
                            }

            return a;
        }

        private static bool isLucky(int n)
        {
            double sum1=0,sum2=0;

            for (int i=0,j= n.ToString().Length -1; i< (n.ToString().Length /2) && j >= (n.ToString().Length / 2); i++ , j--)
            {
               
                sum1 += (double)((n.ToString().ToCharArray())[i]);
                sum2 += (double)((n.ToString().ToCharArray())[j]);

            }
            if (sum1 == sum2)
                return true;
            else
                return false;
        }
    }
}
