using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ConsoleApp
{
    /// <summary>
    /// 两数之和 
    /// </summary>
    public class TwoSumSolution
    {
        /// <summary>
        /// 两次遍历
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            var rs = new List<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        if (!rs.Contains(i))
                        {
                            rs.Add(i);
                        }
                        if (!rs.Contains(j))
                        {
                            rs.Add(j);
                        }
                    }
                }
            }
            return rs.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumV2(int[] nums, int target)
        {
            var rs = new List<int>();
            var list = nums.ToList();
            for (int i = 0; i < nums.Length; i++)
            {
                //取target和value之差diff，若diff在nums中，则返回其索引
                var v = target - list[i];
                if (list.Contains(v))
                {
                    var idx = Array.IndexOf(nums, v);
                    if (idx != i)
                    {
                        if (!rs.Contains(idx))
                        {
                            rs.Add(idx);
                        }
                        if (!rs.Contains(i))
                        {
                            rs.Add(i);
                        }                        
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return rs.ToArray();
        }
    }
}
