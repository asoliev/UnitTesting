// See https://aka.ms/new-console-template for more information
using UnitTesting.Tasks;

Console.WriteLine("Hello, World!");

Console.Write("\nEnter the Number within specified range from 1 to 100 to check Prime factor, Odd/Even and FizzBuzz (divisibility by 3 and 5): ");

try
{
    if (!int.TryParse(Console.ReadLine(), out int num))
        throw new FormatException("input is not an integer");

    Console.WriteLine(PrimeFactor.CheckPrimeComposite(num));

    Console.WriteLine(FizzBuzz.ReplaceWithFizzBuzz(num));

    Console.WriteLine(OddEven.CheckOddEven(num));
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex);
}