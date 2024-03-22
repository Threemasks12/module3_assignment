
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


using System.Text.Json;

try
{
    string filePath = "example_files/arrays.json";

    if (File.Exists(filePath))
    {
        string json = File.ReadAllText(filePath);

        dynamic arrayData = JsonSerializer.Deserialize<dynamic>(json);

        List<int> flattenedArray = FlattenArray(arrayData);

        Console.WriteLine("[" + string.Join(", ", flattenedArray) + "]");
    }
    else
    {
        Console.WriteLine("File not found: " + filePath);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


static List<int> FlattenArray(dynamic array)
{
    List<int> result = new List<int>();

    if (array.ValueKind == JsonValueKind.Array)
    {
        foreach (var item in array.EnumerateArray())
        {
            if (item.ValueKind == JsonValueKind.Number)
            {
                result.Add(item.GetInt32());
            }
            else if (item.ValueKind == JsonValueKind.Array)
            {
                result.AddRange(FlattenArray(item));
            }
        }
    }

    return result;
}