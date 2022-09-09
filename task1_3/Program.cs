//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string)
Console.Write("Введите пятизначное число:  ");
int num = Convert.ToInt32(Console.ReadLine());

int digit_1 = num / 10000;
int digit_2 = (num / 1000) % 10;
int digit_4 = (num / 10) % 10;
int digit_5 = num % 10;
if (digit_1 == digit_5 && digit_2 == digit_4)
{
	Console.Write("Палиндром");
}
else
{
	Console.Write("Не палиндром");
}
