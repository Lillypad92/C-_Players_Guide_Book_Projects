
/*Challenges from the book the C# player's guide, fifth edition.*/

// Arrays 
/*The Replicator of D´To challenge*/
//int[] firstArray = new int[5];
//int index = 0;
//Console.WriteLine("I want you to pick five numbers. You can pick any number.");

//while (true) 
//{
//    Console.WriteLine("Pick a new number");
//    int usersAnswer = int.Parse(Console.ReadLine());
//    firstArray[index++] = usersAnswer;

//    if (index == firstArray.Length) 
//    {
//        break;
//    }
//}
//int[] secondArray = new int[5];
//for (int i = 0; i < 5; i++) 
//{
//    secondArray[i] = firstArray[i];
//    Console.WriteLine($"This is the first array: {firstArray[i]}");
//    Console.WriteLine($"This is the second array: {secondArray[i]}");
//};

// The Laws of Freach
// foreach loop
//int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90};

//int currentSmallest = int.MinValue;
//foreach (int index in array) 
//{
//    Console.WriteLine(index);
//}
//Console.WriteLine(currentSmallest);

// for loop
//for (int index = 0; index < array.Length; index++) 
//{
//    if (array[index] < currentSmallest)
//        currentSmallest = array[index];
//        Console.WriteLine(currentSmallest);  
//}

// Repairing the Clocktower
//Even number = tick
//Odd number = tock
//int remainder = 2;
//Console.WriteLine("We need to figure it out if the clock is even or odd. Write any number.");
//int input = int.Parse(Console.ReadLine());
//int clockResult = (input % remainder);

//if (clockResult == 0) {

//    Console.WriteLine("The clock is even: Tick");
//}
//else {

//    Console.WriteLine("The clock is odd: Tock");
//}

// The Watchtower
//Console.WriteLine("This is the watchtower that can alert the city Consolas.");
//Console.WriteLine("In order to know if there is an upcoming attack, the watchtower needs an X-value and Y-value.");
//Console.WriteLine("You can add numbers between 0-10 and also add subtraction (-) numbers.\nPlease enter a numer below.");
//Console.Write("I want an x value: ");
//int xValue = int.Parse(Console.ReadLine());
//Console.Write("I want an y value: ");
//int yValue = int.Parse(Console.ReadLine());

//if (xValue == 0 && yValue == 0)
//{
//    Console.WriteLine("The enemy is here!");
//}
//else if (xValue == 0 && yValue > 0)
//{
//    Console.WriteLine("The enemy is to the north!");
//}
//else if (xValue < 0 && yValue > 0)
//{
//    Console.WriteLine("The enemy is to the northwest!");
//}
//else if (xValue < 0 && yValue == 0)
//{
//    Console.WriteLine("The enemy is to the west!");
//}
//else if (xValue < 0 && yValue < 0)
//{
//    Console.WriteLine("The enemy is to the southwest!");
//}
//else if (xValue == 0 && yValue < 0)
//{
//    Console.WriteLine("The enemy is to the south!");
//}
//else if (xValue > 0 && yValue < 0)
//{
//    Console.WriteLine("The enemy is to the southeast!");
//}
//else if (xValue > 0 && yValue == 0)
//{
//    Console.WriteLine("The enemy is to the east!");
//}
//else if (xValue > 0 && yValue > 0)
//{
//    Console.WriteLine("The enemy is to the northeast!");
//}

// Buying inventory 
//string myName = "Linda";
//Console.WriteLine("Welcome! This is the shop that you can buy some supplies.");
//Console.WriteLine("The following items are available: ");
//Console.WriteLine("1 - Rope");
//Console.WriteLine("2 - Torches");
//Console.WriteLine("3 - Climbing Equipment");
//Console.WriteLine("4 - Clean Water");
//Console.WriteLine("5 - Machete");
//Console.WriteLine("6 - Canoe");
//Console.WriteLine("7 - Food Supplies");
//Console.Write("What number do you want to see the price of? ");
//int usersInput = int.Parse(Console.ReadLine());
//Console.WriteLine("You can get a 50% discount if you anwser this question correctly.\nWhat is your name? ");
//string usersName = Console.ReadLine();

//switch (usersInput) {

//    case 1: 
//        if (usersName == myName)
//        {            
//            Console.WriteLine("The rope costs 5 gold.");
//        }
//        else {
//            Console.WriteLine("The rope costs 10 gold.");
//        }
//        break;

//    case 2:
//        if (usersName == myName)
//        {
//            Console.WriteLine($"The torches costs 15 gold.");
//        }
//        else
//        {
//            Console.WriteLine("The torches costs 7,5 gold.");
//        }
//        break;

//    case 3:
//        if (usersName == myName)
//        {
//            Console.WriteLine($"The climbing equipment costs 12,5 gold.");
//        }
//        else
//        {
//            Console.WriteLine("The climbing equipment costs 25 gold.");
//        }
//        break;

//    case 4:
//        if (usersName == myName)
//        {
//            Console.WriteLine($"The clean water costs 1 gold.");
//        }
//        else
//        {
//            Console.WriteLine("The clean water costs 0,5 gold.");
//        }
//        break;

//    case 5:
//        if (usersName == myName)
//        {
//            Console.WriteLine($"The machete costs 10 gold.");
//        }
//        else
//        {
//            Console.WriteLine("The machete costs 20 gold.");
//        }        
//        break;

//    case 6:
//        if (usersName == myName)
//        {
//            Console.WriteLine($"The canoe costs 100 gold.");
//        }
//        else
//        {
//            Console.WriteLine("The machete costs 200 gold.");
//        }
//        break;

//    case 7:
//        if (usersName == myName)
//        {
//            Console.WriteLine($"The food supplies costs 0,5 gold.");
//        }
//        else
//        {
//            Console.WriteLine("The food supplies 1 gold.");
//        }
//        break;

//    default: Console.WriteLine("I do not know that one.");
//        break;
//}

// The four sisters and the duckbear
//int fourSisters = 4;

//int eggsCollected = askForNumberInRange("How many eggs were gathered today? ", 0, 1000);
//Console.WriteLine($"This is how many eggs were collected {eggsCollected} today.");

//int eggsResult = (eggsCollected / fourSisters);
//int duckBearResult = (eggsResult % fourSisters);
//Console.WriteLine($"The four sister gets {eggsResult} egg/eggs each and the duckbear gets {duckBearResult} egg/eggs.");

/*This is called a method, that lives in the main method. 
*Doesn´t need a class name first. Can be called from anywhere, the program knows where this method is in the main method.
And jumps to where the method is called void CountToTeen, runs the instructrion in the foor loop.
In order to run the method it has to be called, can be called multiple times.*/
/*Taking a number challenge*/
//CountToTen();

/*void CountToTen()*/ // Calling the method CountToTen
                      //{ 
                      //    for (int current = 1; current <= 10; current++) // Using a for loop to loop through current ten times 
                      //        Console.WriteLine(current);
                      //}

//int firstNumber = askForNumber("Enter the first number:");
//int secondNumber = askForNumberInRange("Enter the second number: ", 0, firstNumber);

//int askForNumber(string text)
//{
//    Console.Write(text);
//    int chosenNumber = int.Parse(Console.ReadLine());
//    return chosenNumber;
//}

//int askForNumberInRange(string text, int min, int max) 
//{
//    while (true) 
//    {
//        Console.Write(text);
//        int chosenNumber = int.Parse(Console.ReadLine());

//        if (chosenNumber >= min && chosenNumber <= max)
//            return chosenNumber;
//    }    
//}

// Recursive - countdown 
//countDown(10);

//void countDown(int number) {

//    if (number == 0) return;
//        Console.WriteLine(number);
//        countDown(number - 1);  
//}