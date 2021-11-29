using System.Linq;
using System;
namespace ByndyusoftTestTask
{
    public static class Logic
    {
        public static int? SumOfTwoMinimum(int[] arr)
        {
            if (arr is null || arr.Length <= 1)
                return null;

            int min, min1;
            min = min1 = int.MaxValue;
            foreach (int i in arr)
                if (i < min)
                {
                    min1 = min;
                    min = i;
                }
                else if (i < min1)
                    min1 = i;
            return min + min1;
        }
    }
}