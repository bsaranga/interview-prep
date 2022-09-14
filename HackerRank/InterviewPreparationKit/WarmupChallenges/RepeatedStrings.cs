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
            // abaabaabaaba|aba
            long duplicates = (long) Math.Ceiling((decimal) n/s.Length);
            string repeatedSubStr = "";

            for (int i = 0; i <= duplicates; i++)
            {
                repeatedSubStr += s;
            }

            var numAs = repeatedSubStr.Substring(0, (int)n).Count(s => s == 'a');

            return numAs;
        }
    }
}
