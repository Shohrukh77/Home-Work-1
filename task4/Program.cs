int[] arr;
int n = Convert.ToInt32(Console.ReadLine());
arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt=0;
for(int i=0;i<n;i++)
    {
      cnt=0;
       for(int j=0;j<n;j++)
    {
       if (arr[i]==arr[j])
       {cnt++;}
    }
        if (cnt==1)
        {
        Console.WriteLine(arr[i]);
        }
    }
