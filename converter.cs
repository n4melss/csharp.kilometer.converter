public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter your amount of kilometers: ");

        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers / 1.6;

        Console.WriteLine(kilometers + " kilometers are the same as " + miles + " miles!");
    }
}