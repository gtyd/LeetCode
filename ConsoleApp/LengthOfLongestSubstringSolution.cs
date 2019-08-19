using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /// <summary>
    /// 无重复字符的最长子串
    /// </summary>
    public class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var strChar = s.ToCharArray();
            var len = s.Length;
            var dic = new Dictionary<char, int>();
            var result = 0;
            for (int end = 0, start = 0; end < len; end++)
            {
                var sv = strChar[end];
                if (dic.ContainsKey(sv))
                {
                    start = Math.Max(dic[sv], start);
                    dic.Remove(sv);
                }
                dic.Add(sv, end + 1);
                result = Math.Max(result, end - start + 1);
            }
            return result;
        }
    }
}
