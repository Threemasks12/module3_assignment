
/* 
## Task : Functions are a popping
Create the following functions: 
*/


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

Print($"{inches} is equal to {mm} millimeters");

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



//helper functions

static void Print(string msg)
{

    Console.WriteLine(msg);
}