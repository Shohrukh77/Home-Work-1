int[] num = {2, 3, 1, 4, 5};
int min = num[0];
int t = 0;
for (int i=1; i<num.Length; i++) {
    if (i<min) {
        t=i;
        min=num[i];
    }
}
System.Console.WriteLine(t);