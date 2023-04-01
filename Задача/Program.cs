// Написать программу ,которая из имеющегося массива строк 
// формирует массив из строк,
//длина который меньше либо равна 3 символа.
Console.WriteLine("Введите элементы массива через пробел: ");
string elements=Console.ReadLine();
int[]massive=GetArrayFromString(elements);
//int[]array=GetNewMassive(massive);
int[] GetArrayFromString(string simbols)
{
    string [] numbers =simbols.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[]res=new int[numbers.Length];

    for(int i=0;i<numbers.Length;i++)
    {
        res[i]=int.Parse(numbers[i]);
    }
    return res;
}

Console.WriteLine($" [{string.Join(" , " ,massive)}]");