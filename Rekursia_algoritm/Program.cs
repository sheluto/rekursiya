//индексы меняются от нуля
//table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
//table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]
// по умолчанию для строк инициализация происходит такой вот константой:
//String.Empty

//Пример с массивом строк:

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";   //чтобы обратиться к нужному элементу, указываем наименование массива и индекс строки и столбца

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// Пример с матрицей чисел:

// int[,] matrix = new int[3, 4];


// for (int i = 0; i < 3; i++)    //внешний цикл (щелкающий строки)
// {
//     for (int j = 0; j < 4; j++) //внутренний цикл (щелкающий столбцы)
//     {
//         Console.Write($"{matrix[i, j]} "); //выводим все элементы столбиков через пробел
//     }
// Console.WriteLine();  //переход на новую строку
// }

//Пример печати матрицы с использованием метода:

void PrintArray(int[,] matr) //в качестве аргумента передаем прямоугольную таблицу чисел

{
    for (int i = 0; i < matr.GetLength(0); i++)    //внешний цикл (щелкающий строки)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //внутренний цикл (щелкающий столбцы)
        {
            Console.Write($"{matr[i, j]} "); //выводим все элементы столбиков через пробел
        }
        Console.WriteLine();  //переход на новую строку
    }
}

void FillArray(int[,] matr) //заполняем массив случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)    //внешний цикл (щелкающий строки)
    {
        for (int j = 0; j < matr.GetLength(1); j++) //внутренний цикл (щелкающий столбцы)
        {
            matr[i, j] = new Random().Next(1,10); //заполняем массив случайными числами
        }
        Console.WriteLine();  //переход на новую строку
    }
}

int[,] matrix = new int[3, 4]; //инициализация массива

PrintArray(matrix); //вызов печати матрицы
FillArray(matrix);
PrintArray(matrix);