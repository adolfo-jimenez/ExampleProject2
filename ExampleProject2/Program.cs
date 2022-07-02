//This program was created for general testing purposes.

string introLine = "Please enter a number:";
Console.WriteLine(introLine);

int num1 = Convert.ToInt32(Console.ReadLine());
int threshold = 6;

if (num1 == threshold)
    Console.WriteLine("Warning! You have reached the limit!");
if (num1 < threshold)
    Console.WriteLine("Safe Conditions Met.");
if (num1 > threshold)
    Console.WriteLine("Too Much, passed threshold.");
    