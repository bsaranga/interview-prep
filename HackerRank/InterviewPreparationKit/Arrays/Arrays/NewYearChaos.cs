namespace Arrays
{
    public class NewYearChaos
    {
        public static void minimumBribes(List<int> q)
        {
            Console.WriteLine(minimumBribesCalc(q));
        }

        public static string minimumBribesCalc(List<int> q)
        {
            int totalBribes = 0;
            for (int i = 0; i < q.Count; i++)
            {
                if (q[i] - 1 != i)
                {
                    if (q[i] - 1 - i <= 2 && q[i] - 1 - i > 0)
                    {
                        int bribes = q[i] - 1 - i;
                        totalBribes += bribes;
                    }

                    if (q[i] - 1 - i > 2) return "Too chaotic";
                }
            }
            
            return totalBribes.ToString();
        }
    }
}
