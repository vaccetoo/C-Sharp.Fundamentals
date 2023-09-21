namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            CheckThePassword(password);
        }

        private static void CheckThePassword(string password)
        {
            bool isValid = true;

            isValid = ChekPasswordLength(password, isValid);
            isValid = CheckOnlyForLettersAndDigits(password, isValid);
            isValid = CheckForAtLeast2Digits(password, isValid);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckForAtLeast2Digits(string password, bool isValid)
        {
            int digitCnt = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCnt++;
                }
            }

            if (digitCnt < 2)
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            return isValid;
        }

        private static bool CheckOnlyForLettersAndDigits(string password, bool isValid)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(char.IsLetter(password[i]) || char.IsDigit(password[i])))
                {
                    isValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }

            return isValid;
        }

        private static bool ChekPasswordLength(string password, bool isValid)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            return isValid;
        }
    }
}