
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество столбцов в массиве: ");
        int colSize = Int32.Parse(Console.ReadLine());
        Console.Write("Введите количество строк в массиве: ");
        int rowSize = Int32.Parse(Console.ReadLine());
        int[,] mass = Array(rowSize,colSize);
        Console.WriteLine("Исходный массив: ");
        Print(mass);
        
        Console.WriteLine("Массив упорядочный по убыванию элементов каждой строки: ");
        int[] row = new int[colSize];
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < colSize; j++)
                {
                    row[j] = mass[i,j];
               
                }
            BubbleSort(row);
            Insert(true,i,row,mass);
            }
        Print(mass);

       

    
    
    }

    public static int[,] Array(int r, int c){
        int[,] arr = new int [r,c];
        Random rnd = new Random();

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                 arr[i,j] = rnd.Next(0,9);
            }   
        }
        return arr;
    }

    public static void Print(int[,] array){
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j]+" ");
            }
            Console.WriteLine();
        }

    }

    public static void BubbleSort(int[] array){
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length-i-1; j++)
            {
                if (array[j]<array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }

    }

    public static void Insert(bool isRow, int dim, int[] sourse, int[,] dest){

        for (int k = 0; k < sourse.Length; k++)
        {
            if (isRow)
            {
                dest[dim,k] = sourse[k];
            } 
          
        }

    }
    
}