using WarmupChallenges;
using Xunit.Abstractions;

namespace WarmupChallenges_Tests
{
    public class SalesByMatchTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public SalesByMatchTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void SockMerchant_Test0()
        {
            var salesByMatch = new SalesByMatch();

            var numberOfElements = 5;
            var listOfElements = new List<int> { 2, 2, 3, 2, 2 };

            var result = salesByMatch.sockMerchant(numberOfElements, listOfElements);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SockMerchant_Test1()
        {
            var salesByMatch = new SalesByMatch();

            var numberOfElements = 8;
            var listOfElements = new List<int> { 2, 2, 5, 6, 3, 4, 3, 2 };

            var result = salesByMatch.sockMerchant(numberOfElements, listOfElements);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SockMerchant_Test2()
        {
            var salesByMatch = new SalesByMatch();

            var numberOfElements = 9;
            var listOfElements = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };

            var result = salesByMatch.sockMerchant(numberOfElements, listOfElements);
            Assert.Equal(3, result);
        }

        [Fact]
        public void SockMerchant_Test3()
        {
            var salesByMatch = new SalesByMatch();

            var numberOfElements = 10;
            var listOfElements = new List<int> { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

            var result = salesByMatch.sockMerchant(numberOfElements, listOfElements);
            Assert.Equal(4, result);
        }

        [Fact]
        public void SockMerchant_Test4()
        {
            var salesByMatch = new SalesByMatch();

            var numberOfElements = 11;
            var listOfElements = new List<int> { 2, 2, 5, 1, 1, 1, 1, 6, 3, 4, 2 };

            var result = salesByMatch.sockMerchant(numberOfElements, listOfElements);
            Assert.Equal(3, result);
        }

        [Fact]
        public void SockMerchant_Test5()
        {
            var salesByMatch = new SalesByMatch();

            var numberOfElements = 100;
            var listOfElements = new List<int> { 44, 55, 11, 15, 4, 72, 26, 91, 80, 14, 43, 78, 70, 75, 36, 83, 78, 91, 17, 17, 54, 65, 60, 21, 58, 98, 87, 45, 75, 97, 81, 18, 51, 43, 84, 54, 66, 10, 44, 45, 23, 38, 22, 44, 65, 9, 78, 42, 100, 94, 58, 5, 11, 69, 26, 20, 19, 64, 64, 93, 60, 96, 10, 10, 39, 94, 15, 4, 3, 10, 1, 77, 48, 74, 20, 12, 83, 97, 5, 82, 43, 15, 86, 5, 35, 63, 24, 53, 27, 87, 45, 38, 34, 7, 48, 24, 100, 14, 80, 54 };
            
            var result = salesByMatch.sockMerchant(numberOfElements, listOfElements);
            Assert.Equal(30, result);
        }
    }
}