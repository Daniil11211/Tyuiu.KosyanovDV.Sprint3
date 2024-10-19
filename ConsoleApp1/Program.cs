double sum = 0;
int startValue1 = 1;
int startValue2 = 1;
int stopValue1 = 2;
int stopValue2 = 2;
int x = 2;
for (int i = startValue1; i <= stopValue1; startValue1++)
{
    for (int j = startValue2; j <= stopValue2; startValue2++)
    {
        sum = sum + ((Math.Pow(x, 3) - startValue2) + x);
     }

}
Console.WriteLine(sum);