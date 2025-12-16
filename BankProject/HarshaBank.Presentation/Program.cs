class Program
{
    // Application execution starts here
    static void Main()
    {
        Console.WriteLine("************Harsha Bank************");
        Console.WriteLine("::Login Page::");

        // declare variables to store username and password
        string userName = null, password = null;

        // read username from keyboard
        Console.Write("Username: ");
        userName = Console.ReadLine();

        if (userName != "")
        {
            // read password from keyboard
            Console.Write("Password: ");
            password = Console.ReadLine();
        }

        //check username and password
        if (userName == "system" && password == "manager")
        {
            // declare variable to store menu choice
            int mainMenuChoice = -1;

            do
            {
                // show main menu
                Console.WriteLine("\n:::Main Menu:::");
                Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Funds Transfer");
                Console.WriteLine("4. Funds Transfer Statement");
                Console.WriteLine("5. Account Statement");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Enter choice: ");
                mainMenuChoice = int.Parse(Console.ReadLine());

                //switch-case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3:
                        // TODO: Display funds transfer menu
                        break;
                    case 4:
                        // TODO: Display funds transfer statement menu
                        break;
                    case 5:
                        // TODO: Display accounts statement menu
                        break;
                    default:
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            Console.WriteLine("Invalid username or password");
        }

        //about to exit
        Console.WriteLine("Thank you! Visit again.");
    }

    static void CustomersMenu()
    {
        // variable to store customers menu choice
        int customerMenuChoice = -1;

        do
        {
            //print customers menu
            Console.WriteLine("\n:::Customers menu:::");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Delete Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("0. Back to Main Menu");

            Console.Write("Enter choice: ");
            customerMenuChoice = Convert.ToInt32(Console.ReadLine());
        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        // variable to store accounts menu choice
        int accountsMenuChoice = -1;

        do
        {
            //print accounts menu
            Console.WriteLine("\n:::Accounts menu:::");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Update Account");
            Console.WriteLine("4. View Accounts");
            Console.WriteLine("0. Back to Main Menu");

            // accept accounts menu choice
            Console.Write("Enter choice: ");
            accountsMenuChoice = Convert.ToInt32(Console.ReadLine());
        } while (accountsMenuChoice != 0);
    }
}