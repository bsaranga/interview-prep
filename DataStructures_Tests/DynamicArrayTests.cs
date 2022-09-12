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
        public void InitializedArrayOfSizeZero()
        {
            var dynArray = new DynamicArray<string>();
            Assert.Equal(0, dynArray.Length);
        }

        [Fact]
        public void IndexOutOfRangeIsThrownWhenSizeZeroArrayIsAccessed()
        {
            var dynArray = new DynamicArray<int>();
            Assert.Throws<IndexOutOfRangeException>(() => dynArray[0]);
        }

        [Fact]
        public void IndexedArrayCanResize()
        {
            var dynArray = new DynamicArray<int>(0);
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
        public void CurrentElementPointsToLastElement()
        {
            var dynArray = new DynamicArray<string>(new string[] { "foo", "bar", "coo"});
            Assert.Equal("coo", dynArray.Current);
        }

        [Fact]
        public void ExtendStoreByDefaultExtensionAmountWorks()
        {
            var dynArray = new DynamicArray<int>();
            dynArray.ExtendStore();
            Assert.Equal(1, dynArray.Length);
        }

        [Fact]
        public void ElementsArePreservedWhenExtended()
        {
            var dynArray = new DynamicArray<int>(new int[] { 1,2,3,4,5 });
            dynArray.ExtendStore();

            Assert.Equal(1, dynArray[0]);
            Assert.Equal(5, dynArray[4]);
            Assert.Equal(default (int), dynArray[5]);
        }

        [Fact]
        public void NullStoreExceptionThrownWhenExtendedByZero()
        {
            var dynArray = new DynamicArray<int>();
            Assert.Throws<NullStoreExtensionException>(() => dynArray.ExtendStore(0));
        }

        [Fact]
        public void InitializingWithOneElement()
        {
            var dynArray = new DynamicArray<int>(1);
            Assert.Equal(1, dynArray.Current);
        }

        [Fact]
        public void InitializingZeroArrayAndAddingOneElementGivesCorrectLengthAndValue()
        {
            var dynArray = new DynamicArray<int>();
            dynArray.Add(1);

            Assert.Equal(1, dynArray.Current);
            Assert.Equal(1, dynArray.Length);
        }

        [Fact]
        public void InitializingZeroArrayAndAddingAnArrayOfTReturnsCorrectLengthAndValues()
        {
            var dynArray = new DynamicArray<int>();
            dynArray.Add(new int[] { 1, 2, 3 });
            dynArray.Add(4, 5);

            Assert.Equal(5, dynArray.Length);
            Assert.Equal(5, dynArray.Current);
        }

        [Fact]
        public void InBetweenValuesAreDefaults()
        {
            var dynArray = new DynamicArray<int>();
            dynArray[9] = 10;

            for (int i = 0; i < 9; i++)
            {
                Assert.Equal(default(int), dynArray[i]);
            }
        }

        [Fact]
        public void OverwritingAValueWorksAsExpected()
        {
            var dynArray = new DynamicArray<int>(1, 2, 3, 4, 5, 6);
            dynArray[2] = 7;

            Assert.Equal(1, dynArray[0]);
            Assert.Equal(2, dynArray[1]);
            Assert.Equal(7, dynArray[2]);
            Assert.Equal(4, dynArray[3]);
            Assert.Equal(5, dynArray[4]);
            Assert.Equal(6, dynArray[5]);
        }

        [Fact]
        public void RemovingAValueWorksAsExpected()
        {
            var dynArray = new DynamicArray<int>(1, 2, 3, 4, 5, 6);
            dynArray.Remove(2);

            Assert.Equal(4, dynArray[2]);
            Assert.Equal(6, dynArray.Current);
            
            for (int i = 0; i < dynArray.Length; i++)
            {
                testOutputHelper.WriteLine(dynArray[i].ToString());
            }
        }

        [Fact]
        public void DynamicArrayIsEnumerable()
        {
            var dynArray = new DynamicArray<int>(1, 2, 3, 4);
            var copyArray = new DynamicArray<int>();
            
            foreach (var item in dynArray)
            {
                copyArray.Add(item);
                testOutputHelper.WriteLine(item.ToString());
            }

            Assert.Equal(dynArray, copyArray);
        }
    }
}
