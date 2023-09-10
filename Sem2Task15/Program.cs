// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

Dictionary<string, string> dayOfWeek = new Dictionary<string, string>();
for(int i=1; i<8; i++)
{
          dayOfWeek.Add(i.ToString(),i<6?"рабочий":"выходной"); 
}


Console.WriteLine("Введите цифру, обозначающую день недели");
string dayNum = Console.ReadLine()??"0";
if(dayOfWeek.ContainsKey(dayNum))
{
    Console.WriteLine(dayOfWeek[dayNum]);
}
else
{
    Console.WriteLine("Задан некорректный номер");
}