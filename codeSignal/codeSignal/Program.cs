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

            //Console.WriteLine(areSimilar( new int[] { 2 , 3 , 1 }, new int[] { 1 , 3 , 2 }));
            // Console.WriteLine(areSimilarWithouStupidity( new int[] { 2 , 3 , 1 }, new int[] { 1 , 3 , 2 }));

            //Console.WriteLine(arrayChange(new int[] { 1 , 1 ,1 }));

            // Console.WriteLine(palindromeRearranging("abbaba"));

            //Console.WriteLine(areEquallyStrong( 15 , 10 , 10 , 15 ));

            //Console.WriteLine(isIPv4Address("0.0.0.0.0"));

            //Console.WriteLine(avoidObstacles(new int[] { 5, 3, 6, 7, 9 }));

            /*foreach (int[] array in (boxBlur(new int[][] { new int[] { 7 , 4 , 0 , 1 }, new int[] { 5 , 6 , 2 , 2 }, new int[] { 6 , 10 , 7 , 8  } , new int[] { 1 , 4 , 2 , 0 } })))
                foreach( int item in array )
                    Console.WriteLine(item);
                    */

            /*foreach(int[] array in ( minesweeper( new bool[][] {
                                                                    new bool[] { true , false , false },
                                                                    new bool[] { false , true , false },
                                                                    new bool[] { false , false , false }
                                                                }) ) )
            {
                foreach (int item in array)
                    Console.Write(item);

                Console.WriteLine();
            }*/

            /*foreach (int item in ( arrayReplace( new int[] { 1 , 2 , 1 } , 1 , 3 ) ) )
                Console.Write(item);*/

           // Console.WriteLine(evenDigitsOnly(248322));

            Console.ReadLine();
        }

        private static bool evenDigitsOnly(int n)
        {
            return !Array.Exists( n.ToString().Select(p => Convert.ToInt32(p)).ToArray() , p => p%2 !=0 );
        }

        private static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            return inputArray.Select(p => p == elemToReplace ? substitutionElem : p ).ToArray();

        }

        private static int[][] minesweeper(bool[][] matrix)
        {
            int[][] mine = new int[matrix.Length][];

            for( int i = 0 ; i < matrix.Length ; i++ )
            {
                mine[i] = new int[matrix[i].Length] ;
                for (int j = 0; j < matrix[i].Length ; j++ )
                {
                    int sum = 0;

                    try
                    {
                        if (matrix[i - 1][j])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i][j - 1])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i - 1][j - 1])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i - 1][j + 1])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i +1 ][j - 1])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i + 1][j])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i][j + 1])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }
                    try
                    {
                        if (matrix[i + 1][j + 1])
                            sum++;
                    }
                    catch (System.IndexOutOfRangeException e) { }

                    mine[i][j] = sum ;
                }

            }

            return mine;
        }

        private static int[][] boxBlur(int[][] image)
        {
            int[][] result = new int[(image.Length-3)+1][];

            for( int iResult = 0 ; iResult < result.Length ; iResult++ )
            {
                result[iResult] = new int[(image[iResult].Length - 3) + 1];

                for (int jResult = 0; jResult < result[iResult].Length; jResult++)
                {
                    int sum = 0 ;
                    for (int iImage = 0 + iResult; iImage < iResult + 3; iImage++)
                        for (int jImage = 0 + jResult; jImage < jResult + 3; jImage++)
                            sum += image[iImage][jImage];

                    result[iResult][jResult] = sum / 9;
                }
            }



            return result;
        }

        private static int avoidObstacles(int[] inputArray)
        {
            int cpt=3;
            while(!(inputArray.Count(p => p % cpt == 0) == 0))
                cpt++;

            return cpt;
        }

        private static bool isIPv4Address(string inputString)
        {
            foreach (string item in inputString.Split('.'))
                if ( !( int.TryParse(item, out int test) ) || inputString.Split('.').Count(p => p.Equals("0")) == 4 || (test < 0 || test > 255) || inputString.Split('.').Length != 4 )
                     return false;

            return true;
        }

        private static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return (yourLeft == friendsLeft && yourRight == friendsRight) || (friendsLeft == yourRight && friendsRight == yourLeft);
        }

        private static bool palindromeRearranging(string inputString)
        {
            if(inputString.Length<2)
                return true;
            else
            {
                Dictionary<char, int> carc = new Dictionary<char, int>();

                for( int i=0 ; i < inputString.Length ; i++ )
                {
                    try
                    {
                        carc.Add(inputString[i], 1);
                    }
                    catch (ArgumentException)
                    {
                        carc[inputString[i]]++;
                    }
                }

                int cpt = 0;

                foreach (KeyValuePair<char, int> value in carc)
                    if (value.Value == 1)
                        cpt++;
                    else
                        if (value.Value % 2 != 0 || (value.Value % 2 != 0 && carc.Count > 1 && cpt > 1))
                        cpt++;
              
                    if( cpt > 1 )
                        return false;
                    else
                         return true;

            }

        }

        private static int arrayChange(int[] inputArray)
        {
            int cpt=0;

            for (int i = 1; i < inputArray.Length; i++)
                while (inputArray[i-1] >= inputArray[i] )
                {
                    inputArray[i]++;
                    cpt++;
                }
                   
            return cpt;
        }

        private static bool areSimilarWithouStupidity(int[] a, int[] b)
        {
            int counter = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (!b.Contains(a[i]))
                    return false;

                if (a[i] != b[i])
                    counter++;
            }

            if (!a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x)))
                return false;

            return counter == 0 || (counter / 2 == 1 && counter % 2 == 0);
        }

        private static bool areSimilar(int[] a, int[] b)
        {
            if (Enumerable.SequenceEqual(a, b))
                return true;

                for (int i = 0; i < ( b.Length - 1 ); i++)
                    {

                        if (!Array.Exists(b, x => x == a[0]))
                             return false;

                        for(int j=0; j < b.Length; j++ )
                         {
                              if( j > i)
                                {
                                    if (Enumerable.SequenceEqual(a, (b.TakeWhile(x => Array.IndexOf(b, x) < i)).Concat(Enumerable.Concat(new int[] { b[j] }, (b.Skip(i + 1).TakeWhile(x => Array.IndexOf(b, x) < j)).Concat(Enumerable.Concat(new int[] { b[i] }, (b.Skip(j + 1).TakeWhile(x => Array.IndexOf(b, x) < b.Length))))))))
                                         return true;
                                }
                              if(j < i)
                                {
                                    if (Enumerable.SequenceEqual(a, ( (b.TakeWhile(x => Array.IndexOf(b, x) < j)).Concat(Enumerable.Concat(new int[] { b[i] }, (b.Skip(j + 1).TakeWhile(x => Array.IndexOf(b, x) < i)).Concat(Enumerable.Concat(new int[] { b[j] }, (b.Skip(i + 1).TakeWhile(x => Array.IndexOf(b, x) < b.Length)) ))))) ))
                                        return true;
                                }

                         }
                     }


            return false;
        }

        private static string[] addBorder(string[] picture)
        {

            string[] pictureWithBorder = new string[picture.Length + 2];
           

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
