namespace UnitTesting.Tasks
{
    public class OddEven
    {
        public enum OddEvenEnum
        {
            Odd,
            Even,
            Prime
        }

        public static OddEvenEnum CheckOddEven(int num)
        {
            int half = num / 2;

            if (num <= 0 || num > 100) 
                throw new ArgumentOutOfRangeException("You should provide a number in a range from 1 to 100.");

            if (num == 1) return OddEvenEnum.Odd;
            if (num % 2 == 0) return OddEvenEnum.Even;

            for (int i = 4; i <= half; i++)
                if (num % i == 0) return OddEvenEnum.Odd;

            return OddEvenEnum.Prime;
        }
    }
}