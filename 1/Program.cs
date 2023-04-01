// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите элементы массива через пробел: ");
string elements=Console.ReadLine();
int[]massive=GetArrayFromString(elements);
int[]array=Find(massive);
Console.WriteLine($" [{string.Join(" , " ,massive)}]->[{string.Join("," , array)}]");

int[] GetArrayFromString(string stringArray)
{
     string[] numbers=stringArray.Split(" ",StringSplitOptions.RemoveEmptyEntries);
     int[]res=new int[numbers.Length];
     for(int i=0;i<numbers.Length;i++)
     {
       res[i]=int.Parse(numbers[i]);
     }
     return res;
}
int[] Find(int[] mass)
{
    int[]result=new int[mass.Length];
    
    for( int i=0;i<mass.Length;i++)
    {
       int count=0;
       while(mass[i]>0)
       {
          count=mass[i]%10;
          mass[i]=mass[i]/10;
          count++;
          if(count<=3)
          {
            result[i]=mass[i];
          }
       }
    }
    return result;
}

