internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов в строке"); 
        int n = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Введите количество элементов в cтолбце"); 
        int m = int.Parse(Console.ReadLine()); 
        int[,] mas = new int[m, n]; 
        int k = 1; 
        int t = 0; 
        int i, j = 0; 
        int n1 = n; 
        int m1 = m; 
        
        while (k <= n1 * m1) 
        { 
        for (i = t; i < n; i++) 
        mas[j, i] = k++; 
        j = n - 1; 
        for (i = t + 1; i < m; i++) 
        mas[i, j] = k++; 
        j = m - 1; 
        for (i = n - 2; i >= t; i--) 
        mas[j, i] = k++; 
        j = t; 
        for (i = m - 2; i > t; i--) 
        mas[i, j] = k++; 
        n--; 
        m--; 
        t++; 
        j = t; 
        } 
        for (i = 0; i < mas.GetLength(0); i++) 
        { 
        for (j = 0; j < mas.GetLength(1); j++) 
        Console.Write(" {0,2} ", mas[i, j]); 
        Console.WriteLine(); 
        } 
        
        Console.ReadKey();
    }   
}