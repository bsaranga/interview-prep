using WarmupChallenges;
using Xunit.Abstractions;

namespace WarmupChallenges_Tests
{
    public class JumpingOnClouds_Tests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public JumpingOnClouds_Tests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void JumpingOnClouds_Test1()
        {
            var jumpingOnClouds = new JumpingOnClouds();
            var result = jumpingOnClouds.Jump(new List<int> { 0, 0, 1, 0, 0, 1, 0 });

            Assert.Equal(4, result);
        }   

        [Fact]
        public void JumpingOnClouds_Test2()
        {
            var jumpingOnClouds = new JumpingOnClouds();
            var result = jumpingOnClouds.Jump(new List<int> { 0, 0, 0, 0, 1, 0 });

            Assert.Equal(3, result);
        }

        [Fact]
        public void JumpingOnClouds_Test3()
        {
            var jumpingOnClouds = new JumpingOnClouds();
            var result = jumpingOnClouds.Jump(new List<int> { 0, 0, 0, 1, 0, 0 });

            Assert.Equal(3, result);
        }

        [Fact]
        public void JumpingOnClouds_Test4()
        {
            var jumpingOnClouds = new JumpingOnClouds();
            var result = jumpingOnClouds.Jump(new List<int> { 0, 0, 1, 0, 0, 1, 0 });

            Assert.Equal(4, result);
        }
    }
}
