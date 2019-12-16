using System;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int left = 0;
            int right = n - 1;
            int[] array = new int[n];
            for (int k = 0; k < n; k++)
                Console.ReadLine();
            QSort(array, left, right);
            for (int k = 0; k < n; k++)
                Console.WriteLine(array[k]);
            Console.ReadKey();
        }
        static void QSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;
            int barrier = array[left];
            while (i <= j)
            {
                while (array[i] < barrier)
                {
                    i++;
                }
                while (array[j] > barrier)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < right)
                QSort(array, i, right);
            if (j > left)
                QSort(array, left, j);

        }



    }
}
