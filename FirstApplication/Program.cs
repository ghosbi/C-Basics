using System; // Подключенное пространство имен
using System.Threading.Channels;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
    class Program // Объявление класса Program
    {
        static void Main(string[] args) // Объявление метода Main
        {
            bool HaveIApet = true;
            double MyShoesSize = 42;

            Console.WriteLine("Как тебя зовут?");
            object name = Console.ReadLine();
            Console.WriteLine("Мое имя:" +  name);
            Console.WriteLine("Сколько тебе лет?");
            int age = 24;
            Console.WriteLine("Мне:" + age);
            Console.WriteLine("Есть ли у меня питомец?"+ HaveIApet);
            Console.WriteLine("Мой размер обуви:" + MyShoesSize);




        }
    }
}