using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Банковский Счет». 
В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету, сумма счета.  В теле метода создайте
    следующие методы: Метод, который рассчитывает количество дней, начиная с даты открытия счета; Метод который выводит информацию о 
    количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете через определенное количество лет
    (количество лет – параметр метода); Метод который выводит информацию о сумме.Также продумать над конструктором класса.
    В методе Main() создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства доступа, а также на
    экземпляр класса вызовите методы для отображения количества дней и суммы.*/

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(new DateTime(2021,6,1),6.45,3000);
            account.countedDays();
            account.printFutureProfit(3);

            Console.ReadLine();  
        }
    }
    class BankAccount
    {
        private DateTime date;
        private double interest;
        private double accountSum;
        public DateTime Date { get; set; }
        public double Interest{get;set;}
        public double AccountSum { get; set; }
        
       public BankAccount(DateTime Date, double Interest,double AccountSum)
        {
            this.Date = Date;
            this.Interest = Interest;
            this.AccountSum = AccountSum;
        }
       public int dayCount()
        {
            TimeSpan timeSpan = DateTime.Now - Date;
            return timeSpan.Days;
        }
       public void countedDays()
        {
            Console.WriteLine("Account was created {0} days ago",dayCount());
        }
       public double countFutureProfit(int enteredYears)
        {
            double interestSum = AccountSum * Interest / 100;
            AccountSum = AccountSum + interestSum;
            
            if (enteredYears > 0)
            {
                return countFutureProfit(enteredYears-1);
            }
            else
            {
                return AccountSum-interestSum;
            } 
        }
       public void printFutureProfit(int years)
        {
            Console.WriteLine("{0} will be on account after {1} years",Math.Round(countFutureProfit(years),2),years);
        }
    }
}
