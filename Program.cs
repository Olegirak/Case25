// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int NumberOfNumber(int Osnova, int Step)
{
    int result = 1;
    for (int i = 1; i <= Step; i++)
    {
        result = Osnova * result;
    }
    return result;
}

int Osn = getUserDate("Введите значения основания");
int St = getUserDate("Введите значения степени");
int Stepen = NumberOfNumber(Osn, St);
Console.WriteLine(Stepen);
