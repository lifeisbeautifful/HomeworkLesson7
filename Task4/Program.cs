using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
 Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три закрытых поля для описания сторон треугольника и 
    три свойства для чтения и записи. Также в теле класса создайте 3 метода: 1-й для расчета площади треугольника, формула для расчета 
    S =√(p*(p-a)* (p-b)* (p-c) ), где p - полупериметр треугольника p=(a+b+c)/2, a, b, c – длины сторон треугольника, 2-й для расчета
    периметра треугольника, формула для расчета p = (a + b + c) / 2 и 3-й для вывода информации о площади и периметре треугольника.
    Создайте конструктор, который в качестве аргументов приминимает стороны треугольника и инициализирует поля класса.В методе Main() 
    создайте экземпляр класса «Треугольник», задайте произвольное значение сторон треугольника и выведите на экран значение периметра
    и площади треугольника. */


    class Program
    {
        static void Main(string[] args)
        {
            Triangles triangle = new Triangles(3,5,6);
            triangle.squareAndPerimInfo();
            Console.ReadLine();
        }
    }
    class Triangles
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangles(int fSide,int sSide,int tSide)
        {
            FirstSide = fSide;
            SecondSide = sSide;
            ThirdSide = tSide;
        }
        public double Square()
        {
            double p = Perim();
            double square = Math.Sqrt(p*(p - FirstSide)*(p-SecondSide)*(p-ThirdSide));
            return square;
        }
        public double Perim()
        {
            return (FirstSide + SecondSide + ThirdSide) / 2;
        }
        public void squareAndPerimInfo()
        {
            Console.WriteLine("The square = {0} and perimeter = {1}",Math.Round(Square(),2),Math.Round(Perim(),2));
        }
    }
}
