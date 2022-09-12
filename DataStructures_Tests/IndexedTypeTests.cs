using Xunit.Abstractions;
using DataStructures.DynamicArrays;

namespace DataStructures_Tests
{
    public class IndexedTypeTests
    {
        private readonly ITestOutputHelper testOutputHelper;
        public IndexedTypeTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void InitializedArrayOfSizeFive()
        {
            var indexedType = new IndexedType<string>();
            Assert.Equal(5, indexedType.Length);
        }

        [Fact]
        public void IndexedArrayIsPopulatedByDefaultValues()
        {
            var indexedType = new IndexedType<int>();
            Assert.Equal(0, indexedType[0]);
            Assert.Equal(0, indexedType[1]);
            Assert.Equal(0, indexedType[2]);
            Assert.Equal(0, indexedType[3]);
            Assert.Equal(0, indexedType[4]);
        }

        [Fact]
        public void IndexedArrayCanResize()
        {
            var indexedType = new IndexedType<int>();
            indexedType[5] = 1;
            Assert.Equal(6, indexedType.Length);
        }

        [Fact]
        public void AccessingOutOfBoundsRaisesException()
        {
            var indexedType = new IndexedType<int>();
            Assert.Throws<IndexOutOfRangeException>(() => indexedType[5]);
        }
    }
}
