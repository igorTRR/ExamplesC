
Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //ToLower() - убирает все варианты маша (Маша=мАша =МАша итд)
{
    Console.WriteLine("Yes! это МАША!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(username );
}
