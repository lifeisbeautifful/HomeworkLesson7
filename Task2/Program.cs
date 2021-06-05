using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Котенок». 
В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого поля, создать свойство с двумя методами доступа.
    Также в теле класса создайте метод, который будет выводить на консоль «Мяу», метод должен принимать один аргумент – количество «Мяу» 
    котенка, выводить «Мяу» соответствующее количество раз.В методе Main() создайте экземпляр класса «Котенок», присвойте всем полям 
    значение через свойства доступа, а также вызовите метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода передайте 
    3.*/

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Barsik";
            cat.Age = 5;
            cat.CoatColor = "Black";
            cat.EyeColor = "Green";

            cat.sayMay(3);
            Console.ReadLine();
        }
    }

    class Cat
    {
        private string name;
        private int age;
        private string coatСolor;
        private string eyeColor;
        public string Name { get; set; }
        public int Age { get; set; }
        public string CoatColor { get; set; }
        public string EyeColor { get; set; }

        public void sayMay(int counter) 
        {
            while (counter > 0)
            {
                Console.WriteLine("May");
                counter--;
            }
        }
    }
}
