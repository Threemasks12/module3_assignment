
/*
## Task : Flatten those numbers

In the file `arrays.json` there is an example of a an array that contains integers and possibly other arrays. 
If you need more test data you can get as many as you want from 
[this source](https://crismo-turquoisejaguar.web.val.run/arrayI) 
The task is to write a function that returns a flattened version of any such array structure.

**NB!** You might be tempted to use string manipulation, 
that is considered not solving the task. This is a jagged array of integers, not a string.


Example:
```code
[
  435,
  2028,
  [
    [
      3047, 4910, 8146,
      7999, 1433, 7211,
      1197, 6002
    ],
    2821,
    3508
  ]
]
//--> 
[435, 2028, 3047, 4910, 8146, 7999, 1433, 7211, 1197, 6002, 2821, 3508]
```
*/
using System;
using System.IO;
using System.Text.Json;

string jsonFileArrayOfIntegiers = File.ReadAllText("arrays.Json");

int[][] jaggetArray = JsonConvert.DeserializeObject<int[][]>(jsonFileArrayOfIntegiers);
foreach (int[] innerarray in jaggetArray)
{
  foreach(int number in innerarray)
  {
    Console.WriteLine(number + ", ");
  }
  Console.WriteLine();

}