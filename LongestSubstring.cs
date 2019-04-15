public class Solution {
    public int LengthOfLongestSubstring(string s) {
            string subs = "";
            int l = 0, i = 0, curr = 0;
            if (s.Length != 1)
            {
                while (i < s.Length)
                {
                    if (subs.IndexOf(s[i]) != -1)
                    {
                        subs = "";
                        s = s.Substring(1);
                        i = -1;
                    }
                    else if (subs.IndexOf(s[i]) == -1)
                    {
                        subs = subs + s[i];
                        curr = subs.Length;
                        if (curr > l){
                            l = curr;
                        }
                    }
                    i++;
                }
                return l;
            }
            else
            {
                return 1;
            }
    }
}
