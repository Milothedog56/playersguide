using System;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

////////////////////////https://app.gumroad.com/read/d5dabbf305d0fb592034773910d025b2/0ndv4ontll2UEBlS-2UH3Q== - eBook
////////////////////////https://csharpplayersguide.com/solutions/5th-edition/ - solutions
///
#region Intro

//Console.WriteLine("S'doing");
//Console.WriteLine("My name is Tony Test");
//Console.WriteLine("Testing is my name");
//Console.WriteLine("The best to test ");
//Console.WriteLine("compared to the rest");

//Console.WriteLine("Bread is ready.");
//Console.WriteLine("Who is the bread for? ");
//string name;
//name = Console.ReadLine();
//Console.WriteLine($"Noted: {name} got the bread");

#endregion

#region Triangle Farmer


//Console.WriteLine("What is the base measurement?");
//int triBase = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("What is the height measurement?");
//int triHeight = Convert.ToInt32(Console.ReadLine());

//int area = (triBase * triHeight) / 2;
//Console.WriteLine($"The total area is {area}");

#endregion

#region Four sisters and the duckbear


//Console.WriteLine("How many eggs were collected today?");
//int collectedEggs = Convert.ToInt32(Console.ReadLine());

//int splitEggs = collectedEggs / 4;

//int remainingEggs = collectedEggs % 4;

//Console.WriteLine($"Each sister gets {splitEggs} and the duckbear gets {remainingEggs}");

#endregion

#region The domination of Kings


//  Estates are worth 1 point, Duchy's are worth 3 points and Provinces are worth 6 points

//Console.WriteLine("How many Estates do you have?");
//int estateCount = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("How many Duchys do you have?");
//int duchCount = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("How many Provinces do you have?");
//int provCount = Convert.ToInt32(Console.ReadLine());

//int total = (provCount * 6) + (duchCount * 3) + (estateCount * 1);

//Console.WriteLine($"You have {total} points");

#endregion

#region The Defence of Consolas

//Console.Title = "Hello World";
//Console.Beep(440, 1000);
//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.ForegroundColor = ConsoleColor.Black;

//Console.WriteLine("What is your name, human? "); // notice the space at the end
//string userName = Console.ReadLine();

//Console.WriteLine("Press any key when you're ready to begin. ");
//Console.ReadKey(true);
//Console.Clear();

//string name1 = Console.ReadLine();
//string name2 = Console.ReadLine();
//Console.WriteLine($"#1: {name1,20}");
//Console.WriteLine($"#2: {name2,20}");

//Console.Title = "Defense of Consolas";

//Console.Write("Target row? ");
//int row = Convert.ToInt32(Console.ReadLine());
//Console.Write("Target column? ");
//int column = Convert.ToInt32(Console.ReadLine());

//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine($"Deploy to:\n ({row}, {column-1})\n ({row-1}, {column})\n ({row}, {column+1}) \n ({row+1}, {column})");


#endregion

#region Repairing the Clocktower

//string input = Console.ReadLine();
//int score = Convert.ToInt32(input);

//if (score >= 90)
//{
//    Console.WriteLine("A");
//}
//else if (score >= 80)
//{
//    Console.WriteLine("B");
//}
//else if (score >= 70)
//{
//    Console.WriteLine("C");
//}
//else if (score >= 60)
//{
//    Console.WriteLine("D");
//}
//else
//{
//    Console.WriteLine("Bad luck son");
//}

//Console.Write("Insert a number: ");
//string input = Console.ReadLine();
//int num = Convert.ToInt32(input);

//if (num % 2 == 0)
//{
//    Console.WriteLine("Tick");
//}
//else
//{
//    Console.WriteLine("Tock");
//}


#endregion

#region Watchtower

//int shields = 50;
//int armor = 20;

//if (shields <= 0)
//{
//    if (armor <= 0)
//        Console.WriteLine("Shields and armor at zero! You're dead!");
//    else
//        Console.WriteLine("Shields are gone, but armor is still keeping you alive!");
//}
//else
//{
//    Console.WriteLine("You still have shields left. The world is safe!");
//}
//string textToDisplay = score > 70 ? "You passed!" : "You failed.";
//Console.WriteLine(textToDisplay);

//Console.Write("Enter an X coordinate: ");
//string x = Console.ReadLine();
//int inputx = Convert.ToInt32(x);

//Console.Write("Enter an Y coordinate: ");
//string y = Console.ReadLine();
//int inputy = Convert.ToInt32(y);

//if (inputx == 0 && inputy == 0)
//{
//    Console.WriteLine("The enemy is here!");
//}
//else if (inputx < 0)
//{
//    if (inputy > 0)
//        Console.WriteLine("The enemy is to the northwest!");
//    else if (inputy < 0)
//        Console.WriteLine("The enemy is to the southwest!");
//    else
//        Console.WriteLine("The enemy is to the west!");
//}
//else if (inputx > 0)
//{
//    if (inputy > 0)
//        Console.WriteLine("The enemy is to the northeast!");
//    else if (inputy < 0)
//        Console.WriteLine("The enemy is to the southeast!");
//    else
//        Console.WriteLine("The enemy is to the southeast!");
//}
//else if (inputx == 0)
//{
//    if (inputy > 0)
//        Console.WriteLine("The enemy is to the north!");
//    else if (inputy < 0)
//        Console.WriteLine("The enemy is to the south!");

//}

//Console.Write("x: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.Write("y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//if (x < 0 && y > 0) Console.WriteLine("The enemy is north west!");
//if (x == 0 && y > 0) Console.WriteLine("The enemy is north!");
//if (x > 0 && y > 0) Console.WriteLine("The enemy is north east!");
//if (x < 0 && y == 0) Console.WriteLine("The enemy is west!");
//if (x == 0 && y == 0) Console.WriteLine("The enemy is here!");
//if (x > 0 && y == 0) Console.WriteLine("The enemy is east!");
//if (x < 0 && y < 0) Console.WriteLine("The enemy is south west!");
//if (x == 0 && y < 0) Console.WriteLine("The enemy is south!");
//if (x > 0 && y < 0) Console.WriteLine("The enemy is south east!");

#endregion

#region Buying Inventory

//Console.WriteLine("What do you desire?");
//Console.WriteLine("1 - Rest");
//Console.WriteLine("2 - Pillage the port");
//Console.WriteLine("3 - Set sail");
//Console.WriteLine("4 - Release the Kraken");
//Console.Write("What be the plan? ");
//int choice = Convert.ToInt32(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Ye rest and recover your health");
//        break;
//    case 2:
//        Console.WriteLine("Raiding the port town get ye 50 gold");
//        break;
//    case 3:
//        Console.WriteLine("The wind is at your back; the open horizon is ahead");
//        break;
//    case 4:
//        Console.WriteLine("'Tis but a baby Kraken, but will eats toy boats");
//        break;
//    default:
//        Console.WriteLine("Apologies. I do not know that one");
//        break;
//}

//string response;
//response = choice switch
//{
//    1 => "Ye rest and recover your health",
//    2 => "Raiding the port town get ye 50 gold",
//    3 => "The wind is at your back; the open horizon is ahead",
//    4 => "'Tis but a baby Kraken, but will eats toy boats",
//    _ => "Apologies. I do not know that one"
//};

//Console.WriteLine("The following items are available: ");
//Console.WriteLine("1 - Rope");
//Console.WriteLine("2 - Torches");
//Console.WriteLine("3 - Climbing Equipment");
//Console.WriteLine("4 - Clean Water");
//Console.WriteLine("5 - Machete");
//Console.WriteLine("6 - Canoe");
//Console.WriteLine("7 - Food Supplies");
//Console.Write("What number do you want the see the price of? ");
//int choice = Convert.ToInt32(Console.ReadLine());

//string item = choice switch
//{
//    1 => "Rope",
//    2 => "Torches",
//    3 => "Climbing Equipment",
//    4 => "Clean Water",
//    5 => "Machete",
//    6 => "Canoe",
//    7 => "Food Supplies"
//};

//int price = item switch
//{
//    "Rope" => 10,
//    "Torches" => 16,
//    "Climbing Equipment" => 24,
//    "Clean Water" => 2,
//    "Machete" => 20,
//    "Canoe" => 200,
//    "Food Supplies" => 2
//};

//Console.Write("What is your name? ");
//string name = Console.ReadLine();

//if (name == "Cones") price /= 2;

//Console.WriteLine($"{item} costs {price} gold. ");


#endregion

#region The Prototype

//int x = 1;
//while (x <= 5)
//{
//    Console.WriteLine(x);
//    x++;
//}

//int playersNumber = -1;

//while (playersNumber < 0 || playersNumber > 10)
//{
//    Console.Write("Enter a number between 0 and 10: ");
//    string playerResponse = Console.ReadLine();
//    playersNumber = Convert.ToInt32(playerResponse);
//}

//int playersNumber;

//do
//{
//    Console.WriteLine("Enter a number between 0 and 10: ");
//    string playersResponse = Console.ReadLine();
//    playersNumber = Convert.ToInt32(playersResponse);
//}
//while (playersNumber < 0 || playersNumber > 10);

//for (int x = 1; x <= 5; x++)
//    Console.WriteLine(x);

//while (true)
//{
//    Console.WriteLine("Thing of a number and type it here: ");
//    string input = Console.ReadLine();

//    if (input == "quit" || input == "exit")
//        break;

//    int number = Convert.ToInt32(input);
//    if (number == 12)
//    {
//        Console.Write("I don't like that number. Pick another one.");
//    }
//    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
//}
//int playerOne;
//while (true)
//{
//    Console.Write("User 1, enter a number between 0 and 100: ");
//    playerOne = Convert.ToInt32(Console.ReadLine());
//    if (playerOne > 0 && playerOne < 100)
//        break;
//}
//Console.Clear();

//Console.Write("User 2, guess the number. ");
//while (true)
//{
//    Console.Write("What is your next guess? ");
//    string playerTwo = Console.ReadLine();



//    int number = Convert.ToInt32(playerTwo);
//    if (number > playerOne)
//    {
//        Console.WriteLine($"{number} is too high!");
//    }
//    else if (number < playerOne)
//    {
//        Console.WriteLine($"{number} is too low!");
//    }
//    else if (number == playerOne)
//    {
//        Console.WriteLine("You guessed the number!");
//        break;
//    }

//int number;
//do
//{
//    Console.Write("User 1, enter a number between 0 and 100: ");
//    number = Convert.ToInt32(Console.ReadLine());
//}
//while (number < 0 || number > 100);

//Console.Clear();
//Console.WriteLine("User 2, guess the number.");

//while (true)
//{
//    Console.Write("What is your next guess?");
//    int guess = Convert.ToInt32(Console.ReadLine());

//    if (guess > number) Console.WriteLine($"{guess} is too high.");
//    else if (guess < number) Console.WriteLine($"{guess} is too low.");
//    else break;
//}
//Console.WriteLine("You guessed the right number");

#endregion

#region The Magic Cannon

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"{i}: Fire");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        Console.WriteLine($"{i}: Electric");
//    }
//    else if (i % 5 == 0 && i % 3 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.WriteLine($"{i}: Electric and Fire");
//    }
//    else
//    {
//        Console.WriteLine($"{i}: Normal");
//    }
//}

#endregion

#region The Replicator of D'To

//int[] scores = new int[5];
//Console.WriteLine(scores.Length);

//int length = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[length];

//for (int index = 0; index < array.Length; index++)
//    array[index] = 1;

//int[] original = new int[5];

//for (int item = 0; item < 5; item++)
//{
//    Console.Write("Enter a number: ");
//    int number = Convert.ToInt32(Console.ReadLine());
//    original[item] = number;
//}

//int[] copy = new int[5];

//for (int index = 0; index < 5; index++)
//    copy[index] = original[index];

//for (int index = 0; index < 5; index++)
//    Console.WriteLine($"{original[index]} and {copy[index]}");

#endregion

#region The Laws of Freach

//int[] scores = new int[10];

//for (int index = 0; index < scores.Length; index++)
//{
//    int score = scores[index];
//    Console.WriteLine(score);
//}

//int[] scores = new int[10];

//foreach (int score in scores)
//    Console.WriteLine(score);

//int[] arrays = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

//int currentMinimum = int.MaxValue;

//foreach (int value in arrays)
//{
//    if (value < currentMinimum)
//        currentMinimum = value;
//}
//Console.WriteLine(currentMinimum);

//int total = 0;

//foreach (int value in arrays)
//    total += value;

//float average = (float)total / arrays.Length;

//Console.WriteLine(average);


#endregion

#region Taking a Number

//int firstNumber = AskForNumber("Enter the first number: ");
//int secondNumber = AskForNumberInRange("Enter the second number: ", 0, firstNumber);

////Make a method with signature int AskForNumber(string text)
//// Pick a number: 69
//int AskForNumber(string text)   // when this method is called it will require a string
//{
//    Console.Write(text);  //user will pass in the text and add a space
//    int chosenNumber = Convert.ToInt32(Console.ReadLine());
//    return chosenNumber;
//}

////Make another method with signature int AskForNumberInRange(string text, int min, int max)

//int AskForNumberInRange(string text, int min, int max)  // when this method is called it will require a string and 2 ints
//{
//    while (true) 
//    {
//        Console.Write(text); 
//        int chosenNumber = Convert.ToInt32(Console.ReadLine());

//        if(chosenNumber >= min && chosenNumber <= max)
//        return chosenNumber;
//    }
//}

#endregion

#region Hunting the Manticore

//int cityHealth = 15;
//int manticoreHealth = 10;
//int roundNumber = 1;

//int distanceToCity = AskForDistance("Player 1, how far away from the city do you want to station the Manticore? ");

//Console.Clear();
//Console.WriteLine("Player 2, it is your turn.");

//while (manticoreHealth > 0 && cityHealth > 0)
//{
//    Console.WriteLine("----------------------------------------------------");
//    Console.WriteLine($"STATUS: Round {roundNumber}  City {cityHealth}/15   Manticore: {manticoreHealth}/10");
//    int expectedDamage = ComputeDamage(roundNumber);
//    Console.WriteLine($"The cannon is expected to deal {expectedDamage} damage this round.");
//    int targetRange = AskForDistance("Enter the desired cannon range ");

//    DisplayResult(targetRange, distanceToCity);


//    if (targetRange == distanceToCity)
//        manticoreHealth -= expectedDamage;

//    if (manticoreHealth > 0) cityHealth--;

//    roundNumber++;
//}

//if (manticoreHealth <= 0) Console.WriteLine("The Manticore has been destoryed! The city of Consolas has been saved!");
//else Console.WriteLine("The city of Consolas has been destoryed!");

//void DisplayResult(int target, int actual)
//{
//    if (target == actual)
//        Console.WriteLine("That round was a DIRECT HIT!");
//    if (target < actual)
//        Console.WriteLine("That round FELL ShORT of the target!");
//    if (target > actual)
//        Console.WriteLine("That round OVERSHOT the target!");
//}

//int ComputeDamage(int round)
//{
//    bool isMultipleOfFive = round % 5 == 0;
//    bool isMultipleOfThree = round % 3 == 0;

//    if (isMultipleOfFive && isMultipleOfThree) return 10;
//    if (isMultipleOfFive) return 3;
//    if (isMultipleOfThree) return 3;
//    return 1;
//}


//int AskForDistance(string message)
//{
//    Console.Write(message);

//    return Convert.ToInt32(Console.ReadLine());

//}

#endregion

#region Enumeration - Simula's Test

//Season current = Season.Spring;

//if ( current == Season.Summer || current == Season.Winter)
//    Console.WriteLine("Happy solstice!");
//else
//    Console.WriteLine("Happy equinox");

//// add enuumerations at the end of your file
//enum Season { Winter, Spring, Summer, Fall  }


//StateOfChest current = StateOfChest.Close;

//Console.WriteLine("The chest is Locked. What do you want to do? ");
//while (true)
//{
//    string answer = AskPlayer($"What do you want to do? ");
//    DisplayResult(answer);
//}

//string AskPlayer(string message)
//{
//    Console.Write(message);
//    return Console.ReadLine();
//}

//void DisplayResult(string result)
//{
//    if (result == $"{StateOfChest.Unlock}")
//        Console.WriteLine("The chest is unlocked");
//    if (result == $"{StateOfChest.Open}")
//        Console.WriteLine("The chest is open");
//    if (result == $"{StateOfChest.Close}")
//        Console.WriteLine("The chest is close");
//}

//enum StateOfChest
//{
//    Open,
//    Close,
//    Unlock,
//    Lock
//}

#endregion

#region Tuples - Simula's Soup

//string[] names  = new string[3] { "R2-D2", "C-3PO", "GONK" };
//int[] points = new int[3] { 12420, 8543, -1 };
//int[] level = new int[3] { 15, 9, 1 };

//(string, int, int) score = ("R2-D2", 12420, 15);

//var score = ("R2-D2", 12420, 15);

//var score = (Name:"R2-D2", Points:12420, Level:15);

//(string Name, int Points, int Level) score = ("R2-D2", 12420, 15);

//Console.WriteLine($"Name: {score.Name} Level: {score.Level}    Score: {score.Points}");

//(string Name, int Points, int Level) score = ("John", 12420, 15);

//DisplayScore(score);

//void DisplayScore ((string Name, int Points, int Level) score)
//{
//    Console.WriteLine($"Name: {score.Name} Level: { score.Level} Score: { score.Points}");
//}

//var tile = (Row: 2, Column: 4, Type: TileType.Grass);

//enum TileType { Grass, Water, Rock}

//(string Name, int Points, int Level)[] CreateHighScores()
//{
//    return new (string, int, int)[3]
//    {
//        ("R2-D2", 12420, 15),
//        ("C-3PO", 8543, 9),
//        ("GONK", -1, 1),
//    };
//}

//string name;
//int points;
//int level;

//(name, points, level) = score;
//Console.WriteLine($"{name} reached level {level} with {points} points");

//Console.WriteLine("Menu Items: Soup, Stew, Gumbo");
//Console.WriteLine("Menu Items: Mushroom, Chicken, Carrot, Potatoes");
//Console.WriteLine("Menu Items: Spicy, Salty, Sweet");

//SoupType type = GetSoupType();
//Ingredient mainIngredient = GetIngredient();
//Seasoning mainSeasoning = GetSeasoning();


//(SoupType Type, Ingredient MainIngredient, Seasoning Seasoning) soup = (type, mainIngredient, mainSeasoning);

//Console.WriteLine($"You've made the {soup.Seasoning} {soup.MainIngredient} {soup.Type}");

//SoupType GetSoupType()
//{
//    Console.Write("What type of soup do you want? ");
//    string typeAsAString = Console.ReadLine().ToLower();

//    return typeAsAString switch
//    {
//        "soup" => SoupType.Soup,
//        "gumbo" => SoupType.Gumbo,
//        "stew" => SoupType.Stew,
//        _ => SoupType.Soup
//    };
//}


//Ingredient GetIngredient()
//{
//    Console.Write("What do you want for the main ingredient? ");
//    string ingredAsAString = Console.ReadLine().ToLower();

//    return ingredAsAString switch
//    {
//        "mushroom" or "mushrooms " => Ingredient.Mushroom,
//        "chicken" => Ingredient.Chicken,
//        "potatoes" or "potatoe" => Ingredient.Potatoes,
//        "carrot" or "carrots" => Ingredient.Carrot
//    };
//}

//Seasoning GetSeasoning()
//{
//    Console.Write("What do you want for the seasoning? ");
//    string seasoningAsAString = Console.ReadLine().ToLower();

//    return seasoningAsAString switch
//    {
//        "spicy" => Seasoning.Spicy,
//        "salty" => Seasoning.Salty,
//        "sweet" => Seasoning.Sweet,
//    };
//}


//enum SoupType { Soup, Stew, Gumbo}
//enum Ingredient { Mushroom, Chicken, Carrot, Potatoes}
//enum Seasoning { Spicy, Salty, Sweet}

#endregion

#region Classes -  Vin Fletcher's Arrows

//// an object is a thing in your software, responsible for a slice of the entire program, containing data and methods.



//Score a = new Score("R2-D2", 12420, 15);

//Score b = new Score("C-3P0", 8543, 8);


//if (a.EarnedStar())
//    Console.WriteLine("You earned a star!");
//if (b.EarnedStar())
//    Console.WriteLine("You earned a star!");

//class Score
//{
//    public string name;
//    public int points;
//    public int level;

//    public Score()
//    {
//        name = "Unknown";
//        points = 0;
//        level = 1;
//    }

//    public Score(string n, int p, int l)
//    {
//        name = n;
//        points = p;
//        level = l;
//    }

//    public bool EarnedStar() => (points / level) > 1000;
//}

//// Allow the user to pick an arrowhead

//Arrowhead arrowheadType = GetArrowheadType();
//Fletching fletchingType = GetFlectingType();
//float length = GetLength();

//Arrow arrow = new Arrow(arrowheadType, fletchingType, length);
//Console.WriteLine($"This arrow costs {arrow.GetCost()} gold");

//// Create a method for user input

//Arrowhead GetArrowheadType()
//{
//    Console.WriteLine("Pick an arrowhead type (1 = Steel, 2 = Wood, 3 = Obsidian): ");
//    int option = Convert.ToInt32(Console.ReadLine());
//    return option switch
//    {
//        1 => Arrowhead.Steel,
//        2 => Arrowhead.Wood,
//        3 => Arrowhead.Obsidian
//    };
//}

//Fletching GetFlectingType()
//{
//    Console.WriteLine("Pick an fletching type (1 = Plastic, 2 = Turkey, 3 = Goose): ");
//    int option = Convert.ToInt32(Console.ReadLine());
//    return option switch
//    {
//        1 => Fletching.Plastic,
//        2 => Fletching.Turkey,
//        3 => Fletching.Goose
//    };
//}

//float GetLength()
//{
//    float length = 0;
//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }
//    return length;
//}

//// Create a class for Arrow with fields for arrowhead type
//class Arrow
//{
//    public Arrowhead _arrowHeadType;
//    public Fletching _fletchingType;
//    public float _length;

//    public Arrow(Arrowhead arrowHeadType, Fletching fletchingType, float length)
//    {
//        _arrowHeadType = arrowHeadType;
//        _fletchingType = fletchingType;
//        _length = length;

//    }
//    // Add a GetCost method inside the class that returns its cost as a float
//    public float GetCost()
//    {
//        float fletchingType = 0.05f * _length;

//        float arrowheadCost = _arrowHeadType switch
//        {
//            Arrowhead.Steel => 10,
//            Arrowhead.Wood => 3,
//            Arrowhead.Obsidian => 5,
//            _ => throw new ArgumentException("Invalid arrowhead type")
//        };

//        float fletchingCost = _fletchingType switch
//        {
//            Fletching.Plastic => 10,
//            Fletching.Turkey => 5,
//            Fletching.Goose => 3
//        };
//        return arrowheadCost + fletchingCost + fletchingType;
//    }
//}

//enum Arrowhead { Steel, Wood, Obsidian}
//enum Fletching { Plastic, Turkey, Goose}


#endregion

#region Information Hiding - Vin's Trouble

//Rectangle rectangle = new Rectangle(2, 3);
//rectangle.SetWidth(3);
//Console.WriteLine(rectangle.GetArea());


//class Rectangle
//{
//    private float _width;
//    private float _height;
//    private float _area;

//    public Rectangle(float width, float height) //Constructor
//    {
//        _width = width;
//        _height = height;
//        _area = width * height;
//    }

//    //Create methods so information is accessable outside of class
//    public float GetWidth() => _width;
//    public float GetHeight() => _height;
//    public float GetArea() => _area;

//    //Create methods so that we are able to change rectangles dimensions
//    public void SetWidth(float value)
//    {
//        _width = value;
//        _area = _width * _height;
//    }

//    public void SetHeight(float value)
//    {
//        _height = value;
//        _area = _width * _height;
//    }
//}





#endregion

#region Properties - The Properties of Arrows

//Rectangle r = new Rectangle(2, 3);
//r.Width = 5;
//Console.WriteLine($"A {r.Width} * {r.Height} rectangle has an area of {r.Area}.");


//public class Rectangle
//{
//    private float _width;
//    private float _height;

//    public Rectangle(float width, float height)
//    {
//        _width = width;
//        _height = height;
//    }

//    //Create a property with the name Width
//    public float Width
//    {
//        get => _width;
//        set => _width = value;
//    }
//    public float Height
//    {
//        get => _height;
//        set => _height = value;
//    }
//    public float Area => _width * _height;
//}


////Immutable fields
//public class Player
//{
//    public string Name { get; } = "Player 1";
//    public Player(string name)
//    {
//        Name = name;
//    }
//}

//Arrow arrow = GetArrow();
//Console.WriteLine($"That arrow costs {arrow.Cost} gold.");



//Arrow GetArrow()
//{
//    Arrowhead arrowhead = GetArrowheadType();
//    Fletching fletching = GetFletchingType();
//    float length = GetLength();

//    return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//    Console.Write("Arrowhead type (steel, wood, obsidian): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "steel" => Arrowhead.Steel,
//        "wood" => Arrowhead.Wood,
//        "obsidian" => Arrowhead.Obsidian
//    };
//}

//Fletching GetFletchingType()
//{
//    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "plastic" => Fletching.Plastic,
//        "turkey feather" => Fletching.TurkeyFeathers,
//        "goose feather" => Fletching.GooseFeathers
//    };
//}

//float GetLength()
//{
//    float length = 0;

//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }

//    return length;
//}

//public class Arrow
//{
//    public Arrowhead Arrowhead { get; }
//    public Fletching Fletching { get; }
//    public float Length { get; }

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        Arrowhead = arrowhead;
//        Fletching = fletching;
//        Length = length;
//    }

//    public float Cost
//    {
//        get
//        {
//            float arrowheadCost = Arrowhead switch
//            {
//                Arrowhead.Steel => 10,
//                Arrowhead.Wood => 3,
//                Arrowhead.Obsidian => 5
//            };
//            float fletchingCost = Fletching switch
//            {
//                Fletching.Plastic => 10,
//                Fletching.TurkeyFeathers => 5,
//                Fletching.GooseFeathers => 3
//            };
//            float shaftCost = 0.05f * Length;

//            return arrowheadCost + fletchingCost + shaftCost;
//        }
//    }
//}

//public enum Arrowhead { Steel, Wood, Obsidian}
//public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers}

#endregion

#region Static - Arrow Factories

//public class Score
//{
//    private static readonly int PointThreshold;
//    private static readonly int LevelThreshold;
//    public int Points;
//    public int Level;

//    public bool IsWorthyOfTheHighScoreTable()
//    {
//        if (Points < PointThreshold) return false;
//        if (Level < LevelThreshold) return false;
//        return true;
//    }

//    static Score()
//    {
//        PointThreshold = 1000;
//        LevelThreshold = 4;
//    }

//}

//Console.WriteLine("What arrow do you want?");
//Console.WriteLine("1 - Elite Arrow");
//Console.WriteLine("2 - Beginner Arrow");
//Console.WriteLine("3 - Marksman Arrow");
//Console.WriteLine("4 - Custom Arrow");

//string choice = Console.ReadLine();

//Arrow arrow = choice switch
//{
//    "1" => Arrow.CreateEliteArrow(),
//    "2" => Arrow.CreateBeginnerArrow(),
//    "3" => Arrow.CreateMarksmanArrow(),
//    _ => CreateCustomArrow(),
//};

//Console.WriteLine($"That arrow costs {arrow.Cost} gold.");



//Arrow CreateCustomArrow()
//{
//    Arrowhead arrowhead = GetArrowheadType();
//    Fletching fletching = GetFletchingType();
//    float length = GetLength();

//    return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//    Console.Write("Arrowhead type (steel, wood, obsidian): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "steel" => Arrowhead.Steel,
//        "wood" => Arrowhead.Wood,
//        "obsidian" => Arrowhead.Obsidian
//    };
//}

//Fletching GetFletchingType()
//{
//    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "plastic" => Fletching.Plastic,
//        "turkey feather" => Fletching.TurkeyFeathers,
//        "goose feather" => Fletching.GooseFeathers
//    };
//}

//float GetLength()
//{
//    float length = 0;

//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }

//    return length;
//}

//public class Arrow
//{
//    public Arrowhead Arrowhead { get; }
//    public Fletching Fletching { get; }
//    public float Length { get; }

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        Arrowhead = arrowhead;
//        Fletching = fletching;
//        Length = length;
//    }

//    public float Cost
//    {
//        get
//        {
//            float arrowheadCost = Arrowhead switch
//            {
//                Arrowhead.Steel => 10,
//                Arrowhead.Wood => 3,
//                Arrowhead.Obsidian => 5
//            };

//            float fletchingCost = Fletching switch
//            {
//                Fletching.Plastic => 10,
//                Fletching.TurkeyFeathers => 5,
//                Fletching.GooseFeathers => 3
//            };

//            float shaftCost = 0.05f * Length;

//            return arrowheadCost + fletchingCost + shaftCost;
//        }
//    }

//    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
//    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
//    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
//}

//public enum Arrowhead { Steel, Wood, Obsidian }
//public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

#endregion

#region Creating Code - Asteriod

//AsteriodsGame game = new AsteriodsGame();
//game.Run();


//public class Asteriod
//{
//    public float PositionX { get; private set; }
//    public float PositionY { get; private set; }
//    public float VelocityX { get; private set; }
//    public float VelocityY { get; private set; }

//    public Asteriod(float positionX, float positionY, float velocityX, float velocityY)
//    {
//        PositionX = positionX;
//        PositionY = positionY;
//        VelocityX = velocityX;
//        VelocityY = velocityY;
//    }

//    public void Update()
//    {
//        PositionX += VelocityX;
//        PositionY += VelocityY;
//    }
//}

//public class AsteriodsGame
//{
//    private Asteriod[] _asteriods;

//    public AsteriodsGame()
//    {
//        _asteriods = new Asteriod[5];
//        _asteriods[0] = new Asteriod(100, 200, -4, -2);
//        _asteriods[1] = new Asteriod(-50, 100, -1, +3);
//        _asteriods[2] = new Asteriod(0, 0, 2, 1);
//        _asteriods[3] = new Asteriod(400, -100, -3, -1);
//        _asteriods[4] = new Asteriod(200, -300, 0, 3);
//    }

//    public void Run()
//    {
//        while (true)
//        {
//            foreach (Asteriod asteriod in _asteriods)
//                asteriod.Update();
//        }
//    }

//}


#endregion

#region The Catacombs of the Class - The Point

//// In your main method, create a point at (2, 3) and another at (-4, 0).
//Point point1 = new Point(2, 3);
//Point point2 = new Point(-4, 0);

////Display the points on the console

//Console.WriteLine("Point 1: " + point1);
//Console.WriteLine("Point 2: " + point2);

//// Define a new point class with the properties for X and Y

//class Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    // Add a constructor to creat a point from a specific x- and y-coordinate
//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }

//    // Add a parameterless constructor to create a point at the origin (0, 0)
//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }

//    // Override ToString() for easy display of point in (x, y) format
//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }

//}
#endregion

#region  The Catacombs of the Class - The Color

//Color customColor = new Color(255, 165, 0);

//Color predefinedColor = Color.RedColor;

//Console.WriteLine("Custom color (Orange)");
//Console.WriteLine($"Red: {predefinedColor.Red}, Green: {predefinedColor.Green}, Blue: {predefinedColor.Blue}");


//// Define a new Color class with properties for red, green and blue
//class Color
//{
//    public int Red { get; set; }
//    public int Green { get; set; }
//    public int Blue { get; set; }

//    // Add a constructor
//    public Color(int red, int green, int blue)
//    {
//        Red = red;
//        Green = green;
//        Blue = blue;
//    }

//    public Color()
//    {
//        Red = 0;
//        Green = 0;
//        Blue = 0;
//    }

//    // Static properties for commonly used colors
//    public static Color RedColor => new Color(255, 0, 0);
//    public static Color GreenColor => new Color(0, 255, 0);
//    public static Color BlueColor => new Color(0, 0, 255);
//    public static Color BlackColor => new Color(0, 0, 0);
//    public static Color WhiteColor => new Color(255, 255, 255);
//    public static Color YellowColor => new Color(255, 255, 0);
//    public static Color CyanColor => new Color(0, 255, 255);
//    public static Color MagentaColor => new Color(255, 0, 255);

//    public void DisplayColor()
//    {
//        Console.WriteLine($"Color (R: {Red}, G: {Green}, B: {Blue}");
//    }

//}



#endregion

#region The Catacombs of the Class - The Cards

//Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
//Rank[] ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

//foreach (Color color in colors)
//{
//    foreach (Rank rank in ranks)
//    {
//        Card card = new Card(rank, color);
//        Console.WriteLine($"The {card.Color} {card.Rank}");
//    }
//}

//public class Card
//{
//    public Rank Rank { get; }
//    public Color Color { get; }

//    public Card(Rank rank, Color color)
//    {
//        Rank = rank;
//        Color = color;
//    }
//    public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
//    public bool IsNumber => !IsSymbol;
//}

//public enum Color { Red, Blue, Green, Yellow}
//public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }


#endregion

#region The Catacombs of the Class - The Locked Door

//// Ask the user for a starting passcode
//Console.WriteLine("Please enter a starting passcode for the door: ");
//int startingPasscode = Convert.ToInt32(Console.ReadLine());

////  Create a new door instance with the provided passcode
//Door myDoor = new Door(startingPasscode);

////  Menu loop for user commands
//bool exit = false;
//while (!exit)
//{
//    Console.WriteLine("\nAvailable commands: open, close, lock, unlock, change-passcode, check, exit");
//    Console.Write("Enter a command: ");
//    string command = Console.ReadLine().ToLower();
//    switch (command)
//    {
//        case "open":
//            myDoor.Open();
//            break;

//        case "close":
//            myDoor.Closed();
//            break;

//        case "lock":
//            Console.Write("Enter passcode to lock the door: ");
//            int lockPasscode = int.Parse(Console.ReadLine());
//            myDoor.Lock(lockPasscode);
//            break;

//        case "unlock":
//            Console.Write("Enter passcode to unlock the door: ");
//            int unlockPasscode = int.Parse(Console.ReadLine());
//            myDoor.Unlock(unlockPasscode);
//            break;

//        case "change-passcode":
//            Console.Write("Enter current passcode: ");
//            int currentPasscode = int.Parse(Console.ReadLine());
//            Console.Write("Enter new passcode: ");
//            int newPasscode = int.Parse(Console.ReadLine());
//            myDoor.ChangePasscode(currentPasscode, newPasscode);
//            break;

//        case "check":
//            myDoor.CheckState();
//            break;

//        case "exit":
//            exit = true;
//            Console.WriteLine("Exiting...");
//            break;

//        default:
//            Console.WriteLine("Invalid command. Please try again.");
//            break;
//    }
//}

//public class Door
//{
//    private DoorState state;
//    private int passcode;

//    //  Constructor: Initially, the door is closed
//    public Door(int startingPasscode)
//    {
//        state = DoorState.Closed;
//        passcode = startingPasscode;
//    }

//    //  Method to open the door
//    public void Open()
//    {
//        if (state == DoorState.Locked)
//        {
//            Console.WriteLine("Cannot open the door it is locked.");
//        }
//        else
//        {
//            state = DoorState.Open;
//            Console.WriteLine("The door is now open.");
//        }
//    }

//    public void Closed()
//    {
//        if (state == DoorState.Open)
//        {
//            state = DoorState.Closed;
//            Console.WriteLine("The door is now closed.");
//        }
//        else
//        {
//            Console.WriteLine("The door is already closed.");
//        }
//    }

//    public void Lock(int inputPasscode)
//    {
//        if (state == DoorState.Open)
//        {
//            Console.WriteLine("Cannot lock the door, it's open.");
//        }
//        else if (inputPasscode == passcode)
//        {
//            state = DoorState.Locked;
//            Console.WriteLine("The door is now locked.");
//        }
//        else
//        {
//            Console.WriteLine("Incorrect passcode. The door remains unlocked.");
//        }
//    }

//    public void Unlock(int inputPasscode)
//    {
//        if (state == DoorState.Locked && inputPasscode == passcode)
//        {
//            state = DoorState.Closed;
//            Console.WriteLine("The door is now unlocked.");
//        }
//        else if (state != DoorState.Locked)
//        {
//            Console.WriteLine("The door is not locked.");
//        }
//        else
//        {
//            Console.WriteLine("Incorrect passcode. The door reamins locked.");
//        }
//    }

//    //  Method to change the passcode (requires current passcode and new passcode)
//    public void ChangePasscode(int currentPasscode, int newPasscode)
//    {
//        if (currentPasscode == passcode)
//        {
//            passcode = newPasscode;
//            Console.WriteLine("Passcode has been successfully changed.");
//        }
//        else
//        {
//            Console.WriteLine("Incorrect current passcode. Passcode not changed.");
//        }
//    }

//    public void CheckState()
//    {
//        Console.WriteLine("The door is currently " + state );
//    }
//}

//enum DoorState
//{
//    Open,
//    Closed,
//    Locked
//}

#endregion

#region Inheritance - Packing Inventory

//Point p1 = new Point(2, 4);
//Point p2 = p1;
//Console.WriteLine(p1.ToString());
//Console.Write(p1.Equals(p2));

//object thing = new Point(2, 4);
//Console.WriteLine(thing.ToString());


//public class Point
//{
//    public float X { get; }
//    public float Y { get; }

//    public Point(float x, float y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//GameObject[] gameObjects = new GameObject[] // The arrays stores references to GameObject, Asteroid, Bullet and Ship instances
//{
//    new Asteroid(), new Asteroid(), new Asteroid(),
//    new Bullet(), new Ship()
//};

//public class GameObject
//{
//    public float PositionX { get; set; }
//    public float PositionY { get; set; }
//    public float VelocityX { get; set; }
//    public float VelocityY { get; set; }

//    public GameObject()
//    {
//        PositionX = 2;
//        PositionY = 4;
//    }
//    public void Update()
//    {
//        PositionX += VelocityX;
//        PositionY += VelocityY;
//    }
//}

//public class Asteroid : GameObject 
//{
//    // Will in herit PositionX/Y & VelocityX/Y from GameObject class and add Size and Rotation properties
//    public float Size { get; }
//    public float RotationAngle { get; }

//    public Asteroid()
//    {
//        RotationAngle = -1;
//    }
//}

//public class Bullet : GameObject
//{
//    public float Size { get; }
//    public float Speed { get; }
//}

//public class Ship : GameObject
//{
//    public float Size { get; }
//    public float Speed { get; }
//}


// Create an inventoryItem class
public class InventoryItem
{

    public float Weight { get; }
    public float Volume { get; }

    // Constructor
    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Pack
{
    public int MaxCount { get; }
    public float MaxVolume { get; }
    public float MaxWeight { get; }

    private InventoryItem[] _items;

    public int CurrentCount { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        MaxCount = maxCount;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;

        _items = new InventoryItem[maxCount];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxVolume) return false;
        if (CurrentVolume + item.Volume > MaxVolume) return false;
        if (CurrentWeight + item.Weight > MaxWeight) return false;

        _items[CurrentCount] = item;
        CurrentCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }
}


public class Arrow : InventoryItem { public Arrow() : base(0.1f, 0.05f) { } }
public class Bow : InventoryItem { public Bow() : base(1f, 4f) { } }
public class Rope : InventoryItem { public Rope() : base(1f, 1.5f) { } }
public class Water : InventoryItem { public Water() : base(2f, 3f) { } }
public class Food : InventoryItem { public Food() : base(1f, 0.5f) { } }
public class Sword : InventoryItem { public Sword() : base(5f, 3f) { } }



#endregion

#region Polymorphism - Labeling Inventory

//public class ChessPiece // Base class
//{
//    public int Row { get; set; }
//    public int Column { get; set; }

//    public virtual bool IsLegalMove(int row, int column) => // Polymorphism
//        IsOnBoard(row, column) && !IsCurrentLocation(row, column);

//    protected bool IsOnBoard(int row, int column) =>
//        row >= 0 && row < 8 && column >= 0 && column < 8;

//    protected bool IsCurrentLocation(int row, int column) =>
//        row == Row && column == Column;
//}

//public class King : ChessPiece // Derived class
//{
//    public override bool IsLegalMove(int row, int column) // Polymorphism
//    {
//        if (!base.IsLegalMove(row, column)) return false;

//        //  Moving more than one row or one column is not a legal king move
//        if (Math.Abs(row - Row) > 1) return false;
//        if (Math.Abs(column - Column) > 1) return false;

//        return true;
//    }
//}

//public class Pawn : ChessPiece // Derived class
//{
//    public override bool IsLegalMove(int row, int column)
//    {
//        if (!base.IsLegalMove(row, column)) return false;

//        if (Math.Abs(row - Row) > 1) return false;
//        if (Math.Abs(column - Column) > 1) return false;

//        return true;
//    }
//}

//public class Rook : ChessPiece // Derived class
//{
//    public override bool IsLegalMove(int row, int column)
//    {
//        if (!base.IsLegalMove(row, column)) return false;

//        if (Math.Abs(row - Row) > 1) return false;
//        if (Math.Abs(column - Column) > 1) return false;

//        return true;
//    }
//}

//Pack pack = new Pack(10, 20, 30);

//while (true)
//{
//    Console.WriteLine(pack);
//    Console.WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");

//    Console.WriteLine("What do you want to add?");
//    Console.WriteLine("1 - Arrow");
//    Console.WriteLine("2 - Bow");
//    Console.WriteLine("3 - Rope");
//    Console.WriteLine("4 - Water");
//    Console.WriteLine("5 - Food");
//    Console.WriteLine("6 - Sword");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    InventoryItem newItem = choice switch
//    {
//        1 => new Arrow(),
//        2 => new Bow(),
//        3 => new Rope(),
//        4 => new Water(),
//        5 => new Food(),
//        6 => new Sword()
//    };

//    if (!pack.Add(newItem))
//        Console.WriteLine("Could not add this to the pack.");
//}

//public class Pack
//{
//    public int MaxCount { get; }
//    public float MaxVolume { get; }
//    public float MaxWeight { get; }

//    private InventoryItem[] _items;

//    public int CurrentCount { get; private set; }
//    public float CurrentVolume { get; private set; }
//    public float CurrentWeight { get; private set; }

//    public Pack(int maxCount, float maxVolume, float maxWeight)
//    {
//        MaxCount = maxCount;
//        MaxVolume = maxVolume;
//        MaxWeight = maxWeight;

//        _items = new InventoryItem[maxCount];
//    }

//    public bool Add(InventoryItem item)
//    {
//        if (CurrentCount >= MaxCount) return false;
//        if (CurrentVolume + item.Volume > MaxVolume) return false;
//        if (CurrentWeight + item.Weight > MaxWeight) return false;

//        _items[CurrentCount] = item;
//        CurrentCount++;
//        CurrentVolume += item.Volume;
//        CurrentWeight += item.Weight;
//        return true;
//    }

//    public override string ToString()
//    {
//        string contents = "Pack containing ";
//        if (CurrentCount == 0) contents += "Nothing";

//        for (int itemNumber = 0; itemNumber < CurrentCount; itemNumber++)
//            contents += _items[itemNumber].ToString() + " ";

//        return contents;
//    }
//}

//public class InventoryItem
//{
//    public float Weight { get; }
//    public float Volume { get; }

//    public InventoryItem(float weight, float volume)
//    {
//        Weight = weight;
//        Volume = volume;
//    }
//}

//public class Arrow : InventoryItem
//{
//    public Arrow() : base(0.1f, 0.05f) { }

//    public override string ToString() => "Arrow";
//}

//public class Bow : InventoryItem
//{
//    public Bow() : base(1, 4) { }

//    public override string ToString() => "Bow";
//}

//public class Rope : InventoryItem
//{
//    public Rope() : base(1, 1.5f) { }

//    public override string ToString() => "Rope";
//}

//public class Water : InventoryItem
//{
//    public Water() : base(2, 3) { }

//    public override string ToString() => "Water";
//}

//public class Food : InventoryItem
//{
//    public Food() : base(1, 0.5f) { }

//    public override string ToString() => "Food";
//}

//public class Sword : InventoryItem
//{
//    public Sword() : base(5, 3) { }

//    public override string ToString() => "Sword";
//}

#endregion

#region  Polymorphism - The Old Robot

//Robot robot = new Robot();

//for (int index = 0; index < robot.Commands.Length; index++)
//{
//    string? input = Console.ReadLine();
//    RobotCommand newCommand = input switch
//    {
//        "on" => new OnCommand(),
//        "off" => new OffCommand(),
//        "north" => new NorthCommand(),
//        "south" => new SouthCommand(),
//        "east" => new EastCommand(),
//        "west" => new WestCommand(),
//    };
//    robot.Commands[index] = newCommand;
//}

//Console.WriteLine();

//robot.Run();

//public class OffCommand : RobotCommand
//{
//    public override void Run(Robot robot) => robot.IsPowered = false;
//}

//public class OnCommand : RobotCommand
//{
//    public override void Run(Robot robot) => robot.IsPowered = true;
//}

//public class WestCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.X--; }
//}

//public class EastCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.X++; }
//}

//public class SouthCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.Y--; }
//}

//public class NorthCommand : RobotCommand
//{
//    public override void Run(Robot robot) { if (robot.IsPowered) robot.Y++; }
//}

//public abstract class RobotCommand
//{
//    public abstract void Run(Robot robot);
//}

//public class Robot
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//    public bool IsPowered { get; set; }
//    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
//    public void Run()
//    {
//        foreach (RobotCommand? command in Commands)
//        {
//            command?.Run(this);
//            Console.WriteLine($"[{X} {Y} {IsPowered}]");
//        }
//    }
//}



#endregion

#region Interfaces



#endregion