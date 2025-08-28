/* Jasmine Sullivan 
 * 20147180
 * Session 3 
 * Inputs + Namespaces + Loops (while, foreach, for) + Type Converstion */





//Revision on switch/case:
Console.Write("yay or nay? ");
string response = Console.ReadLine();
switch (response)
{
    case "yay":
        Console.WriteLine("happy");
        break;
    case "nay":
        Console.WriteLine("sad");
        break;
}

/* While loops:
 * They will repeat the inside code until some condition is false
 * If the condition never reaches false, it will turn into a infinate loop */
int num = 0;
while (num < 4)
{
    Console.WriteLine(num++);
}
Console.WriteLine("while Finished");

/* do while loops:
 * Same as while loops except the code will always run the block of code once, THEN check if the condition is true. */
int no = 0;
do
{
    Console.WriteLine(no++);
} while (no < 4);    
Console.WriteLine("do while Finished");

/* foreach loops:
 * A simpler way to iterate over an array, but less flexible than a "for" loop
 * You cannont skip iterations or iterate backwards */
int[] numbers = { 0, 1, 2, 3 };
foreach(int index in numbers)
{
    Console.WriteLine(index);
}
Console.WriteLine("foreach finished");

/* for loop:
 * for (initial setup ; condition to evaluate ; action at end of loop)
 * Repeat some code an finite amount of times */
for (int i=0;
    i<numbers.Length;
    i++)
{
    Console.WriteLine(numbers[i]);
}
Console.WriteLine("for finished");

/* Data Type Conversion (Type Casting):
 * Inmplicit converstion:
 * Convert: */
double a = 3.14;
int b = Convert.ToInt32(a);

int c = 123;
double d = Convert.ToDouble(c);

int e = 321;
string f = Convert.ToString(e);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);

/* GetType:
 * If you need to know the type of a varibale */
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());
Console.WriteLine(f.GetType());

/* NOTES:
 * Classes are a bundle of related code 
 * Classes can be named anything, though they must adhire to C# naming standards. 
 * There are some classes that already have functions imbeded
 * Eg., Math
 * You can either write you class in the same c# program as the rest of your code
 * Or you can create a new program class in the namespace. 
 * To be able to access the functions in you class, you must make them public and static 
 * You can also make objects (will learn later) */

 