using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        public enum banking
        {
            current,
            savings
        }
        public struct BankingSystem
        {
            public string name;
            public banking bankingtype;
            public double cash;

        }
        public enum university
        {
            KFU,
            KAI,
            KNRTU

        }
        public struct universityform
        {
            public string employeename;
            public university employeeuni;
        }
            

        static void Main(string[] args)
        {

            Console.WriteLine("Классная работа #1.Создать перечислимый тип данных, отображающий виды банковского счета (теккущий и сберегательный). Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать");
            banking now = banking.current;
            Console.WriteLine($"Вид банковского счета - {now}, номер - {1}", now, (int)now);   // что здесь происходит



            Console.WriteLine("Классная работа #2. Создать структуру данных, которая хранит информацию о банковском счете - его номер, тип и баланс. Создать переменную такого типа, заполнить структуру значениями и напечатать результат");
            BankingSystem tom = new();
            tom.name = "Tom";
            tom.bankingtype = 0;
            tom.cash = 1000;
            Console.WriteLine($"Имя - {tom.name}, тип счета - {tom.bankingtype}, баланс - {tom.cash}");
            


            Console.WriteLine("Классная работа #3. Создать перечислимый тип ВУЗ. Создать структуру работник. Заполнить структуру данными.");
            universityform sidorov = new();
            sidorov.employeename = "Сидоров Анатолий Михайлович";
            sidorov.employeeuni = 0;
            Console.WriteLine($" Работник {sidorov.employeename} из {sidorov.employeeuni}");

        }
        
        
        
       


    }
}

 
   













