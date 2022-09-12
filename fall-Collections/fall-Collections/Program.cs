// Collections

//arrays 
//Fixed size amd a of a particular order
// Start at 0
var students = new string[13]; //This creats an empty array with 13 slot to fill
// Variable = new type[Length]; Generic temple
var instructors = new string[] { "Davis", "Gavin", "El", "Rickie", "Cliff" }; //5 values listed so its length is 5
// Variable = new type {comma seprated value}
// an array length and type cannot change in C#

// change the value at a slot in a array
// name = Value;
// array[index] = value;
students[7] = "Ashley";
// student at index 7 is updated to "ashley" 
// student at the idex of 7 is actually 8 because the array starts at 0
// first thing in te list --> array[0]
// last thing in the list --> array[array.length - 1]
Console.WriteLine(students.Length); // prints the number of slots in the array 

//Lists
// Dynmaic size, still must be of one type
// Indexed at 0 simalr to arrays 
var groceries = new List<string>(); // sets up are new list, starting with no values within the list, its count is 0
groceries.Add("Pizza"); // our list contains 1 item, (index = 0)
groceries.Add("Bananas");// our list contains 2 items (banana has a index of 1 )
groceries.Add("grapes");
groceries.Add("Potatoes");

Console.WriteLine(groceries[0]); // prints out pizza since its index is 0

// Remove items from a array
// list.Remove(item to be removed);
groceries.Remove("Bananas");
//RemoveAt --? gives the index to remove
groceries.RemoveAt(1); //Removes the second item in the list

groceries.Insert(1, "Bananas"); // shift items after this idex up to 1, adds bannas to list
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

// Foreach loops
// Loops that run 1 time for each itwm in a collection
// rather than specificlly having an idex (i) like other loops, we have an object that we can look at and engage with
// forravh(type item in collection)
//{
// code to run
//}

foreach (var grocery in groceries) 
{
    Console.WriteLine(grocery);
}

// Sometimes its nice to have access to the index of a particular item as well as the item itself.
// collection.Length if array , collection.Count if its a list
for ( var i = 0; i < instructors.Length ; i++)
{
    Console.WriteLine(instructors[i]);
}
//instructos[i] in a for loop is the same as the var instructor in a for each loop

//Dictionaries 
//Collections of key value pairs 
// keys - how we access elements
//values - the values we get in return

var weather = new Dictionary<string, float>();
weather["Atlanta"] = 82.3f; // key is atlanta and the value is 82.3f
weather["Cleveland"] = 71f;
Console.WriteLine(weather["Atlanta"]); // accessing the value at "atlanta"

Console.WriteLine(weather.Count);

//weather. add, remove, count  etc.. 

// report is a keyvalue pair object, meaning we have acess to the keys and values as we go through each item in our weather dictionary
foreach (var report in weather)
{
    Console.WriteLine(report);
}