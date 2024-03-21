namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Func<double, double, double> add = (x, y) => x + y;
            Func<double, double, double> mult = (x, y) => x * y;

            Console.WriteLine($"Addition calculation: {add(num1, num2)}");
            Console.WriteLine($"Multiplication calculation: {mult(num1, num2)}");

            Func<double, double, double> lesser = (x, y) =>
            {
                if (x < y)
                {
                    return x;
                }
                else
                    return y;
            };
            Console.WriteLine($"Smaller number: {lesser(num1, num2)}");
        }
    }
}
