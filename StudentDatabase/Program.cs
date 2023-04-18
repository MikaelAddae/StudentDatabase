namespace StudentDatabase
{
    public class Program
    {
        public static void Main()
        {
            string[] names = { "Tommy", "Josh", "Tim", "Mikael" };
            string[] hometown = { "Raleigh, NC", "Westland, MI", "Jackson, MI", "Providence, RI" };
            string[] favFoods = { "Buttered Chicken", "Nalesniki", "Æbleskivers", "Breakfast Sandwiches" };
            
            Console.WriteLine("Please select a student by choosing a number 1-4");
            string choice = SelectGuest(names);
            int choice2 = int.Parse(choice);
            


            

        }

        public static void PrintArray(object[] objects)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine($"{i + 1}, Names: {objects[i]}");
            }
        }

        public static string SelectGuest(string[] guests)
        {
            PrintArray(guests);
            Console.WriteLine("Please select a student by index number:");
            string input = Console.ReadLine();
            int pick = int.Parse(input) - 1;
            return guests[pick];
        }

        public static int Choice (int num, int[] nums)
        {
            int index1 = num;

            if (index1 >= nums.Length + 1 || index1 < 1)
            {
                Console.WriteLine("One of the indexes is out of range: 1 to " + (nums.Length + 1));
                Console.WriteLine("Lets try again");
                return Choice(num, nums);
            }
            else
            {
                int choice = num;
                return choice;
            }
        }

    }
}