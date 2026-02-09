namespace _5_1_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntegerPalindrome(121));
            Console.WriteLine(IntegerPalindrome(-121));
            Console.WriteLine(IntegerPalindrome(10));
            Console.WriteLine(IntegerPalindrome(100000001));
            Console.WriteLine("10 = " + SumOfDigits(10));
            Console.WriteLine("123 = " + SumOfDigits(123));
            Console.WriteLine("55555 = " + SumOfDigits(55555));
            Console.WriteLine("900001 = " + SumOfDigits(900001));
            Random rand = new Random();
            int[] arr = new int[rand.Next(3,7)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(4, 9);
            }
            foreach (int num in arr)
            {
                Console.Write("[");
                Console.Write(num + "] ");
                
            }
            Console.WriteLine("\n" + IntDupes(arr));


        }

        static bool IntegerPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            int original = x;
            int reversed = 0;
            while (x != 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }
            if (original == reversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int SumOfDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;

        }
        static bool IntDupes(int[] arr)
        {
            List<int> seen = new List<int>();
            foreach (int num in arr)
            {
                if (seen.Contains(num))
                {
                    return true;
                }
                seen.Add(num);
            }
            return false;
        }
    } }
