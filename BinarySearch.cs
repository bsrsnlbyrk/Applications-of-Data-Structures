using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{

	class Program
		{
			public static bool BinarySearch(int[] array,int wanted)
			{
				Random _number = new Random();
				for(int t = 0; t < array.Length; t++)
				{
					array[t] = _number.Next(1, 50000);
				}
				int temp;
				for(int i = 0; i < array.Length - 1; i++)
				{
					if (array[i] > array[i + 1])
					{
						temp = array[i];
						array[i] = array[i + 1];
						array[i + 1] = temp;
					}
				}
				int first = array[0];
				int last = array[array.Length - 1];
				int middle = (first + last) / 2;
				for(int m = 0; m < array.Length; m++)
				{
					if (array[m] == wanted) { return true; }
					if (array[m] < wanted) { last = array[m]; }
					if (array[m] > wanted) { first = array[m]; }
				}
				return false;
			}
			
			
			static void Main(string[] args)
			{
				string wanted = Console.ReadLine();
				int[] array = new int[1000];
				Console.WriteLine(BinarySearch(array, Int32.Parse(wanted)));
			}
		}
}