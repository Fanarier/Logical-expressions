//2.1.Логические выражения. Плотников Кирилл Андреевич 22-ИСП-2/2
//№варианта: 16, Записать условие, которое является истинным, когда только одно из чисел X,Y и Z кратно пяти.

try
{

Console.ForegroundColor = ConsoleColor.Green;
   
Console.WriteLine("Введите X:");
Double X = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Y:");
Double Y = double.Parse(Console.ReadLine());
Console.WriteLine("Введите Z:");
Double Z = double.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkBlue;

long a = (long)(X * Y * Z);
if ((a % 5 == 0) && (a % 25 != 0)) Console.WriteLine("только одно из чисел X,Y и Z кратно пяти");
else Console.WriteLine("не подходит под условия");

Console.ForegroundColor = ConsoleColor.Green;

}
catch (Exception ex)
{ Console.WriteLine(ex.ToString()); }