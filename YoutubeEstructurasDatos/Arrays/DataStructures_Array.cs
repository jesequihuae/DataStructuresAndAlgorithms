using System;

namespace HackerRank.YoutubeEstructurasDatos.Arrays
{
    class DataStructures_Array
    {
        public static void MainXXX(String[] args)
        {
            int[] numericArray2 = new int[5];
            AddElements(ref numericArray2);
            //PrintAllElements(numericArray2);

            //UpdateElementAt(ref numericArray2, 1, 55);

            //PrintAllElements(numericArray2);

            DeleteElement(numericArray2, 3);

            Console.ReadKey();
        }

        public static void PrintAllElements(int[] array)
        {
            // IEnumerable y IEnumerable<T>

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //foreach(int element in array)
            //{
            //    Console.WriteLine(element);
            //}

            //Array.ForEach(array, element => Console.WriteLine(element));
        }

        public static void UpdateElementAt(ref int[] array, int index, int value)
        {
            array[index] = value;
        }

        public static void AddElements(ref int[] array)
        {
            array[0] = 10;
            array[1] = 15;
            array[2] = 20;
            array[3] = 25;
            array[4] = 30;
        }

        public static void DeleteElement(int[] array, int index)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array[" + i + "] = " + array[i]);
            }

            while(index < array.Length - 1)
            {
                array[index] = array[index + 1];
                index = index + 1;
            }

            Console.WriteLine();

            for(int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine("Array[" + i + "] = " + array[i]);
            }
        }
               
    }
}
