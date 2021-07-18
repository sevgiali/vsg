
using System;
using System.Collections.Generic;

class Third
{
static void printRepeating(int []arr, int n)
{

	Dictionary<int,
			int> map = new Dictionary<int,
										int>();
	for (int i = 0 ; i < n; i++)
	{
		if(map.ContainsKey(arr[i]))
		{
			var val = map[arr[i]];
			map.Remove(arr[i]);
			map.Add(arr[i], val + 1);
		}
		else
		{
			map.Add(arr[i], 1);
		}
	}

	foreach(KeyValuePair<int, int> e in map)
	{
		if (e.Value > 1)
		{
			Console.Write(e.Key + " ");
		}
	}
}


public static void Main(String[] args)
{
	int []arr = { 12, 10, 9, 45, 2, 10, 10, 45 };
	int n = arr.Length;
	printRepeating(arr, n);
}
}


