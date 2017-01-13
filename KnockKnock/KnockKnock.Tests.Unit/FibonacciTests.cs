using KnockKnock.Fibonacci;
using NUnit.Framework;

namespace KnockKnock.Tests.Unit
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void ShouldFindTheFibonacciNumberByIndex()
        {
            var fibonacciNums = "1,1,2,3,5,8,13,21,34,55,89,144";
            var position = 5;
            var fibonacciNumService = new FibonacciNumService(fibonacciNums);
            var fibonacciNum = fibonacciNumService.Search(position);

            Assert.AreEqual(fibonacciNum, 8);
        }
    }
}