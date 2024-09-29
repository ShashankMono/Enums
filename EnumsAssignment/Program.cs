namespace EnumsAssignment
{
    internal class Program
    {
         //Enum is a special class where we can decalare the constant the values which are not going to change 
         //in future and it will be used at many places in the code. The enum can be declared inside the class as well
         // outside the class, enum class also have different functions like getName,getvlaue,etc. 
         // the constant are seprated by comas inside the enum and they get the default value from 0 to n.
         // Enums increase the readability of the code and we can also change the value according to us ,
         // by using = infront of constant and while accessing use (int)enumName.ConstantName
         // Enums tolorate integer type. Enums can also be used in switch cases.
        enum Months
        {
            January,
            february,
            march,
            april,
            may,
            june,
            july,
            august,
            september,
            october,
            november,
            december
        }
        static void Main(string[] args)
        {
            displayMenu();
        }

        public static void displayMenu()
        {
            bool[] run = {true};
            while (run[0])
            {
                Console.WriteLine("\n0.Exit\n" +
                       "1.Get Month\n");
                int choice = int.Parse(Console.ReadLine());
                executeCases(choice,run);
            }
            
        }

        public static void executeCases(int choice, bool[] run)
        {
            switch (choice)
            {
                case 0:
                    run[0] = false;
                    break;
                case 1:
                    Console.WriteLine("Enter which month you want in 1-12");
                    int value = int.Parse(Console.ReadLine());
                    string result = (value <= 12) ?
                        $"The {value} Month is {Enum.GetName(typeof(Months), value - 1)}"
                    : "Please enter value between 1 to 12";
                    Console.WriteLine(result);
                    break;
            }
        }
    }
}
