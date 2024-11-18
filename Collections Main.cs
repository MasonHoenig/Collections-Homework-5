namespace Collections_Homework_5
{
    class Collections_Main
    {
        private static void Main()
        {
            List<int> nums = new List<int>() { 12, 12, 4, 5, 19, 19, 5, 0, 17, 17, 12, 14, 19, 2, 8, 10, 2, 10, 2, 7, 11, 14, 1, 4, 15, 16, 7, 10, 14, 5, 5, 4, 2, 11, 4, 14, 16, 7, 4, 19, 11, 5, 8, 6, 19, 14, 7, 6, 4, 16 };
            Console.WriteLine("Numbers in List: ");
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }

            List<int> unique = new List<int>();

            for(int i = 0; i < nums.Count; i++)
            {
                if (!unique.Contains(nums[i]))
                {
                    unique.Add(nums[i]);
                }
                unique.Sort();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Unique Numbers: ");
            foreach (int numbers in unique)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Number Frequency: ");
            foreach (int number in unique)
            {
                bool InList(int item)
                {
                    return item == number;
                }
                int count = nums.Count(InList);
                Console.WriteLine($"{number} appears {count} time(s)");
            }

            Console.WriteLine();

            Console.WriteLine("Reduced Number Sequence (original odd indices removed):");
            for (int i = 1; i < nums.Count; i++)
            {
                nums.RemoveAt(i);
            }
            foreach (int number in nums)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Reduced Number Sequence (single digits only):");
            for (int i = 1; i < nums.Count; i++)
            {
                if(nums[i] > 9 || nums[i] < -9)
                {
                    nums.RemoveAt(i);
                }
            }
            foreach(int number in nums)
            {
                Console.Write(number + " ");
            }
        }
    }
}
