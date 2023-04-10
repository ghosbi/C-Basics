using System; // Подключенное пространство имен
using System.Threading.Channels;

namespace FirstApplication.ConsoleApp // Объявление пространства имен для данного кода
{
	class Program // Объявление класса Program
	{
		static void Main(string[] args) // Объявление метода Main
		{
			var arr = new int[] {5, 6, 7, 9, 1, 2, 3, 4};

			int a = 0;
			

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j <arr.Length; j++)
				if (arr[i] > arr[j])
				{
					a = arr[i];
					arr[i] = arr[j];
					arr[j] = a;

				}
				

			}
			foreach(var item in arr)
				{
					Console.Write(item);
				}
			Console.ReadKey();		}
		static void LearnArray()
		{
			int[,] array = { { 1, 2, 3}, { 5, 6, 7}, { 9, 10, 11} };

			for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
			{
				for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
				{
					Console.WriteLine(array[i,j] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
		static void ForName()
		{
			 string name = "Pavel";
			var name1 = "";
			for (int i = name.Length-1; i >= 0; i--)
			{
				name1 += name[i];
			}
			Console.WriteLine(name1);
			Console.ReadKey();
		}
		static void Colors()
		{
			Console.WriteLine("Цикл do while");
			int k = 0;

			do
			{
				Console.WriteLine(k);

				Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

				switch (Console.ReadLine())
				{
				  
				}
				k++;
			}
			while (k < 3);
		}
		static void Coloors()
		{
			Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
			var color = Console.ReadLine();

			if (color == "red")
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is red!");
			}

			else if (color == "green")
			{
				Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is green!");
			}

			else
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;

				Console.WriteLine("Your color is cyan!");
			}

		}
	}

}


