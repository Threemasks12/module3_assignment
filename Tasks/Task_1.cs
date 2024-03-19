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
Print("");
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
Print("");
//------------------------------------------------------------------------------------------

// A function that returns the root of a number










// A function that returns the cube of a number 
// A function that returns the area of a circle given the radius. 
// A function that returns a greeting, given a name.





//helper functions

static void Print(string msg)
{

    Console.WriteLine(msg);
}