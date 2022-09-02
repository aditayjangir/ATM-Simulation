namespace ATM_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalAmount = 50000;
            string currentPin = "1234";
            int flag = 0;
            while (flag == 0)
            {
                Console.WriteLine("Choose the corrosponding number to the option from the following");
                Console.WriteLine("1. Withdrawal");
                Console.WriteLine("2. Pin Change");
                Console.WriteLine("3. Balance Check");
                Console.WriteLine("4. Deposit");
                Console.WriteLine("5. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Withdrawal(ref totalAmount, currentPin);
                        break;
                    case 2:
                        PinChange(ref currentPin);
                        break;
                    case 3:
                        CheckBalance(totalAmount, currentPin);
                        break;

                    case 4:
                        Deposit(ref totalAmount, currentPin);
                        break;

                    case 5:
                        flag = 1;
                        break;

                    default:
                        Console.WriteLine("You have choosen the wrong option");
                        break;
                }
            }
        }

        public static void Withdrawal(ref int totalAmount, string currentPin)
        {
            Console.WriteLine("Enter your pin");
            string pin = Console.ReadLine();
            if (pin == currentPin)
            {
                Console.WriteLine("Enter amount to be withdraw");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > 0 && amount <= totalAmount)
                {
                    Console.WriteLine("Amount withdraw: {0}", amount);
                    totalAmount = totalAmount - amount;
                    Console.WriteLine("Amount remain: {0}", totalAmount);
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("You have entered the wrong pin");
            }
        }

        public static void PinChange(ref string currentPin)
        {
            Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();
            string newPin = "";
            if (pin == currentPin)
            {
                Console.WriteLine("Enter 4 digit new pin");
                newPin = Console.ReadLine();
                if (newPin.Length == 4)
                {
                    currentPin = newPin;
                    Console.WriteLine("Pin changed");
                }
                else
                {
                    Console.WriteLine("Entered pin is not 4 digit ");
                }
            }
            else
            {
                Console.WriteLine("Entered pin is incorrect");
            }
        }
        public static void CheckBalance(int totalAmount, string currentPin)
        {
            Console.WriteLine("Enter pin");
            string pin = Console.ReadLine();
            if (pin == currentPin)
            {
                Console.WriteLine("Account balance: {0}", totalAmount);
            }
            else
            {
                Console.WriteLine("You have entered the wrong pin");
            }
        }
        public static void Deposit(ref int totalAmount, string currentPin)
        {
            Console.WriteLine("Enter your pin");
            string pin = Console.ReadLine();
            if (pin == currentPin)
            {
                Console.WriteLine("Enter amount to be deposited:");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount > 0 && amount <= 20000)
                {
                    Console.WriteLine("Amount deposited: {0}", amount);
                    totalAmount = totalAmount + amount;
                    Console.WriteLine("Amount balance: {0}", totalAmount);

                }
                else
                {
                    Console.WriteLine("Entered amount is incorrect");

                }
            }
            else
            {
                Console.WriteLine("You have entered the wrong pin");
            }
        }
    }
}