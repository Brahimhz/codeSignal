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
            return (int)((Math.Pow(10 , n )) - 1);
        }


        public int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nCols - col + 1) * (nRows - row);
        }

    }
}
