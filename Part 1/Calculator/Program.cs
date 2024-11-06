
Console.WriteLine("Hello!");
Console.Write("Input the first number: ");
int input = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the second number: ");
int input2 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string userChoice = Console.ReadLine();

if (userChoice.ToUpper() == "A")
{
    int result = input + input2;
    PrintResult(input, input2, result, "+");
}
else if (userChoice.ToUpper() == "S")
{
    int result = input - input2;
    PrintResult(input, input2, result, "-");
}
else if (userChoice.ToUpper() == "M")
{
    int result = input * input2;
    PrintResult(input, input2, result, "*");
}
else Console.WriteLine("Invalid option");

void PrintResult(int input, int input2, int result, string @operator)
{
    Console.WriteLine(input + " " + @operator + " " + input2 + " = " + result); //refactored code
}
