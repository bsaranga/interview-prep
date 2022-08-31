namespace DataStructures_Tests
{
    public class CommonTests
    {
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
    }
}
