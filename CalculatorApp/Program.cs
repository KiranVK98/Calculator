class Program
{
    public static void Main(String[] args)
    {
        Calculator calculate = new Calculator();
        Console.WriteLine("Enter number 1");
        double val1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Operator - +,-,*,/");
        string op = Console.ReadLine();

        Console.WriteLine("Enter number 2");
        double val2 = Convert.ToDouble(Console.ReadLine());

        try 
        {
            double result = calculate.Execute(op,val1,val2);
            Console.WriteLine($"The result of the operation is {result}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error{ex.Message}");
        }
    }
}