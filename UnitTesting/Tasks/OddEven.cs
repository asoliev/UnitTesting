namespace UnitTesting.Tasks
{
    public class OddEven
    {
        public static string CheckOddEven(int num)
        {
            int half = num / 2;

            if (num <= 0 || num > 100) 
                throw new ArgumentOutOfRangeException("You should provide a number in a range from 1 to 100.");

            if (num == 1) return "Odd";
            if (num % 2 == 0) return "Even";

            for (int i = 4; i <= half; i++)
                if (num % i == 0) return "Odd";

            return "Prime";
        }
    }
}