using System;

class Program
{
    static void Main()
    {
        // объявление переменных
        double a = 3.5;
        double b = 4.2;
        double c = 5.1;

        // объявление переменной и вызов функции
        double perimetr = CalculateTrianglePerimeter(a, b, c);
        // выводим значение периметра
        Console.WriteLine("Периметр треугольника: " + perimetr);

        double weight = 70.5;
        double height = 1.75;

        // вызываем функцию подсчета ИМТ
        double imt = CalculateBMI(weight, height);
        Console.WriteLine("Индекс массы тела: " + imt);
    }

    // объявление функции подсчета периметра
    static double CalculateTrianglePerimeter(double a, double b, double c)
    {
        // считаем периметр
        double p = a + b + c;
        // возвращаем периметр
        return p;
    }

    static double CalculateBMI(double weight, double height)
    {
        // считаем имт
        double imt = weight / (height * height);
        // возвращаем имт
        return imt;
    }
}