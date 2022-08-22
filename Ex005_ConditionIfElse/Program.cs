Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //Переводит все буквы вводимой строки в нижний регистр и теперь не принципиально как именно написано имя пользователя. Маша будет распозана и поприветствована.
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
