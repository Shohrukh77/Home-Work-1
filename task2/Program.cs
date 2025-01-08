int num = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[num];
for (int i=1; i<=num; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int sum = 1;
for (int i=0; i<num; i++)
{
    sum*=1;
}
System.Console.WriteLine("1*2*3*4*5 = " + sum);