Console.WriteLine ("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";
Console.WriteLine ("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);

int max = 0;
int min = 0;

if (number1 > number2) 
{
   max = number1;
   min = number2;
   Console.WriteLine ($"a = {number1}, b = {number2}, -> max = {max}, min = {min}");
}
else 
{
    max = number2;
    min = number1;
    Console.WriteLine ($"a = {number1}, b = {number2}, -> max = {max}, min = {min}");
}




