/* Jasmine
 * Session 5 - Arrays
 */

/* Arrays:
 * You don't have to put the "new string"
 * If you set the new string value, you must allocate all of them!
 * If you wish to have them null, you don't have to fill any, but you can't just fill some
 * If you want just one null then use the "null" 
 * */
string[] catNames = new string[5] { "Panther", "Mushroom", "Tex", "Kenny", null };

//make a loop to go through all the cat names
for (int i = 0; i< catNames.Length; i++)
{
    // ?? means null coalesce, the following sting will print whenever you have a null value in that array loop. 
    Console.WriteLine(catNames[i]??"this is null");
}

for (int i = 0; i < catNames.Length; i++)
{
    // This will print the number of letters in each of the array values.  
    Console.WriteLine(catNames[i]?.Length);
}

int[] myNumberArray = {10, 4, 7, 1};
for (int i = 0; i < myNumberArray.Length; i++)
{
    // Goes throught the array length and writes all the values until it finishes 
    Console.WriteLine(myNumberArray[i]);
}

// This is going to give back a True boolean value if there is a one in the myNumberArray array
bool included = Array.IndexOf(myNumberArray, 1) >= 0;
Console.WriteLine(included);

// This is going to give back the index number of 1 (where is shows in the array)
// If the number doesn't show it will return with -1.
int includedNumber = Array.IndexOf(myNumberArray, 1);
Console.WriteLine(includedNumber);

