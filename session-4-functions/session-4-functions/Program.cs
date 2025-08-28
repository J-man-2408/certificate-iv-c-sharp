namespace session_4_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Jasmine Sullivan 
 * 20147180
 * Session 4
 * Fuctions */


            Console.WriteLine(GetArea(2, 5));
            Console.WriteLine(GetArea(38, 245));
            int GetArea(in width, int height)
            {
                return width * height;
            }
        }
    }
}
