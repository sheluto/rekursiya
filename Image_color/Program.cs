﻿// закрашиваем замкнутый контур

void PrintImage(int[,] image) //в качестве аргумента передаем прямоугольную таблицу чисел

{
    for (int i = 0; i < image.GetLength(0); i++)    //внешний цикл (щелкающий строки)
    {
        for (int j = 0; j < image.GetLength(1); j++) //внутренний цикл (щелкающий столбцы)
        {
            //Console.Write($"{image[i, j]} "); //выводим все элементы столбиков через пробел
            if(image[i,j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();  //переход на новую строку
    }
}

int[,] pic = new int[,]; //инициализация массива (тут типа была заготовочка с массивом-картинкой)

PrintImage(pic); //вызов печати картинки

void FillImage(int row, int col) //метод который закрашивает картинку аргумент - пиксель с которого начинаем закраску
{
    if(pic[row,col] == 0) //если текущий пиксель не закрашен
    {
        pic[row, col] = 1; //красим единичкой
        FillImage(row-1, col);   //метод вызывает сам себя (рекурсия) и красит по алгоритму (вверх, влево, вниз, вправо)
        FillImage(row, col-1);   //РЕКУРСИЯ
        FillImage(row+1, col);   //РЕКУРСИЯ
        FillImage(row, col+1);   //РЕКУРСИЯ
    }
}


PrintImage(pic);
FillImage(13, 13);  //выбрали произвольную точку внутри фигуры, от которой начинаем закрашивать
PrintImage(pic);
