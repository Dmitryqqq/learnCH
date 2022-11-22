Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // строчными !!
{
Console.WriteLine("Ура, это же Маша! ");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);

}

