
/*Console.WriteLine("=====IF STATEMENT=====");
Console.WriteLine("How warm is there?");
var temperature = Convert.ToInt32(Console.ReadLine());                                                                                                                                                                                                     
string hotString;
if (temperature >= 15)
{
	hotString = "hot";
}
else
{
	hotString = "cold";
}
hotString = (temperature >= 15 ? "hot" : "cold");
Console.WriteLine($"Wow! {temperature}°C is sure {hotString}!");
//while condition do something
//useful when waiting till element present to read its text
Console.WriteLine("\n=====WHILE LOOP=====");
Console.WriteLine("Please enter number 3");
while (Console.ReadLine() != "3")
{
	Console.WriteLine("No that is not what I asked, please enter '3'");
}
Console.WriteLine("Thank you! That wasn't so hard, was it?");
//do something while condition
//useful when we want to do something at least once
//like when we have an e-shop and we want to show all pages with itemsdo{
Console.WriteLine("\n=====DO WHILE LOOP=====");
do
{
	Console.WriteLine("How happy are you now? From 1 to 10");
} while (Convert.ToInt32(Console.ReadLine()) < 8);
Console.WriteLine("Good job!");
//for loop - for when you need an index
int retriesLeft;
var numbers = new int[] { 200, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
Console.WriteLine("\n=====FOR LOOP #1=====");
for (retriesLeft = 5; retriesLeft > 0; retriesLeft--)
{
    Console.WriteLine("Please enter number 3");
    if (Console.ReadLine() == "3")
    {
        break;
    }
}
if (retriesLeft == 0)
{
    Console.WriteLine("I'm sorry, looks like you need to fix your keyboard");
}
Console.WriteLine("\n=====FOR LOOP #2=====");
for (var i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Month #{numbers[i]} is {GetMonthName(numbers[i])}");
}
//foreach loop - when you want to do something for each element of collection
Console.WriteLine("\n=====FOREACH LOOP=====");
foreach (var number in numbers)
{
    Console.WriteLine($"Month #{number} is {GetMonthName(number)}");
}
string GetMonthName(int number)
{
    string name;
    switch (number)
    {
        case 1:
            name = "January";
            break;
        case 2:
            name = "February";
            break;
        case 3:
            name = "March";
            break;
        case 4:
            name = "April";
            break;
        case 5:
            name = "May";
            break;
        case 6:
            name = "June";
            break;
        case 7:
            name = "July";
            break;
        case 8:
            name = "August";
            break;
        case 9:
            name = "September";
            break;
        case 10:
            name = "October";
            break;
        case 11:
            name = "November";
            break;
        case 12:
            name = "December";
            break;
        default:
            name = "nonexistent month, sorry";
            break;
    };
    return name;
}*/


//Homework I
using Training;
{
    Console.WriteLine("\n=====Homework I =====");
    Console.WriteLine("Hello, I have  a number for you!");
    while (Console.ReadLine() != "3")
    {
        Console.WriteLine("No, it's not this");
    }

    Console.WriteLine("Yes, it's 3");
    Console.Write("Do you want to play again? (y/n) ");
    string playAgainResponse = Console.ReadLine();
    if (!string.IsNullOrEmpty(playAgainResponse) && (playAgainResponse[0] == 'n' || playAgainResponse[0] == 'N'))
    {
        bool playAgain = false;
    }
}
    /*object equals = null;
    if ConvertToChar(Console.ReadLine() equals 'Y'))
    {
        Console.WriteLine("Hello, I have  a number for you!");
    }

    {
        Console.WriteLine("Hello, I have  a number for you!");
        while (Console.ReadLine() != "3");*/
    //Homework II #1.

    Console.WriteLine("\n=====Homework II #1=====");
    var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
    for (var i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Day #{numbers[i]} is {GetDayName(numbers[i])}");
    }
    foreach (var number in numbers)
    {
        //Console.WriteLine($"Day #{number} is {GetDayName(number)}");
    }
    string GetDayName(int number)
    {
        string name;
        switch (number)
        {
            case 1:
                name = "Monday";
                break;
            case 2:
                name = "Tuesday";
                break;
            case 3:
                name = "Wednesday";
                break;
            case 4:
                name = "Thursday";
                break;
            case 5:
                name = "Friday";
                break;
            case 6:
                name = "Saturday";
                break;
            case 7:
                name = "Sunday";
                break;
            default:
                name = "nonexistent day, sorry";
                break;
        };
        return name;

    }
    // Homework II #2.
    Console.WriteLine("\n=====Homework II #2=====");

    for (var i = 0; i < numbers.Length; i++)

    {
        Console.WriteLine(numbers[i]);
        Console.ReadLine();

    }


    //Homework II #2?.
    Console.WriteLine("\n=====Homework II #2=====");
    //List<int> integers = new List<int> { 1, 2, 3 };
    // integers.ForEach(Console.WriteLine)

    int[] num = { 1, 2, 3 };
    foreach (int i in num)
    {
        Console.WriteLine(i);
    }
    /*Homework II #2.
    Console.WriteLine("\n=====Homework II #2=====");
        int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Elements of the collection: ");
        for (int l = 0; l < numbers1.Length; l++)

            foreach (int number in numbers1)
            {
                do
                {
                    Console.WriteLine(l++);
                    Console.ReadLine();
                }
                while (Convert.ToString(Console.ReadLine()) == "x");*/


    //Homework II #3
    //Console.WriteLine("\n=====Homework II #3======");
   // int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
   // Console.WriteLine("This is a new collection:");
   // for (int j = 1; j <= array1.Length; j++)

   // {
        //Console.WriteLine(j);
   // }
//

    //UPDATED HOMEWORK II #3

    List<double> collection= new List<double>() { 1.5, 2.5, 3.5, 4.5 };

for (int i = 0; i < collection.Count; ++i)

{
    collection[i] += i;
}
    Console.WriteLine("This is the result of the collection after task 1:");

    foreach (double item in collection)
    {
        Console.Write(item + " ");
            }
    Console.WriteLine();



//Homework #4


var truck = new FoodTruck();
var MyTruck = new FoodTruck("Hristina",100);
Console.WriteLine($"FoodTruck was created. Owner: {truck.Owner}\tCapacity: {truck.Capacity}\tContainingAmount:{truck.ContainingAmount} count");
Console.WriteLine($"FoodTruck was created. Owner: {MyTruck.Owner}\tCapacity: {MyTruck.Capacity}\tContainingAmount:{MyTruck.ContainingAmount} count");
Console.WriteLine($"Fullness of {truck.Owner}'s truck is {truck.Fullness}%");
//Console.WriteLine($"Fullness of {MyTruck.Owner}'s truck is {MyTruck.Fullness}%");
MyTruck.AddItem("hamburger", 100);
MyTruck.PrintTruckContents();