using WarmupChallenges;
using Xunit.Abstractions;

namespace WarmupChallenges_Tests
{
    public class CountingValleys_Tests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public CountingValleys_Tests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CountingValley_Test1()
        {
            int steps = 8;
            string path = "UDDDUDUU";
            var cv = new CountingValleys();
            
            var result = cv.countingValleys(steps, path);
            Assert.Equal(1, result);
        }

        [Fact]
        public void CountingValley_Test2()
        {
            /*         /\
             _        /  \  _
              \      /    \/
               \    /
                \  /
                 \/
             */
            int steps = 14;
            string path = "DDDDUUUUUUDDDU";
            var cv = new CountingValleys();

            var result = cv.countingValleys(steps, path);
            Assert.Equal(2, result);
        }
    }
}
