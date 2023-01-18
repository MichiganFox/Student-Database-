

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

/*Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.

What will the application do?







Hints:
Make sure the arrays are the same size.
Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
For the valid category: You might create a separate program to test out some code that uses a while loop and asks for either “Hometown” or “Favorite Food.” And only finishes the loop if either of these two is entered. Once you have it working, copy the code over to your “real” code.
Make it easy for the user – tell them what information is available
Try to use good grammar. Make your messages polite.

Extra Challenges:
1 Point: Provide an option where the user can see a list of all students.
2 Points: Allow the user to search by student name (Good challenge but difficult!)
1 Point: Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"
 * 
 * */
bool studentlist = true;
do
{
    // Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
    string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

    string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

    string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };
    int i = 0;
    // Prompt the user to . Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.
    while (true)
    {
        Console.WriteLine("Please ask about a particular student by number 1 through 12");
         i = int.Parse(Console.ReadLine()) - 1;

        //Validate user number: Use an if statement to check if the number is out of range, i.e. either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.
        // Array Length: Use the first array’s Length property in your code instead of hardcoding it.
        if (i > 0 && i < names.Length)
        {
            Console.WriteLine(names[i]);
            break;
        }
        else
        {
            Console.WriteLine("Please enter a correct number.");

        }
    }

    // Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
    //Use an if statement to check that they entered either category name correctly.
    Console.WriteLine("Which catagory would you like to display: Hometown or Favorite food?");
    var y = Console.ReadLine().ToLower();
    if (y == "hometown" || y == "home")
    {
        Console.WriteLine(towns[i]);
    }
    else if (y == "food" || y == "Food")
    {
        Console.WriteLine(foods[i]);
    }
    else
    {
        Console.WriteLine("Please answer with hometown, Hometown, food, or Food");
    }


    //  Ask the user if they 
    Console.WriteLine("Would like to learn about another student?");
    string userAnswer = Console.ReadLine().Trim().ToLower();
    if (userAnswer == "no" || userAnswer == "n")
    {
        studentlist = false;
        break;
    }
    else
    {
        studentlist = true;
    }



} while (studentlist == true);

