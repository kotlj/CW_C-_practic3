using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_C__practic3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 9;
            int M = 4;
            int[] arr0 = new int[N];
            int[] arr1 = new int[M];
            int counter = 0;
            for (int i = 0; i < N; i++) { arr0[i] = i; }
            for (int i = 0; i < M; i++) { arr1[i] = i * 2; }
            int[] arr2 = new int[N + M];
            int counteri = 0;
            for (int i = 0; i < (M < N ? N : M); i++)
            {
                if (i < N && !arr2.Contains<int>(arr0[i]))
                {
                    arr2[counteri] = arr0[i];
                    counteri++;
                }
                if (i < M && !arr2.Contains<int>(arr1[i]))
                {
                    arr2[counteri] = arr1[i];
                    counteri++;
                }
            }
            for (int i = 0; i < arr2.Length; i++) { if (arr2[i] == 0) { counter++; } }
            Array.Resize(ref arr2, N + M - (counter - 1));
            for (int i = 0; i < arr0.Length; i++) { Console.Write(arr0[i] + ", "); }
            Console.Write('\n');
            for (int i = 0; i < arr1.Length; i++) { Console.Write(arr1[i] + ", "); }
            Console.Write('\n');
            for (int i = 0; i < arr2.Length; i++) { Console.Write(arr2[i] + ", "); }
            Console.Write('\n');
        }
    }
}
