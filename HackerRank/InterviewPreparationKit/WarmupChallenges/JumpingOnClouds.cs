namespace WarmupChallenges
{
    public class JumpingOnClouds
    {
        public int Jump (List<int> c)
        {
            int maxJump = 2;
            int minJump = 1;
            int jumpCount = 0;
            int index = 0;
            int length = c.Count;

            while(index < length - 1)
            {
                if ((index + maxJump) < length && c[index + maxJump] == 0)
                {
                    jumpCount++;
                    index += maxJump;
                } else
                {
                    jumpCount++;
                    index += minJump;
                }
            }

            return jumpCount;
        }
    }
}
