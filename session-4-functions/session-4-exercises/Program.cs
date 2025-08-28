/* Jasmine
 * 20147180
 * Session 4 */

// Void tells the system that the method will not return a value
// A void method that prints a message to the console
void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

DisplayMessage("Hello");
DisplayMessage(" ");

/*Method to sing Happy Birthday three times*/
string name = "Jasmine";
int age = 19;
singHappyBirthday(name, age);
singHappyBirthday(name, age);
singHappyBirthday(name, age);
void singHappyBirthday(String birthdayPerson, int yearsOld)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday dear " + birthdayPerson);
    Console.WriteLine("You are " + yearsOld + " years old!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine();
}

//Exercise 6
welcomeMessage();
void welcomeMessage()
{
    Console.WriteLine("*******************");
    Console.WriteLine("Welcome to My Application!");
    Console.WriteLine("*******************");
}

//Exercise 7
int AddNumbers(int a, int b)
{
    return a + b;
}

Console.WriteLine(AddNumbers(1, 5));

//Exercise 8
Console.WriteLine("What is your name? ");
string yourName = Console.ReadLine();
welcomeMessage2(yourName);

static void welcomeMessage2(string name)
{
    Console.WriteLine("*******************");
    Console.WriteLine("Welcome, " + name + " to My Application!");
    Console.WriteLine("*******************");
}