/*

// Задача 1. Вывести квадрат вводимого числа.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("Result is: " + result);

*/

/*

// Задача 2. Программа которая на вход принимает два числа 
// и делает проверку - является ли первое число квадратом второго.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2; 

if(num1 == quad)
{
    Console.Write("First number is a quad of second number");    
}
else
{
    Console.Write("First number is NOT a quad of second number");
}

*/

// Задача 3. На входе вводится номер дня недели,
// а на выходе должен быть выведен название этого дня.
/*

Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
{
    Console.WriteLine("Incorrect number of day!");
}
else
{
    if(day == 1)
        Console.WriteLine("It's monday");
    if(day == 2)
        Console.WriteLine("It's tuesday");
    if(day == 3)
        Console.WriteLine("It's wednesday");
    if(day == 4)
        Console.WriteLine("It's thursday");
    if(day == 5)
        Console.WriteLine("It's friday");
    if(day == 6)
        Console.WriteLine("It's saturday");
    if(day == 7)
        Console.WriteLine("It's sunday");
}

*/

// Задача 4. На входе принимается число 'n', 
// а на выходе показываются все числа в промежутке от '-n' до '+n'.  

/*

Console.Write("Input integer number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current;

if(n < 0)
{
    current = n;
    n = n * (-1);
}
else
{
    current = -1 * n;
}

while (current <= n)
{
    Console.Write(current + " ");
    // current = current +1;
    current++;
}

*/

// Задача 5. Принимает на входе 3х значное число, 
// а на выходе показывает последнюю (самую младшую) цифру этого числа.

/*

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("Incorrect number");
else 
{
    int a = num % 10;
    Console.WriteLine("Resulted number is " + a);
}

*/