
#region
//Console.WriteLine("Hello");
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[S]ee all TODOs");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

//var userChoice = Console.ReadLine();

//var result = Add(10, 5);
//Console.WriteLine("10 + 5 = " + result);
//bool isLong = IsLong(userChoice);

//switch (userChoice)
//{
//    case "S":
//    case "s":
//        PrintSelectedOption("See all TODOs");
//        break;
//    case "A":
//    case "a":
//        PrintSelectedOption("Add a TODOs");
//        break;
//    case "R":
//    case "r":
//        PrintSelectedOption("Remove a TODOs");
//        break;
//    case "E":
//    case "e":
//        PrintSelectedOption("Exit");
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}

////if (userChoice == "S")
////{
////    PrintSelectedOption("See all TODOs");
////}
////else if (userChoice == "A")
////{
////    PrintSelectedOption("Add a TODOs");
////}
////else if(userChoice == "R")
////{
////    PrintSelectedOption("Remove a TODOs");
////}
////else if(userChoice == "E")
////{
////    PrintSelectedOption("Exit");
////}


////  Defined a method called PrintSelectedOption which takes a string (selectedOption) parameter and the return type void which returns nothing
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);    // value of the method
//}

//int Add(int a, int b) // Defined what type will be returned from the method
//{
//    return a + b; // methods that are non - void must always return a value
//}

//bool IsLong(string input)
//{
//    //if (input.Length > 10)
//    //{
//    //    return true;
//    //}
//    //return false;
//    return input.Length > 10; //refactored
//}

//char TestPoints(int points)
//{
//    switch (points)
//    {
//        case 10:
//        case 9:
//            return 'A';
//        case 8:
//        case 7:
//        case 6:
//            return 'B';
//        case 5:
//        case 4:
//        case 3:
//            return 'C';
//        case 2:
//        case 1:
//            return 'D';
//        default:
//            return '!';
//    }
//}


//int number = 0;

//while (number < 10) // while number is less than 10 this loop will keep running
//{
//    number++; // add 1 increments to number
//    Console.WriteLine("Number is: " + number);  // print number
//}

//Console.WriteLine("Enter a word: ");
//var userInput = Console.ReadLine();

//while (userInput.Length < 15)
//{
//    userInput += 'a';
//    Console.WriteLine(userInput);
//}

// While loops the condition is checked before running
// Do while loops conditions are checked after running the block of code


//string word;
//do
//{
//    Console.WriteLine("Enter a word longer than 10 letters");
//    word = Console.ReadLine();
//}
//while (word.Length <= 10);

//for (int i = 0; i < 5; i++) // for loops have 3 sections: the first loop is declaring and initalizing a variable. the 2nd section is the condition. third is the iterator section it defines what happens after each execution of the loop.
//{
//    Console.WriteLine("Hello");
//}

// the body of this loop will be executed 100, if i is greater than 25 it will hit the break keyword
//for (var i = 0; i < 100; i++)
//{
//    Console.WriteLine("i is " + i);
//    if (i > 25)
//    {
//        break;
//    }
//}


//Console.WriteLine("The loop has finished");
//Console.ReadKey();

//AskForNumber("What is the airspeed velocity of an unladen swallow? ");

//int AskForNumber(string text)
//{
//    text = "What is the airspeed velocity of an unladen swallow? ";
//    int result = Convert.ToInt32(Console.ReadLine());

//    return result;
//}

//int AskForNumberInRange(string text, int min, int max)
//{
//    min = 0;
//    max = 100;

//    do
//    {
//        text = "Enter another number: ";
//    } while (min > 0; max < 100)
//}

#endregion

#region https://www.w3resource.com/csharp-exercises/basic/index.php

//// Write a C# Sharp program to print Hello and your name in a separate line.
//using System.ComponentModel;

//Console.WriteLine("Hello: John Nguyen");

//// Write a C# Sharp program to print the sum of two numbers.
//int a = 1;
//int b = 3;
//int result = a + b;
//Console.WriteLine(15 + 1);

//// Write a C# Sharp program to print the result of dividing two numbers.
//Console.WriteLine(10 / 2);



#endregion