string list(int n)
{
    if (n == 1)
         return "1 ";
    return $"{n} " + list(n - 1);
}
Console.Write("Insert the number: ");
int n = Convert.ToInt32(Console.ReadLine());                                          
Console.Write(list(n)); 
