namespace Assignment6._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);

            Console.WriteLine(string.Join(", ", nums));
        }

        static void MoveZeroes(int[] nums)
        {
            int insertPos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[insertPos] = nums[i];
                    insertPos++;
                }
            }

            while (insertPos < nums.Length)
            {
                nums[insertPos] = 0;
                insertPos++;
            }
        }
    }
}
