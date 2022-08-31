using Xunit.Abstractions;

namespace DataStructures_Tests
{
    public class CommonTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public CommonTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CanExtendArrayByConcatenation()
        {
            int[] foo = new int[5];
            int[] bar = new int[5];

            var concatenatedArr = foo.Concat(bar);

            Assert.True(concatenatedArr.Count() == 10);
        }

        [Fact]
        public void DefaultArrayContentsAreOfDefaultType()
        {
            int[] def = new int[5];

            foreach (var item in def)
            {
                Assert.True(item == default(int));
            }
        }

        [Fact]
        public void ArraysAreReferenceTypes()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };

            var arr2 = arr1;
            var arr3 = arr1;

            Assert.True(Object.ReferenceEquals(arr2, arr3));
        }

        [Fact]
        public void WTFAreReferenceTypes()
        {
            string foo = "foo";
            string bar = foo;

            bar.Append('b');

            testOutputHelper.WriteLine(bar);
        }
    }
}
