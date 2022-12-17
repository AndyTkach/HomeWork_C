Console.WriteLine ("Введите первое целое число: ");
string userInput1 = Console.ReadLine () ?? "";
Console.WriteLine ("Введите второе целое число: ");
string userInput2 = Console.ReadLine () ?? "";
Console.WriteLine ("Введите третье целое число: ");
string userInput3 = Console.ReadLine () ?? "";

Console.WriteLine ("Спасибо!");

int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);
int number3 = int.Parse(userInput3);

int max = 0;
int finMax = 0;

if (number1 > number2)
{
    max = number1;
        if (max > number3)
            {max = finMax;
            Console.WriteLine($"{number1},{number2},{number3} -> {finMax}");
            }
        else
        {
            finMax = number3;
            Console.WriteLine($"{number1},{number2},{number3} -> {finMax}");
        }

}
else
{
    max = number2;
    if (max > number3)
    {
        max = finMax;
        Console.WriteLine($"{number1},{number2},{number3} -> {finMax}");
    }
    else
    {
        finMax = number3;
        Console.WriteLine($"{number1},{number2},{number3} -> {finMax}");  
    }
}