namespace ClassLibrary1
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length < 2) return nums.Length;

            int current = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[current] != nums[i])
                {
                    current++;
                    nums[current] = nums[i];
                }
            }

            return current + 1;
        }
    }
}
