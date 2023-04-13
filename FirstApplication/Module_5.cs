using System;

class MainClass
{

    static void ShowColor()
    {
        Console.WriteLine("�������� ���� ������� ���� �� ���������� � ��������� �����");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }
    }

    public static void Main(string[] args)
    {

        var (name, age) = ("�������", 27);

        Console.WriteLine("��� ���: {0}", name);
        Console.WriteLine("��� �������: {0}", age);

        Console.Write("������� ���: ");
        name = Console.ReadLine();
        Console.Write("������� ������ � �������:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("���� ���: {0}", name);
        Console.WriteLine("��� �������: {0}", age);

        ShowColor();


    }
}