double num1 = 0;
double num2 = 0;
string operation = "";
int count = 0;



while (count < 3)
{
    Console.WriteLine();
    Console.WriteLine($"step: {count+1}");

    Console.WriteLine();

    num1 = 0;
    num2 = 0;

    try
    {
        Console.Write("input first number:");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine();


        Console.Write("what operation do you want to do:");
        operation = Console.ReadLine();
        Console.WriteLine();

        Console.Write("input second number:");
        num2 = double.Parse(Console.ReadLine());

        count++;
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        continue;
    }

    //(+,-,*,/)

    switch (operation)
    {
        case "*":
            Console.WriteLine($"{num1} {operation} {num2}  =  {num1 * num2}");
            break;
        case "/":
            Console.WriteLine($"{num1} {operation} {num2}  =  {num1 / num2}");
            break;
        case "+":
            Console.WriteLine($"{num1} {operation} {num2}  =  {num1 + num2}");
            break;
        case "-":
            Console.WriteLine($"{num1} {operation} {num2}  =  {num1 - num2}");
            break;
        default:
            Console.WriteLine("invalide operation");
            break;
    }

    
}







