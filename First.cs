
using System;
using System.Collections.Generic;

class GFG{
	
static void preserveSpace(string str)
{
	int n = str.Length;

	int start = 0;
	int end = n - 1;
	
	char[] Str = str.ToCharArray();

	while (start < end)
	{
		
	
		if (Str[start] == ' ')
		{
			start++;
			continue;
		}
		else if (Str[end] == ' ')
		{
			end--;
			continue;
		}

	
		else
		{
			char temp = Str[start];
			Str[start] = Str[end];
			Str[end] = temp;
			start++;
			end--;
		}
	}
	Console.Write(new string(Str.substr(Str.length -2)));
}

static void Main()
{
	string str = "cat";

	preserveSpace(str);
}
}


