using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace codeSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(isLucky(261534));

            /* foreach(int item in (sortByHeight(new int[] { -1, 150, 190, 170, -1, -1, 160, 180 })))
                 Console.WriteLine(item);*/

            /* Console.WriteLine(reverseInParentheses("foo(bar)baz(blim)")); */

            Console.ReadLine();
        }

        private static string[] addBorder(string[] picture)
        {

            string[] pictureWithBorder = new string[picture.Length + 2];
            pictureWithBorder[0] = "";
            pictureWithBorder[(picture.Length + 2) - 1] = "";

            for (int i = 0; i < (picture[0].Length + 2); i++)
            {
                pictureWithBorder[0] += "*";
                pictureWithBorder[(picture.Length + 2) - 1] += "*";
            }

            for (int j = 0; j < picture.Length; j++)
                pictureWithBorder[j + 1] = "*" + picture[j] + "*";


            return pictureWithBorder;

        }
        private static int[] alternatingSums(int[] a)
        {

            int someTeam1 = 0, someTeam2 = 0;

            for (int i = 0; i < a.Length; i++)
                if (i % 2 == 0)
                    someTeam1 += a[i];
                else
                    someTeam2 += a[i];


            return new int[] { someTeam1, someTeam2 };

        }

        private static String reverseInParentheses(string inputString)
        {

            while (inputString.Contains("("))
            {
                int i = inputString.LastIndexOf("(");
                var s = new string(inputString.Skip(i + 1).TakeWhile(x => x != ')').Reverse().ToArray());
                var t = "(" + new string(s.Reverse().ToArray()) + ")";
                Console.WriteLine("S = {0}",s);
                Console.WriteLine("T = {0}",t);
                inputString = inputString.Replace(t, s);
                Console.WriteLine("inputString = {0}", inputString);

            }

            return inputString;
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
