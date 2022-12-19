using Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Arrays_Tests
{
    public class NewYearChaos_Tests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public NewYearChaos_Tests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void NewYearChaos_Test1()
        {
            var result = NewYearChaos.minimumBribesCalc(new List<int> { 1, 2, 3, 5, 4, 6, 7, 8 });
            Assert.Equal(1, Int32.Parse(result));
        }

        [Fact]
        public void NewYearChaos_Test2()
        {
            // 1 2 3 4 5 6 7 8
            // 1 2 3 5 4 6 7 8 = 1 bribe
            // 1 2 5 3 4 6 7 8 = 2 bribes
            // 1 2 5 3 4 7 6 8 = 3 bribes
            // 1 2 5 3 7 4 6 8 = 4 bribes
            // 1 2 5 3 7 4 8 6 = 5 bribes
            // 1 2 5 3 7 8 4 6 = 6 bribes
            // 1 2 5 3 7 8 6 4 = 7 bribes

            var result = NewYearChaos.minimumBribesCalc(new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 });
            Assert.Equal(7, Int32.Parse(result));
        }

        [Fact]
        void Exp()
        {
            int[] arr = { 1, 2, 5, 3, 7, 8, 6, 4 };

            for (int i = 0, swaps = 0; i < arr.Length; ++i)
            {
                if (arr[i] > i + 1)
                {
                    int cp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = cp;
                    swaps++;
                }

                testOutputHelper.WriteLine($"{arr[i]}|{swaps}");
            }
        }
    }
}
