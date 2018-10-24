namespace _1.ArrayReverse
{
    using System;
    public class ArrayReverse
    {
        public static void Main()
        {
            var array = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            int arrayLenght = array.Length;

            while (arrayLenght != 0)
            {
                for (int i = 1; i <= arrayLenght - 1; i++)
                {
                    var first = array[i];
                    var second = array[i - 1];

                    array[i] = second;
                    array[i - 1] = first;

                }

                arrayLenght--;
            }              
            
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
