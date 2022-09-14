using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmupChallenges
{
    public class RepeatedStrings
    {
        public long repeatedString(string s, long n)
        {
            if (!s.Contains('a')) return 0;

            if (s.Length == 1) return n;

            if (s.Length >= n) return s.Substring(0, (int)n).Count(c => c == 'a');

            long numChars = s.Length;
            long numAInSubStr = s.Count(c => c == 'a');
            long numAs = numAInSubStr * (n / numChars) + s.Substring(0, (int)(n % numChars)).Count(c => c == 'a');

            return numAs;
        }
    }
}
