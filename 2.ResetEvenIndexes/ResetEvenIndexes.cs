namespace _2.ResetEvenIndexes
{
    using System;
    using System.Linq;
    public class ResetEvenIndexes
    {
        public static void Main()
        {

            var array = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int arrayLenght = array.Length;

            for (int i = 0; i <=arrayLenght - 1; i++)
            {
                if(i%2==0)
                array[i] = 0;
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}

