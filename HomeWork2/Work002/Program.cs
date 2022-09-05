//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int aNumber = Convert.ToInt32(Console.ReadLine());
string aNumberText = Convert.ToString(aNumber);
if (aNumberText.Length >2)
{
    Console.WriteLine("Третья цифра -> " + aNumberText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}