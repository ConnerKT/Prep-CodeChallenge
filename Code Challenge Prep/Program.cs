namespace Code_Challenge_Prep;

class Program
{

    static void Main(string[] args)
    {
        PrepChallenge1();
    }
    static void PrepChallenge1()
    {
        Console.WriteLine("Code Challenge 1");
        int[] nums = new int[5];
        try {
            for (int i = 0; i < nums.Length; i++) {
               Console.WriteLine("Please Enter your Number from 1-10");
               nums[i] = Int32.Parse(Console.ReadLine());
                while (!(nums[i] > 0 && nums[i] <= 10)) {
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
            if(!nums.Contains(choice))
            {
                Console.WriteLine("Your Score is: " + score);
            }
            else
            {
                foreach(int num in nums)
                {
                    if (num == choice)
                    {
                        score += num;
                    }
                }
            }

        }
        catch (Exception err) {
            Console.WriteLine("Uh Oh, There's an Error...");
            Console.WriteLine(err.ToString());
        }
        finally{
            Console.WriteLine("The Game is Over");
        }
        

    }

}

