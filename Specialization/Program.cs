string[] arg1 = new string[5] {"567", "789", "hello", "world", ":)"};
string[] arg2 = new string[arg1.Length];
void ArrayFormation(string[] arg1, string[] arg2)
{
    int count = 0;
    for (int i = 0; i < arg1.Length; i++)
    {
    if(arg1[i].Length <= 3)
        {
        arg2[count] = arg1[i];
        count++;
        }
    }
}
void PrintArray(string[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write($"{arg[i]} ");
    }
    Console.WriteLine();
}
ArrayFormation(arg1, arg2);
PrintArray(arg2);
