// Jasmine Sullivan
// 20147180
// if/else + short hand + switch/case

// if/else if/ else

int x = 22;
if (x < 10)
{
    Console.WriteLine("Good morning.");
}
else if (x < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}

// Short hand if/else (can only be done with if/else not if/else if/else

int y = 22;
string result = (y < 10) ? "Good morning." : "Good evening.";
Console.WriteLine(result);

// switch/case

int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}