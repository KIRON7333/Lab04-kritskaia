
int age = 20;
if (age >= 21)
{
Console.WriteLine("Доступ разрешён");
}

Console.WriteLine("Программа продолжает работу");

int age = 15;

if (age >= 18)
{
Console.WriteLine("Доступ разрешён");
}
else
{
Console.WriteLine("Доступ запрещён");

int yearsLeft = 18 - age;
Console.WriteLine($"До совершеннолетия осталось ждать: {yearsLeft} л.");
}

int age = 65;

if (age < 13)
{
Console.WriteLine("Ребёнок");
}
else if (age < 18)
{
Console.WriteLine("Подросток");
}
else if (age >= 60)
{
Console.WriteLine("Пенсионер");
}
else
{
Console.WriteLine("Взрослый");
}

int age = 12;
double height = 1.40;

bool hasAdultAccompaniment = true;
if ((age >= 14 && height >= 1.5) || (height < 1.5 && hasAdultAccompaniment))
{
Console.WriteLine("Можно кататься");
}
else
{
Console.WriteLine("Пока нельзя");
}
Console.Write("игрок 1 вводит: К - Камень, Н - Ножницы, Б - Бумага:     ");
string p1 = Console.ReadLine().Trim();

Console.Write("игрок 2 вводит: К - Камень, Н - Ножницы, Б - Бумага:     ");
string p2 = Console.ReadLine().Trim();

if ((p1 != "К" && p1 != "Н" && p1 != "Б") || (p2 != "К" && p2 != "Н" && p2 != "Б"))
{
    Console.WriteLine("Ошибка ввода");
}

else if (p1 == p2)
{
    Console.WriteLine("Ничья");
}
else if ((p1 == "К" && p2 == "Н") || (p1 == "Н" && p2 == "Б") || (p1 == "Б" && p2 == "К"))
{
    Console.WriteLine("Игрок 1 победил");
}
else
{
    Console.WriteLine("Игрок 2 победил");
}
