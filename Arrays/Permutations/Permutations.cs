using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 19.* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
 */

class Permutations
{


    static void Main(string[] args)
    {
        Console.Write("N:");
        int n = int.Parse(Console.ReadLine());
   
        IEnumerable<IEnumerable<int>> result = GetPermutations(Enumerable.Range(1, n), n);
        List<IEnumerable<int>> list = result.ToList();
        foreach (var item in list)
        {
            foreach (var it in item)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }


    ////Method is using LINQ
    static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
    {
        if (length == 1) return list.Select(t => new T[] { t });

        return GetPermutations(list, length - 1) //recursive call
            .SelectMany(t => list.Where(e => !t.Contains(e)),
                (t1, t2) => t1.Concat(new T[] { t2 }));
    }
}

