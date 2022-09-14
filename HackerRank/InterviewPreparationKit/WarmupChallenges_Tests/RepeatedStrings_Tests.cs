using WarmupChallenges;

namespace WarmupChallenges_Tests
{
    public class RepeatedStrings_Tests
    {
        [Fact]
        public void RepeatedStrings_Test1()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("aba", 10);

            Assert.Equal(7, result);
        }
    }
}
