int x;
int sum = 0;

for (x = 3; x <= 6; x++)
{
    for (int d = 1; d <= x; d++)
    {
        if (x % d == 0)
        {
            sum += d;
        }
    }
}
Console.Write(sum);