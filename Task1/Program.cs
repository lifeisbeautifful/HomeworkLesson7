using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson7
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Адрес». 
В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо создать метод для отображения информации про адрес.
 В методе Main() создайте экземпляр класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр класса 
 вызовите метод, который выводит информацию про адрес.*/

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Country = "Ukraine";
            address.City = "Ternopil";
            address.Street = "Schevchenka";
            address.HouseNumber = "23a";
            address.Flat = "1a";
            address.Index = 81400;

            address.GetAddress();
            Console.ReadLine();
        }
    }

    class Address
    {
        private string country;
        private string city;
        private string street;
        private string houseNumber;
        private string flat;
        private int index;
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Flat { get; set; }
        public int Index { get; set; }
        public void GetAddress()
        {
            Console.WriteLine("Country: "+Country);
            Console.WriteLine("City: "+City);
            Console.WriteLine("Street: "+Street);
            Console.WriteLine("House: "+HouseNumber);
            Console.WriteLine("Flat: "+Flat);
            Console.WriteLine("Index: "+Index);
        }
    }
}


