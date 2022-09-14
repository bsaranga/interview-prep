namespace WarmupChallenges
{
    public class CountingValleys
    {
        public int countingValleys(int steps, string path)
        {
            int altitude = 0;
            char[] pathSteps = path.ToCharArray();
            List<List<string>> charList = new List<List<string>>();
            int index = -1;

            foreach (var p in pathSteps)
            {
                switch (p)
                {
                    case 'U':
                        if (altitude == 0)
                        {
                            index++;
                            charList.Add(new List<string>());
                        }
                        else if (altitude < 0) charList[index].Add("V");
                        else charList[index].Add("M");

                        altitude++;
                        break;
                    case 'D':
                        if (altitude == 0)
                        {
                            index++;
                            charList.Add(new List<string>());
                        }
                        else if (altitude < 0) charList[index].Add("V");
                        else charList[index].Add("M");

                        altitude--;
                        break;
                }
            }

            int valleyCount = charList.Count(l => l.Contains("V"));

            return valleyCount;
        }
    }
}
