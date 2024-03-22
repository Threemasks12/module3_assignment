/* Task : Left and right up and down, away we go. 

In the file `nodes.json`there is an example of a data structure that has a value of type integer, 
but also a left and right variable that could be a object of the same type. If you need more test data you can get as much as you want from 
[this source](https://crismo-turquoisejaguar.web.val.run/treeI)

- Calculate the sum of the full structure.
- Report the deepest level of the structure. 
- Report the number of nodes.


```code
{
  value: 67, // Level 1
  left: { value: 765, left: null, right: null }, // Level 2
  right: {
    value: 167, // Level 2
    left: {
      value: 564, // Level 3
      left: null,
      right: { value: 379, left: null, right: null } // Level 4
    },
    right: null
  }
}
// --> 
Sum = 1942
Deepest level = 4
Nodes = 5
*/


/*
using System.Text.Json;
class Program
{
    static void Main()
    {
        try
        {
            string filePath = "example_files/nodes.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);

                JsonDocument document = JsonDocument.Parse(json);

                JsonElement rootNode = document.RootElement;

                int sum = CalculateSum(rootNode);
                Print("Sum of the structure: " + sum);

                int maxDepth = FindTheDeepestLevel(rootNode);
                Print("The deepest level of the structure: " + maxDepth);

                int nodeCount = CountNodes(rootNode);
                Print("Number of nodes: " + nodeCount);
            }
            else
            {
                Print("File not found: " + filePath);
            }
        }
        catch (Exception ex)
        {
            Print("Error: " + ex.Message);
        }
    }

    static int CalculateSum(JsonElement node)
    {
        int sum = 0;

        if (node.ValueKind != JsonValueKind.Null)
        {
            sum += node.GetProperty("value").GetInt32();

            if (node.TryGetProperty("left", out JsonElement left))
            {
                sum += CalculateSum(left);
            }

            if (node.TryGetProperty("right", out JsonElement right))
            {
                sum += CalculateSum(right);
            }
        }

        return sum;
    }

    static int FindTheDeepestLevel(JsonElement node)
    {
        if (node.ValueKind == JsonValueKind.Null)
        {
            return 0;
        }

        int leftDepth = FindTheDeepestLevel(node.GetProperty("left"));
        int rightDepth = FindTheDeepestLevel(node.GetProperty("right"));

        return Math.Max(leftDepth, rightDepth) + 1;
    }

    static int CountNodes(JsonElement node)
    {
        if (node.ValueKind == JsonValueKind.Null)
        {
            return 0;
        }

        int leftCount = CountNodes(node.GetProperty("left"));
        int rightCount = CountNodes(node.GetProperty("right"));

        return leftCount + rightCount + 1;
    }

    // Helper function to print messages
    static void Print(string msg)
    {
        Console.WriteLine(msg);
    }
    
}
*/

