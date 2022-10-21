namespace UnitTesting.Tasks
{
    public class PrimeFactor
    {
        public enum PrimeFactorEnum
        {
            One,
            Prime,
            Composite
        }

        public static PrimeFactorEnum CheckPrimeComposite(int num)
        {
            int half = num / 2;

            if (num <= 0 || num > 100)
                throw new ArgumentOutOfRangeException("You should provide a number in a range from 1 to 100.");

            if (num == 1) return PrimeFactorEnum.One;
            else if (num == 2 || num == 3) return PrimeFactorEnum.Prime;

            for (int i = 2; i <= half; i++)
                if (num % i == 0) return PrimeFactorEnum.Composite;

            return PrimeFactorEnum.Prime;
        }
    }
}