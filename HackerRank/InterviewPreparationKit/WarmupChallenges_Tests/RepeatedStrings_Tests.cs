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

        [Fact]
        public void RepeatedStrings_Test2()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("a", 1000000000000);

            Assert.Equal(1000000000000, result);
        }

        [Fact]
        public void RepeatedStrings_Test3()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("abababababababababa", 10);

            Assert.Equal(5, result);
        }

        [Fact]
        public void RepeatedStrings_Test4()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("aabbaabbaabbaabbaa", 18);

            Assert.Equal(10, result);
        }

        [Fact]
        public void RepeatedStrings_Test5()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("gfcaaaecbg", 547602);

            Assert.Equal(164280, result);
        }

        [Fact]
        public void RepeatedStrings_Test6()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("aedbdaeaddadddcedcbbabdccbecaecaccdbebeeadadcaabbaabbaeeeecaddbcdecbbdccdebaaebecdaaabbcdeccbabaabce", 731869010806);

            Assert.Equal(168329872486, result);
        }

        [Fact]
        public void RepeatedStrings_Test7()
        {
            var r = new RepeatedStrings();
            var result = r.repeatedString("afkagamnac", 15);

            Assert.Equal(6, result);
        }
    }
}
