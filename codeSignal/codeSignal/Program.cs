using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

            //Console.WriteLine(variableName("__qsd1klQK1S1LD1"));

            //Console.WriteLine(alphabeticShift("crazy"));

            //Console.WriteLine(chessBoardCellColor("A1","A2"));

            //Console.WriteLine(circleOfNumbers(20,18));

            // Console.WriteLine(depositProfit(100,20,170));

            //Console.WriteLine(absoluteValuesSumMinimization(new int[] { -1000000, -10000, -10000, -1000, -100, -10, -1, 0, 1, 10, 100, 1000, 10000, 100000, 1000000 }));

            //Console.WriteLine(stringsRearrangement(new String[] { "aba" , "bbb" , "bab" } ));

            /*foreach( int item in extractEachKth(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3))
                Console.WriteLine(item);*/

            //Console.WriteLine(firstDigit("dqsd5sqdd553qsd533"));

            /*Console.WriteLine(differentSymbolsNaive("qsdsqqsodjq"));*/

            /*Console.WriteLine(arrayMaxConsecutiveSum( new int[] { 2 ,3 , 5 , 1 , 6 } , 2 ));*/

            /*Console.WriteLine(growingPlant(100,10,910));*/

            /*Console.WriteLine(knapsackLight(15,2,20,4,9));*/

            /*Console.WriteLine(longestDigitsPrefix("aa1"));*/

            /*Console.WriteLine(digitDegree(91));*/

            Console.WriteLine(bishopAndPawn("h1","h3"));

            Console.ReadLine();
        }

        private static bool bishopAndPawn(string bishop, string pawn)
        {
            return ( Math.Abs( Convert.ToInt32( bishop[0] ) - Convert.ToInt32( pawn[0] ) ) == Math.Abs(Convert.ToInt32(bishop[1]) - Convert.ToInt32(pawn[1] ) ) ) ;
        }

        private static int digitDegree(int n)
        {
            int cpt = 0;
            while ( ( n / 10 ) > 0 )
            {
                int changeN = 0;
                while ((n / 10) > 0)
                {
                    changeN += n % 10 ;
                    n = n / 10 ;
                }
                n = changeN+n;
                cpt++;
            }

            return cpt;
        }

        private static string longestDigitsPrefix(string inputString)
        {
           return String.Concat(inputString.TakeWhile(p => new Regex("[0-9]").IsMatch(Convert.ToString(p))));
        }

        private static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 > maxW && weight2 > maxW)
                return 0;
            else
                if ((weight1 + weight2) <= maxW)
                    return value1 + value2;
                else
                    if (value1 > value2)
                        if( weight1 <= maxW )
                            return value1;
                        else
                            return value2;
                    else
                        if( weight2 <= maxW )
                            return value2;
                        else
                            return value1;

}

        private static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            if (downSpeed > desiredHeight)
                return 1;

            int cpt = 0, height = downSpeed;
            while(height<desiredHeight)
            {
                height += (upSpeed - downSpeed);
                Console.WriteLine(height);
                cpt++;
            }
            return cpt;
        }

        private static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int max = 0;

            for(int i=0 ; i < inputArray.Length-k; i++ )
            {
                int sum = 0;
                for (int j = i; j < i + k; j++)
                    sum += inputArray[j];
                if (sum > max)
                    max = sum;
            }

            return max;
        }

        private static int differentSymbolsNaive(string s)
        {
            /*Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
                try { dictionary.Add(s[i], 1); } catch (ArgumentException) { }

            return dictionary.Count;*/

            return s.Distinct().Count();

        }

        private static char firstDigit(string inputString)
        {
            return inputString.First(p => new Regex("[0-9]").IsMatch(Convert.ToString(p)));
        }

        private static int[] extractEachKth(int[] inputArray, int k)
        {
            List<int> outPutArray = new List<int>();
            int kk = k-1;
            for (int i = 0 ; i < inputArray.Length; i++ )
            {
                if (i == kk )
                {
                    kk += k;
                    continue;
                }
                else
                    outPutArray.Add(inputArray[i]);
            }

            return outPutArray.ToArray();
        }

        private static bool stringsRearrangement(string[] inputArray)
        {
            int cpt = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (j != i)
                    {
                        char[] cA = inputArray[j].ToCharArray();

                        foreach (char c1 in inputArray[i].ToCharArray())
                        {
                            string cAN = "";
                            bool exist = false;
                            foreach (char c2 in cA)
                            {
                                if (!exist)
                                {
                                    if (c2.Equals(c1))
                                    {
                                        exist = true;
                                        continue;
                                    }
                                    else { cAN += c2; }
                                }
                                else
                                {
                                    cAN += c2;
                                }

                            }

                            if (cAN.Length == 1)
                            {
                                Console.WriteLine("i={0} , j={1} , inputArray[i]={2} , inputArray[j]={3}  ", i , j , inputArray[i], inputArray[j] );
                                cpt++;
                            }

                            cA = cAN.ToCharArray();
                        }

                       
                    }

                }
                

            }

            Console.WriteLine(cpt);

            if (cpt < inputArray.Length )
                return false;
            else
                return true;
        }

        private static int absoluteValuesSumMinimization(int[] a)
        {
            if ((a.Length % 2) != 0) return a[(a.Length/2)];
                                else return a[(a.Length / 2)-1];
        }

        private static int depositProfit(int deposit, int rate, int threshold)
        {
            //(deposit > threshold) ? ref return 0 : rreturn 1+( depositProfit( deposit + ((deposit*rate)/100) ,rate,threshold) ) ; 

           if (deposit >= threshold)
                return 0;
            else
                return 1 + (depositProfit(deposit + ((deposit * rate) / 100), rate, threshold));

        }

        private static int circleOfNumbers(int n, int firstNumber)
        {
            return ( (firstNumber+(n/2)) >= n ) ? (firstNumber + (n / 2)) - n : (firstNumber + (n / 2));
        }

        private static bool chessBoardCellColor(string cell1, string cell2)
        {
            bool cell1B = ((Convert.ToInt32(cell1[0]) - 64) % 2 != 0 && ((Convert.ToInt32(cell1[1])) % 2 != 0)) || ((Convert.ToInt32(cell1[0]) - 64) % 2 == 0 && ((Convert.ToInt32(cell1[1])) % 2 == 0)),
                 cell2B = ((Convert.ToInt32(cell2[0]) - 64) % 2 != 0 && ((Convert.ToInt32(cell2[1])) % 2 != 0)) || ((Convert.ToInt32(cell2[0]) - 64) % 2 == 0 && ((Convert.ToInt32(cell2[1])) % 2 == 0)),
                 cell1W = ((Convert.ToInt32(cell1[0]) - 64) % 2 == 0 && ((Convert.ToInt32(cell1[1])) % 2 != 0)) || ((Convert.ToInt32(cell1[0]) - 64) % 2 != 0 && ((Convert.ToInt32(cell1[1])) % 2 == 0)),
                 cell2W = ((Convert.ToInt32(cell2[0]) - 64) % 2 == 0 && ((Convert.ToInt32(cell2[1])) % 2 != 0)) || ((Convert.ToInt32(cell2[0]) - 64) % 2 != 0 && ((Convert.ToInt32(cell2[1])) % 2 == 0));

            return (cell1B && cell2B) || ( cell1W && cell2W );
        }

        private static string alphabeticShift(string inputString)
        {
                return new String ((inputString.ToCharArray().Select( p => (Convert.ToInt32(p) == 122) ? Convert.ToChar(97) : Convert.ToChar(Convert.ToInt32(p)+1) ).ToArray()));
        }

        private static bool variableName(string name)
        {
            return new Regex("^[a-zA-Z_]{1,20}[a-zA-Z0-9_]{1,20}$").IsMatch(name);
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
