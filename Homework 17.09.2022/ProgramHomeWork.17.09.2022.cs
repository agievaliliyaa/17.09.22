using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{
    class Program
    {
       public enum drinkingcategories
        {
            a, // Студент-алкоголик
            b, // Любитель выпить, но не алкоголик
            c, // Пьет по праздникам
            d  // Студент не пьет
        }
        public struct thirdtaskuser
        {
            public string name3;
            public string city3;
            public int date3;
            public int pin3;
            public thirdtaskuser(string name, string city, int date3, int pin3)
            {
                this.name3 = name;
                this.city3 = city;
                this.date3 = date3;
                this.pin3 = pin3;

            }
            public void Print()
            {
                Console.WriteLine($"Имя пользователя: {name3} Город:{city3} Дата рождения: {date3} PIN-код: {pin3} ") ;
            }
        }
        public struct drunkstudents
        {
            public string firstname;
            public string secondname;
            public int id;
            public string dateofbirth;
            public drinkingcategories categories;
            public int amountalco;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание #1. Создать структуру студента с учетом степени алкоголизма. Создать 5 студентов с различными параметрами");
            drunkstudents liliya = new();
            liliya.firstname = "Лилия";
            liliya.secondname = "Агиева";
            liliya.id = 1;
            liliya.dateofbirth = "05.02.2004";
            liliya.categories = 0;
            liliya.amountalco = 3;
            double procentl = 3/(28)*100;
            Console.WriteLine($"{liliya.id} - {liliya.firstname} {liliya.secondname}. Дата рождения: {liliya.dateofbirth}. Категория алкоголизма: {liliya.categories}. Литров алкоголя выпито в семестре: {liliya.amountalco}. Процент выпитого от общего количества: {procentl} %");

            drunkstudents darya = new();
            darya.firstname = "Дарья";
            darya.secondname = "Макарова";
            darya.id = 2;
            darya.dateofbirth = "05.05.2004";
            darya.categories = 0;
            darya.amountalco = 1;
            double procentd = 1 / (28) * 100;
            Console.WriteLine($"{darya.id} - {darya.firstname} {darya.secondname}. Дата рождения: {darya.dateofbirth}. Категория алкоголизма: {darya.categories}. Литров алкоголя выпито в семестре: {darya.amountalco}. Процент выпитого от общего количества: {procentd} %");

            drunkstudents marya = new();
            marya.firstname = "Марья";
            marya.secondname = "Дакарова";
            marya.id = 3;
            marya.dateofbirth = "06.05.2004";
            marya.categories = 0;
            marya.amountalco = 5;
            double procentm = 5 / (28) * 100;
            Console.WriteLine($"{marya.id} - {marya.firstname} {marya.secondname}. Дата рождения: {marya.dateofbirth}. Категория алкоголизма: {marya.categories}. Литров алкоголя выпито в семестре: {marya.amountalco}. Процент выпитого от общего количества: {procentm} %");

            drunkstudents kirill = new();
            kirill.firstname = "Кирилл";
            kirill.secondname = "Иванов";
            kirill.id = 4;
            kirill.dateofbirth = "07.05.2004";
            kirill.categories = 0;
            kirill.amountalco = 9;
            double procentk = 9 / (28) * 100;
            Console.WriteLine($"{kirill.id} - {kirill.firstname} {kirill.secondname}. Дата рождения: {kirill.dateofbirth}. Категория алкоголизма: {kirill.categories}. Литров алкоголя выпито в семестре: {kirill.amountalco}. Процент выпитого от общего количества: {procentk} %");

            drunkstudents nikita = new();
            nikita.firstname = "Никита";
            nikita.secondname = "Пивкин";
            nikita.id = 5;
            nikita.dateofbirth = "09.05.2004";
            nikita.categories = 0;
            nikita.amountalco = 10;
            double procentn = 10 / 28 * 100;
            Console.WriteLine($"{nikita.id} - {nikita.firstname} {nikita.secondname}. Дата рождения: {nikita.dateofbirth}. Категория алкоголизма: {nikita.categories}. Литров алкоголя выпито в семестре: {nikita.amountalco}. Процент выпитого от общего количества: {procentn} %");



            Console.WriteLine("Домашнее задание #2. Вывести на экран информацию о каждом типе данных");
            Console.WriteLine($"Byte - Максимальное значение: {byte.MaxValue} - Минимальное значение: {byte.MinValue}");
            Console.WriteLine($"Sbyte - Максимальное значение: {sbyte.MaxValue} - Минимальное значение: {sbyte.MinValue}");
            Console.WriteLine($"Short - Максимальное значение: {short.MaxValue} - Минимальное значение: {short.MinValue}");
            Console.WriteLine($"Ushort - Максимальное значение: {ushort.MaxValue} - Минимальное значение: {ushort.MinValue}");
            Console.WriteLine($"Int - Максимальное значение: {int.MaxValue} - Минимальное значение: {int.MinValue}");
            Console.WriteLine($"Uint - Максимальное значение: {uint.MaxValue} - Минимальное значение: {uint.MinValue}");
            Console.WriteLine($"Long - Максимальное значение: {long.MaxValue} - Минимальное значение: {long.MinValue}");
            Console.WriteLine($"Ulong - Максимальное значение: {ulong.MaxValue} - Минимальное значение: {ulong.MinValue}");
            Console.WriteLine($"Float - Максимальное значение: {float.MaxValue} - Минимальное значение: {float.MinValue}");
            Console.WriteLine($"Double - Максимальное значение: {double.MaxValue} - Минимальное значение: {double.MinValue}");
            Console.WriteLine($"Decimial - Максимальное значение: {decimal.MaxValue} - Минимальное значение: {decimal.MinValue}");


            Console.WriteLine("Домашнее задание #3. Написать программу, которая принимает информацию от пользователя и распечатывает информацию в правильном формате");
            Console.WriteLine("Введите имя пользователя ");
            thirdtaskuser user1 = new();
            user1.name3 = Console.ReadLine();
            Console.WriteLine("Введите город проживания ");
            user1.city3 = Console.ReadLine();
            Console.WriteLine("Введите свой возраст ");
            user1.date3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите PIN-код ");
            user1.pin3 = int.Parse(Console.ReadLine());
            user1.Print();

            Console.WriteLine("Домашнее задание #4. Программа, преобразующая имя в иинициалы.");
            Console.WriteLine("Введите имя и фамилию");
            string[] namee = Console.ReadLine().Split(' ');
            Console.WriteLine($"{namee[0][0].ToString().ToUpper()}.{namee[1][0].ToString().ToUpper()}");

            Console.WriteLine("Домашнее задание #5. Виски в DutyFree");
            Console.WriteLine("Введите сумму, которую планируете потратить на отпуск ");
            int holiday = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за бутылку виски ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент скидки в DutyFree ");
            int sale = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество бутылок, которое вам нужно преобрести: {holiday / price * sale / 100 }");

            Console.WriteLine("Домашнее задание #6. Скорость таракана");
            Console.WriteLine("Введите скорость в км/ч");
            double speed = double.Parse(Console.ReadLine());
            Console.WriteLine($"Решение: {Math.Round((speed * 100000 / 3600))} см/с");

            Console.WriteLine("Домашнее задание #7. Преобразовать строчные буквы в заглавные, заглавные в строчные");
            Console.WriteLine("Напишите хоть что-нибудь");
            string anythingIN = Console.ReadLine();
            StringBuilder anythingOUT = new();
            foreach (Char c in anythingIN.ToCharArray())
            {
                if (Char.IsLower(c))
                {
                    anythingOUT.Append(Char.ToUpper(c));
                }
                else
                {
                    anythingOUT.Append(Char.ToLower(c));
                }
             
            }
            Console.WriteLine(anythingOUT);


        }
    }
}