using System.ComponentModel;

namespace SortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            Console.Write("Подреден масив: ");
            Console.WriteLine(String.Join(" ", arr));



            List<int> list = new List<int>();

            list.Add(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    list.Add(arr[i]);
                }
                else
                {
                    break;
                }
            }

            Console.Write("Най-дълга поредица от най-малкото: ");
            foreach (int nums in list)
            {
                Console.Write(nums + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Дължина: {list.Count}");




        }
    }
}
