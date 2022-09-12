using System.Collections.Immutable;

namespace WarmupChallenges
{
    public class SalesByMatch
    {
        /// <summary>
        /// Gives the number of pairs (k) from a list of (n) objects in list (ar)
        /// </summary>
        /// <param name="n">Number of array objects</param>
        /// <param name="ar">Array of objects (ints)</param>
        /// <returns>Number of pairs</returns>

        public int sockMerchant(int n, List<int> ar)
        {
            var numPairs = 0;
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                var numElem = 0;

                if (!dict.Keys.Contains(ar[i]))
                {
                    for (int j = 0; j < n; j++)
                        if (ar[i] == ar[j])
                            numElem++;

                    dict.Add(ar[i], numElem);
                }
                else continue;
            }

            foreach (var item in dict)
                numPairs += item.Value / 2;

            return numPairs;
        }
    }
}