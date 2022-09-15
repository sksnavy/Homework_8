/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
и возвращает индексы этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/



double rnd_a_b (double a, double b) //Возвращает случайное вещественное число между a и b
{
  Random rand = new Random();
  return a + rand.NextDouble() * (b-a);
}
// Заполняет массив Rows х Columns случайными вещественными числами от a до b
void generate_rnd_m_n_double (ref double[,] A, ref int Rows, ref int Columns, ref double a, ref double b)
{
    A = new double [Rows, Columns];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
          A[i, j] = rnd_a_b (a,b);
        }
    }    
    return;
}
// Заполняет массив Rows х Columns случайными целыми числами от a до b
void generate_rnd_m_n_int (ref int[,] A, ref int Rows, ref int Columns, ref int a, ref int b)
{
    A = new int [Rows, Columns];

    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
          Random rand = new Random();  
          A[i, j] = rand.Next (a, b);
        }
    }    
    return;
}
//Выводит в консоли значения двумерного массива m x n
void console_write_m_n_double (double[,] A, int Rows, int Columns)
{
    for (int i = 0; i < Rows; i++)
    {
        Console.WriteLine($" ");
        for (int j = 0; j < Columns; j++)
        {
            Console.Write($" {A[i, j]}");
        }
    }    
    return;
} 
void console_write_m_n_int (int[,] A, int Rows, int Columns)
{
    for (int i = 0; i < Rows; i++)
    {
        Console.WriteLine($" ");
        for (int j = 0; j < Columns; j++)
        {
            Console.Write($" {A[i, j]}");
        }
    }    
    return;
} 

//-------------------------------------------------------------------------------------------------------------
Console.WriteLine("Введите номер задачи: 47, 50 или 52:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{

case 47: 
    {
        Console.WriteLine("Введите число m:");
        Console.Write("m= "); int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число n:");
        Console.Write("n= "); int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите вещественное число a:");
        Console.Write("a= "); double a = Convert.ToDouble(Console.ReadLine());           
        Console.WriteLine("Введите вещественное число b:");
        Console.Write("b= "); double b = Convert.ToDouble(Console.ReadLine());           

        double[,] Array = null;
        generate_rnd_m_n_double (ref Array, ref m, ref n, ref a, ref b);
        console_write_m_n_double (Array, m, n); 

        break;    
    } //Zadacha 47

case 50:
    {
        Console.WriteLine("Введите максимальное число m_max:");
        Console.Write("m_max= "); int m_max = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите максимальное число n_max:");
        Console.Write("n_max= "); int n_max = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите целое число a:");
        Console.Write("a= "); int a1 = Convert.ToInt32(Console.ReadLine());           
        Console.WriteLine("Введите целое число b:");
        Console.Write("b= "); int b1 = Convert.ToInt32(Console.ReadLine());     
        Console.WriteLine("Введите контрольное целое число P:");
        Console.Write("P= "); int P = Convert.ToInt32(Console.ReadLine()); 

        Random rand = new Random();  
        int m1 = rand.Next (1, m_max);
        int n1 = rand.Next (1, n_max);

        int[,] Array1 = null;
        generate_rnd_m_n_int (ref Array1, ref m1, ref n1, ref a1, ref b1);
        console_write_m_n_int (Array1, m1, n1); 

        Console.WriteLine();
        bool no = true; 

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
              if (Array1[i,j] == P) 
              {
                no = false;
                Console.Write($"индекс присутствующего в массиве целого числа Р: {i}");
                Console.WriteLine($", {j}");
              }
            }  
        }

        if (no) Console.WriteLine("Контрольного числа Р в массиве нет!");       

        break;
    } //Zadacha 50
 
case 52:
    {
        Console.WriteLine("Введите число m:");
        Console.Write("m= "); int m2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число n:");
        Console.Write("n= "); int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите целое число a:");
        Console.Write("a= "); int a2 = Convert.ToInt32(Console.ReadLine());           
        Console.WriteLine("Введите целое число b:");
        Console.Write("b= "); int b2 = Convert.ToInt32(Console.ReadLine());     

        int[,] Array2 = null;
        generate_rnd_m_n_int (ref Array2, ref m2, ref n2, ref a2, ref b2);
        console_write_m_n_int (Array2, m2, n2); 

        Console.WriteLine();

        for (int i = 0; i < n2; i++)
        {
            double ch=0;
            for (int j = 0; j < m2; j++)
            {
                ch = ch + Array2 [j,i];    
            }  
            Console.Write($"среднее арифметическое столбца {i}");
            Console.WriteLine($": {ch/m2}");
        }

        break;
    } //Zadacha 52

}