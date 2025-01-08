int sum = 1;
int[] num = {1, 2, 3, 4, 5};
for (int i=1; i<=num.Length; i++) {
    sum *= i;
}
System.Console.WriteLine("1*2*3*4*5 = " + sum);