double num=Convert.ToDouble(Console.ReadLine());
if(num<100)
{
    Console.WriteLine((num*5/100)+num);
}
else if (num>=100 && num<200)
{
    Console.WriteLine((num*7/100)+num);
}
else {
   Console.WriteLine((num/10)+num);
}
