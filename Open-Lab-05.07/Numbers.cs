using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            List<int> numbers = nums.OfType<int>().ToList();
            numbers.Remove(nums.Min());
            return numbers.ToArray();
        }
    }
}
