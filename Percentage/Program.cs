//Задание 2
//Пользователь вводит с клавиатуры два числа. Первое 
//число — это значение, второе число процент, который 
//необходимо посчитать. Например, мы ввели с клавиатуры 
//90 и 10. Требуется вывести на экран 10 процентов от 90. 
//Результат: 9.

int k;
do
{
    Console.WriteLine("Input number");
    double num = double.Parse(Console.ReadLine());
    Console.WriteLine("Input percentage");
    double per = double.Parse(Console.ReadLine());
    Console.WriteLine("Result:");
    Console.WriteLine((num/100)*per);
    Console.WriteLine("Input key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;

