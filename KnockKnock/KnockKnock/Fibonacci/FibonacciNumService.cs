using System;

namespace KnockKnock.Fibonacci
{
    public class FibonacciNumService
    {
        private string _fibonacciNums;

        public FibonacciNumService(string fibonacciNums)
        {
            _fibonacciNums = fibonacciNums;
        }

        public int Search(int position)
        {
            return Convert.ToInt32(_fibonacciNums.Split(',')[position]);
        }
    }
}