/* Sesssion 6 - Sort and Search 
 * 28/08/2025
 * Jasmine Sullivan */

// Searching to find the index of a desired number via Binary, Linear Searches
// Also Bubble searching.

// Declare the array
int[] myArray = {10, 50, 30, 70, 80, 60, 20, 90, 40};

Console.WriteLine("Index of 20 in a Linear: " + LinearSearch(myArray, 20));
BubbleSort(myArray);
Array.ForEach(myArray, Console.WriteLine);
Console.WriteLine("Index of 60 in a Binary: " + BinarySearach(myArray, 60, 0, myArray.Length - 1));


// Linear search method (checks each element one by one)
int LinearSearch(int[] arraryToSearch, int valueToFind)
{
    for (int i = 0; i < arraryToSearch.Length; ++i) // loop through array 
    {
        if (arraryToSearch[i] == valueToFind) //if value matches
        {
            return i; //returns index if found
        }
    }
    return -1; //returns -1 if not found
}

// Bubble sort to order them least to most
void BubbleSort(int[] arrayToSort)
{
    int temp = 0;
    bool swapped = false; // flag to check if any swaps happened

    for (int i = 0; i < arrayToSort.Length; ++i) // loop through array multiple times
    {
        for (int j = 0; j < arrayToSort.Length - 1; j++) // compare neighbours
        {
            if (arrayToSort[j] > arrayToSort[j + 1]) //if out of order
            {
                // swap values
                temp = arrayToSort[j];
                arrayToSort[j] = arrayToSort[j + 1];
                arrayToSort[j + 1] = temp;
                swapped = true;
            }
        }
        if (!swapped) break; // stop early if no swaps needed
    }
}

// Binary search method (works only on sorted arrays)
int BinarySearach(int[] myArray, int value, int low, int high)
{
    if (high >= low) // check if valid range
    {
        int mid = (high + low) / 2; // find middle index

        if (myArray[mid] == value) return mid; //value found
        if (myArray[mid] > value) return BinarySearach(myArray, value, low, mid - 1); //search left half
        return BinarySearach(myArray, value, mid + 1, high); //search right half
    }
    return -1; // not found
}