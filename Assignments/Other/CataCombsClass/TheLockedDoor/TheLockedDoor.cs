namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.TheLockedDoor
{
    public static class TheLockedDoor
    {
        public static void Run() 
        {
            Console.Write("Please enter a passcode: ");
            int Startingpasscode = int.Parse(Console.ReadLine());
            Console.Clear();

            Door door = new Door(Startingpasscode);

            while (true) 
            {
                Console.WriteLine($"The door is currently {door.currentState}");
                Console.Write("What now? ");
                string answerInput = Console.ReadLine();

                switch (answerInput) 
                {
                    case "open":
                        door.Open(); 
                    break;
                    case "close":
                        door.Close();
                    break;
                    case "lock":
                        door.Lock(); 
                    break;
                    case "unlock":
                        Console.Write("Enter passcode: ");
                        int passcode = int.Parse(Console.ReadLine());
                        door.Unlocked(passcode);
                        break;
                    case "change code":
                        Console.Write("Enter current passcode: ");
                        int current = int.Parse(Console.ReadLine());
                        Console.Write("Enter a new passcode: ");
                        int newPasscode = int.Parse(Console.ReadLine());
                        door.ChangePassword(current, newPasscode);
                        break;
                    default:
                        Console.WriteLine("I don´t know what that means.");
                    break;
                }
            }
        }
    }
}
