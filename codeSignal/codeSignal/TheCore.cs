using System;

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

    }
}
