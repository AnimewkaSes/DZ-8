internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите размер двумерного массива: ");
        int size = Int32.Parse(Console.ReadLine());
        int[,] array = Array(size,size);
        PrintArray(array);
        ColArray(array,size,size);
      
    }

    public static int[,] Array(int r, int c){

        int[,] table = new int[r,c];
        Random rnd = new Random();
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                table[i,j] = rnd.Next(0,9);
            }
        }
     return table;   
    }
    public static void PrintArray(int[,] arr){
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }

    }
    public static void ColArray(int[,] mas,int r, int c ){
        int minRowSum = int.MaxValue, indxeMinRow = 0;   
        int sum = 0; 
        for (int i = 0; i < r; i++)
        {
                       
                for (int j = 0; j < c; j++)
                {
                    sum += mas[i,j];
                    
                 
                 }

            if (sum<minRowSum)
                    {
                        minRowSum = sum;
                        indxeMinRow = i;
                    }           
            Console.WriteLine("Сумма элементов в строке {0} равно: {1}. ",i,sum);
        }
        Console.WriteLine("Минимальная строка c суммой элементов {0}", minRowSum);
        for (int i = 0; i < r; i++)
        {
            Console.Write(mas[indxeMinRow,i]+" ");
        }

    }
}