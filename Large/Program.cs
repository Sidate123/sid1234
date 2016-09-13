using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("enter numbers");
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            for (int k= 0; k <arr.Length; ++k)
            {
                for (int j = k + 1; j <arr.Length; ++j)
                {
                    if (arr[k] < arr[j])
                    {
                        int a = arr[k];
                        arr[k] = arr[j];
                        arr[j] = a;
                    }
                }
            }
            for (int m = 0; m < arr.Length; m++)
            {
                Console.Write(arr[m]);
            }



            Console.Read();
        }
    }
}
