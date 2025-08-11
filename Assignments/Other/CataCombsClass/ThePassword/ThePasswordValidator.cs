using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.ThePassword
{
    public static class ThePasswordValidator
    {
        public static void Run()
        {
            Console.WriteLine("Create a password");
            Console.WriteLine("Password must be between 6 and 13 letters long, and contain one uppercase letter, one lowercase letter and one number.");

            string password;

            while (true)
            {
                Console.Write("Password: ");
                password = Console.ReadLine();

                if (IsValid(password))
                {
                    Console.WriteLine("Password is valid.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password. Please try again.");
                }
            }
        }
        private static bool IsValid(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;
            if (password.Length < 6 || password.Length > 13) return false;

            bool hasUpperCase = false, hasLowerCase = false, hasDigit = false;
            foreach (char c in password)
            {
                if (c == 'T' || c == 't' || c == '&') return false;
                if (char.IsUpper(c)) hasUpperCase = true;
                else if (char.IsLower(c)) hasLowerCase = true;
                else if (char.IsDigit(c)) hasDigit = true;
            }
            return hasUpperCase && hasLowerCase && hasDigit;

        }
    }
}
