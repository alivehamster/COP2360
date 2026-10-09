class Program
{

  static int Divide(string input1, string input2)
  {
    int number1 = int.Parse(input1);
    int number2 = int.Parse(input2);
    return number1 / number2;
  }

  static void Main()
  {
    Console.WriteLine("Enter 2 numbers to divide");
    Console.Write("Enter a number: ");
    string input1 = Console.ReadLine();
    Console.Write("Enter another number: ");
    string input2 = Console.ReadLine();

    try
    {
      int result = Divide(input1, input2);
      Console.WriteLine("Result: " + result);
    }
    catch (DivideByZeroException)
    {
      Console.WriteLine("Failed to divide by zero.");
    }
    catch (FormatException)
    {
      Console.WriteLine("Please only enter numbers.");
    }
    catch (Exception ex)
    {
      Console.WriteLine("An unexpected error occurred: " + ex.Message);
    }
  }
}