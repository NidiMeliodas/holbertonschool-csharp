namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;
            return nums.Max();
        }
    }
}
