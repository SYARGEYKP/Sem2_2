// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int InputInt(string massage)
{
    Console.WriteLine(massage);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
int number = InputInt("Введите  число");

if (number / 100 == 0)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
    }
    System.Console.WriteLine($"Третья цифра {number % 10}");
}