﻿// Задача №3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.


Console.WriteLine("Напишите номер дня");
int day = int.Parse(Console.ReadLine()??"0"); 
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Чертверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Суббота";
dayOfWeek[6] = "Воскресенье";

Console.WriteLine(dayOfWeek[day-1]);

//Еще один вариант решения
// Console.WriteLine("Enter day number");
// int dayNum = int.Parse(Console.ReadLine());
// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));

// Console.WriteLine(outDayOfWeek);