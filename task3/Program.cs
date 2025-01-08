int max = -99999999;
int[] num = {1, 2, 3, 4, 5};
for (int i=0; i<num.Length; i++) {
    if (i > max) {
        max=i;
    }
}
System.Console.WriteLine(max);