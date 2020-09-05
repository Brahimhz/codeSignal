using System;
using System.Collections.Generic;

namespace codeSignal
{
    class TheCore
    {
        public int addTwoDigits(int n)
        {
            return (n / 10) + (n % 10);
        }

        public int largestNumber(int n)
        {
            return (int)((Math.Pow(10, n)) - 1);
        }


        public int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }

        public int circleOfNumbers(int n, int firstNumber)
        {
            return ((n / 2) + firstNumber >= n) ? ((n / 2) + firstNumber) - n : (n / 2) + firstNumber;
        }

        public int lateRide(int n)
        {
            return ((n / 60) / 10) + ((n / 60) % 10) + ((n % 60) / 10) + ((n % 60) % 10);
        }

        public int phoneCall(int min1, int min2_10, int min11, int s)
        {
            var count = 0;
            var nbrMin = 0;

            if (s < min1)
                return count;
            else
            {
                count++;
                s -= min1;
                if (s < min2_10)
                    return count;
                else
                {
                    nbrMin = s / min2_10;
                    if (nbrMin > 9)
                    {
                        count += 9;
                        s -= 9 * min2_10;
                    }
                    else
                    {
                        count += s / min2_10;
                        s -= (s / min2_10) * min2_10;
                    }
                }

                if (s < min11 || nbrMin <= 9)
                    return count;
                else
                {
                    count += s / min11;
                    return count;
                }

            }
        }

        public bool reachNextLevel(int experience, int threshold, int reward)
        {
            return (threshold <= (experience + reward)) ? true : false;
        }

        public int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
            {
                return value1 + value2;
            }
            if (value1 > value2 && weight1 <= maxW)
            {
                return value1;
            }
            if (value2 > value1 && weight2 <= maxW)
            {
                return value2;
            }
            if (weight1 <= maxW)
            {
                return value1;
            }
            if (weight2 <= maxW)
            {
                return value2;
            }
            return 0;
        }

        public int extraNumber(int a, int b, int c)
        {
            return (a != b) ? ((a == c) ? b : a) : c;
        }

        public bool isInfiniteProcess(int a, int b)
        {
            return b - a < 0 || (b - a) % 2 != 0;
        }

        public bool arithmeticExpression(int a, int b, int c)
        {
            return (a + b == c || a - b == c || a * b == c || (a / b == c && a % b == 0)) ? true : false;
        }

        public bool tennisSet(int score1, int score2)
        {
            var l = new List<int>(); l.Add(score1); l.Add(score2); l.Sort();

            return l[1] == 7 && l[0] == 5 || l[1] == 7 && l[0] == 6 || l[1] == 6 && l[0] <= 4;
        }

    }
}
