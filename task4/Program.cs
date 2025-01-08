double a=Convert.ToDouble(Console.ReadLine());
if(a<100)
{
    Console.WriteLine((a*5/100)+a);
}
else if (a>=100 && a<200)
{
    Console.WriteLine((a*7/100)+a);
}
else {
   Console.WriteLine((a/10)+a);
}
