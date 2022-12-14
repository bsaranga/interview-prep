using Arrays;

namespace Arrays_Tests
{
    public class CircularArray_Tests
    {
        [Fact]
        public void LeftRotate_Test1()
        {
            var result = CircularArray.rotLeft(new List<int> { 1, 2, 3, 4, 5 }, 3);
            Assert.Equal(result, new List<int> { 4, 5, 1, 2, 3 });
        }

        [Fact]
        public void LeftRotate_Test2()
        {
            var result = CircularArray.rotLeft(new List<int> { 1, 2, 3, 4, 5 }, 4);
            Assert.Equal(result, new List<int> { 5, 1, 2, 3, 4 });
        }
    }
}