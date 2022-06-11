int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 12;
int a2 = 14;
int a3 = 111;
int b1 = 26;
int b2 = 15;
int b3 = 42;
int c1 = 228;
int c2 = 617;
int c3 = 37;

//int max1 = Max(a1, a2, a3);
//int max2 = Max(b1, b2, b3);
//int max3 = Max(c1, c2, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));
Console.WriteLine(max);