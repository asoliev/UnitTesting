namespace UnitTesting.Tasks
{
    public class FizzBuzz
    {
        public static string ReplaceWithFizzBuzz(int num)
        {
            if (num <= 0 || num > 100) 
                throw new ArgumentOutOfRangeException("You should provide a number in a range from 1 to 100.");

            if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
            else if (num % 3 == 0) return "Fizz";
            else if (num % 5 == 0) return "Buzz";
            else return num.ToString();
        }
    }
}