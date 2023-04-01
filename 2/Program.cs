Console.WriteLine("Введите элементы массива через пробел: ");
string elements=Console.ReadLine();
int[]massive=GetArrayFromString(elements);
int[]array=Find(massive);
Console.WriteLine($"[{String.Join("," ,massive)}]->[{String.Join("," ,array)}]");

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
  int []result=new int[mass.Length];
  int count=0;
  for(int i=0;i<mass.Length;i++)
  {
    if(mass[i] > 0)
    {
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

 
