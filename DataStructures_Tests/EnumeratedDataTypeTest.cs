using DataStructures.DynamicArrays;

namespace DataStructures_Tests
{
    public class EnumeratedDataTypeTest
    {
        private EnumeratedDataType<int> IntEnumDataType;
        public EnumeratedDataTypeTest()
        {
            // Setup
            IntEnumDataType = new EnumeratedDataType<int>(2, 4, 6, 8, 10, 12, 14, 16);
        }

        [Fact]
        public void IsIterable()
        {
            var copiedArr = new List<int>();
            
            foreach (var item in IntEnumDataType)
            {
                copiedArr.Add(item);
            }

            Assert.Equal(copiedArr.Count, IntEnumDataType.Count());
        }
    }
}
