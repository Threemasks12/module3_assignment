
using System.Text.Json;


//Task 1 Functions
//A function that returns the square of a number

int squareNumber = 6;
double square;

double Square(double value)
{
    return value * value;
}
square = Square(squareNumber);

Print($"the square of {squareNumber} is {square}");

Print("-------------------------------------------------------------------------------------------");
//-------------------------------------------------------------------------------------------


// A function that returns a length in mm assuming it has been given a length in inches.


double inches = 5;
double mm = Converter(inches);

static double Converter(double inches)
{
    double convertNumbner = 25.4;
    return inches * convertNumbner;
};

Print($"{inches} inches is equal to {mm} millimeters");

Print("-------------------------------------------------------------------------------------------");

//------------------------------------------------------------------------------------------


// A function that returns the root of a number

double valueNumber = 25;

double theSquareRoot(double baseNumber)
{
    double exponet;
    return Math.Sqrt(baseNumber);
}

double exponet = theSquareRoot(valueNumber);

Print($"the square root of 25 is {exponet}");

Print("-------------------------------------------------------------------------------------------");
//------------------------------------------------------------------------------------------


// A function that returns the cube of a number
int cubeNumber = 9;
double numberInCube;

double Cube(double baseValue)
{
    return baseValue * baseValue * baseValue;
}

numberInCube = Cube(cubeNumber);

Print($"The cube of {cubeNumber} is {numberInCube}");

Print("-------------------------------------------------------------------------------------------");
//------------------------------------------------------------------------------------------

// A function that returns the area of a circle given the radius. 

double pi = 3.14;
double radius = 8;

double calculateAreaOfCircile(double PI, double r)
{
    return PI * r * r;
}

double area = calculateAreaOfCircile(pi, radius);
Print($"The are of the circile is {area}");

Print("-------------------------------------------------------------------------------------------");

//------------------------------------------------------------------------------------------

// A function that returns a greeting, given a name.

void Greeting()
{
    Print("Good day Christian and Tony (•_•) ( •_•)>⌐■-■ (⌐■_■)");
}

Greeting();





Print("-------------------------------------------------------------------------------------------");
//task 2 Array Json

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



Print("-------------------------------------------------------------------------------------------");
//Task 3 Nodes json
string fileJson = "example_files/nodes.json";

if (File.Exists(fileJson))
{
    string json = File.ReadAllText(fileJson);

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
    Print("File not found: " + fileJson);
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

//helper functions

static void Print(string msg)
{

    Console.WriteLine(msg);
}
