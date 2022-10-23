namespace UnitTesting.Tasks
{
    public class FizzBuzz
    {
        public enum FizzBuzzEnum
        {
            Fizz = 101,
            Buzz = 102,
            FizzBuzz = 103
        }

        public static FizzBuzzEnum ReplaceWithFizzBuzz(int num)
        {
            if (num <= 0 || num > 100) 
                throw new ArgumentOutOfRangeException("You should provide a number in a range from 1 to 100.");

            if (num % 3 == 0 && num % 5 == 0) return FizzBuzzEnum.FizzBuzz;
            else if (num % 3 == 0) return FizzBuzzEnum.Fizz;
            else if (num % 5 == 0) return FizzBuzzEnum.Buzz;
            else return (FizzBuzzEnum)Enum.Parse(typeof(FizzBuzzEnum), num.ToString());
        }
    }
}