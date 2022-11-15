// Задача 40: Напишите программу, которая принимает на вход три числа 
//и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Console.WriteLine("Введите первое число");
// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int number2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите третье число");
// int number3 = int.Parse(Console.ReadLine());

// Console.WriteLine(Result(number1, number2, number3));

// string Result(int a, int b, int c)
// {
//     string res = "";
//     if (a < b + c && b < a + c && c < a + b)
//     {
//        res = $"треугольник с указаными сторонами существует";
//     }
//     else
//     {
//         res = $"треугольник с указаными сторонами НЕ существует";
//     }
//     return res;
// }


















// Задача 42: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());
string nums = TurnTo2(number);
ReversArray(nums);
Console.Write(nums);



 string TurnTo2 (int num)
{
    string nums = "";
    while(num > 0)
    {
         if (num%2 == 0) nums = nums + "0";
         else nums = nums + "1";
         num = num/2;
         Console.WriteLine($"{num} ");
    }
    return nums;

}

void ReversArray(string nums)
{
    for(int i=0; i<nums.Length/2; i++)
    {
        char k = nums[i];
        nums[i] = nums[nums.Length-1 -i];
        nums[nums.Length-1 -i] = k;
    }
}

void PrintArray(string nums)
{
    for(int i = 0; i<nums.Length; i++)
    {
        Console.Write($"{num[i]} ");
    }
}
