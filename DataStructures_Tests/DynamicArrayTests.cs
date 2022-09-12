using Xunit.Abstractions;
using DataStructures.DynamicArrays;

namespace DataStructures_Tests
{
    public class DynamicArrayTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public DynamicArrayTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void InitializedArrayOfSizeOne()
        {
            var dynArray = new DynamicArray<string>();
            Assert.Equal(1, dynArray.Length);
        }

        [Fact]
        public void IndexedArrayIsPopulatedByDefaultValues()
        {
            var dynArray = new DynamicArray<int>();
            Assert.Equal(0, dynArray[0]);
        }

        [Fact]
        public void IndexedArrayCanResize()
        {
            var dynArray = new DynamicArray<int>();
            dynArray[5] = 1;
            Assert.Equal(6, dynArray.Length);

            for (int i = 0; i < 6; i++)
            {
                testOutputHelper.WriteLine(dynArray.Current.ToString());
                dynArray.MoveNext();
            }
        }

        [Fact]
        public void AccessingOutOfBoundsRaisesException()
        {
            var dynArray = new DynamicArray<int>();
            Assert.Throws<IndexOutOfRangeException>(() => dynArray[5]);
        }

        [Fact]
        public void InitializingWithArrayOfTHasAppropriateSize()
        {
            var dynArray = new DynamicArray<string>(new string[] { "foo", "bar" });
            Assert.Equal(2, dynArray.Length);
        }

        [Fact]
        public void CurrentElementPointsToFirstElement()
        {
            var dynArray = new DynamicArray<string>(new string[] { "foo", "bar", "coo"});
            Assert.Equal("foo", dynArray.Current);
        }

        [Fact]
        public void InitializationUsingNegativeSizesThrowsArgumentOutOfRangeException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new DynamicArray<string>(-1));
        }

        [Fact]
        public void ExtendStoreWorks()
        {
            var dynArray = new DynamicArray<int>();
        }
    }
}
