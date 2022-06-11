int [] array = {1,7,15,12,31,19,21,92,13};
int n = array.Length;
int finde = 12;

int index = 0;
while(index<n)
{
    if(array[index] == finde)
    {
        Console.WriteLine(index);
    }
    index++;
}
