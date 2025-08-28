/* Jasmine Sullivan 
 * 20147180
 * Session 4
 * Fuctions */

//You don't have to define a fuction before invocating it.//
Console.WriteLine(getArea(2, 5));
Console.WriteLine(getArea(38, 245));
int getArea(int width, int height)
{
    int area = width * height;
    return area;
}
int wiiiiiidth = 10;
int heiggggght = 80;
int area = getArea(wiiiiiidth, heiggggght);
Console.WriteLine(area);
Console.WriteLine(getArea(94, 183));

printThings(1);

void printThings(int thing1 = 1, string thing2 = "Thing 2")
{
    Console.WriteLine("Thing " + thing1);
    if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
    {
        return;
    }
    Console.WriteLine(thing2);
}

int add(int thing1, int thing2)
{
    return 0;
}