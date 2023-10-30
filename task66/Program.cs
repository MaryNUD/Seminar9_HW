// summa between
int sum(int m, int n)
{
    if(m == n)
        return m;
    return sum(m, n - 1) + m; // я торможу и не могу понять как сделать... 
}

Console.Write("Insert the starting number: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the last number: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(sum(m, n));
