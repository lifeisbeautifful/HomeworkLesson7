using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс «Точка» – для описания координат точки на координатной прямой рис №1. В теле класса 
    создайте следующие закрытые поля: целочисленное поле для описания координаты точки X и целочисленное поле для описания координаты
    точки Y, а также строковое поле для имени точки.Создать три свойства с методами доступа get и set, а также конструктор класса, 
    который будет инициализировать данные поля значениями аргументов.Далее создайте класс «Фигура». В теле класса фигура создайте одно 
    поле типа масив «Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3 (треугольника) и 4 аргумента 
    (четырехугольника). В теле класса «Фигура» создайте два метода: 1-й для расчета длины стороны фигуры, метод должен принимать 2 
    аргумента типа «Точка» и возвращать длину стороны, формула для расчета d =√(〖(x_2-x_1)〗^2+ 〖(y_2-y_1)〗^2 )  и метод для расчета 
    периметра фигуры(подсказка – в методе циклом перебирать массив «Точек», пока в нем будут элементы, и рассчитывать длину стороны). 
    В методе Main() создать и рассчитать периметр треугольника, квадрата, прямоугольника, точки выбрать произвольные.*/

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(1, 0);
            Point p5 = new Point(2, 1);
            Point p6 = new Point(2, 0);

            Figure square = new Figure(p1,p2,p3,p4);
            square.Perim();

            Figure triangle = new Figure(p1, p2, p4);
            triangle.Perim();

            Figure rectangle = new Figure(p1, p2, p5, p6);
            rectangle.Perim();

            Console.ReadLine();
        }
    }
    class Point
    {
        private int x;
        private int y;
        private string name;
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public Point(int xValue, int yValue)
        {
            X = xValue;
            Y = yValue;
        }
    }
    class Figure
    {
        Point[] points=new Point[4];
        
        private string name;
        public Figure(Point first,Point second,Point third)
        {
           points[0] = first;
           points[1] = second;
           points[2] = third;
           points[3] = third;
        }
       public Figure(Point first,Point second,Point third,Point four) :this(first,second,third)
        {
           points[3] = four;
        }
        public double SideLength(Point p1,Point p2)
        {
            double sideLength =Math.Sqrt(Math.Pow((p2.X-p1.X),2)+Math.Pow((p2.Y-p1.Y),2));
            return sideLength;
        }
       public void Perim()
        {
            double sum = 0;
            for (int i = 0; i < points.Length-1; i++)
            {
               double side = SideLength(points[i], points[i + 1]);
               sum = sum + side;
            }
            double lastSide = SideLength(points[points.Length - 1], points[0]);
            Console.WriteLine("Perimeter = {0}",Math.Round(sum+lastSide,2));
        }
    }
}
