namespace UnitTesting.Tasks
{
    public class PrimeFactor
    {
        public static string CheckPrimeComposite(int num)
        {
            int half = num / 2;

            if (num <= 0 || num > 100)
                throw new ArgumentOutOfRangeException("You should provide a number in a range from 1 to 100.");

            if (num == 1) return "1";
            else if (num == 2 || num == 3) return "Prime";

            for (int i = 2; i <= half; i++)
                if (num % i == 0) return "Composite";

            return "Prime";
        }
    }
}