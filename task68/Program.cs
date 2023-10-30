int A(int m, int n)
{
    if(m == 0)
        return n = n + 1;
    else if(n == 0)
        return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

Console.Write("Insert the 1st number: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert the 2nd number: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(A(m, n));