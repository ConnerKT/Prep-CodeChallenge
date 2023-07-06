namespace Code_Challenge_Prep;

class Program
{

    static void Main(string[] args)
    {
        //PrepChallenge1();
        PrepChallenge2();
    }
    static void PrepChallenge1()
    {
        Console.WriteLine("Code Challenge 1");
        int[] nums = new int[5];
        try
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Please Enter your Number from 1-10");
                nums[i] = Int32.Parse(Console.ReadLine());
                while (!(nums[i] > 0 && nums[i] <= 10))
                {
                    Console.WriteLine("Try Again. Reading is Fundamental");
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Your array is : ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Choose a number from the array");
            int choice = Convert.ToInt32(Console.ReadLine());
            int score = 0;
            if (!nums.Contains(choice))
            {
                Console.WriteLine("Your Score is: " + score);
            }
            else
            {
                foreach (int num in nums)
                {
                    if (num == choice)
                    {
                        score += num;
                    }
                }
            }

        }
        catch (Exception err)
        {
            Console.WriteLine("Uh Oh, There's an Error...");
            Console.WriteLine(err.ToString());
        }
        finally
        {
            Console.WriteLine("The Game is Over");
        }


    }
    static void PrepChallenge2()
    {
        Console.WriteLine("Code Challenge 2");
        Console.WriteLine("Please Enter a Year!");

        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 4 == 0)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                Console.WriteLine("Your Year is not a Leap Year");
            }
            Console.WriteLine("Your Year is a Leap Year");
        }
        

    }
}
