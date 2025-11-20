namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PhoneBook phoneBook = new PhoneBook(5);
            phoneBook["Alice"] = "123-456-7890";
            phoneBook["Bob"] = "987-654-3210";
            phoneBook["Charlie"] = "555-555-5555";
            Console.WriteLine("Alice's number: " + phoneBook["Alice"]);
            Console.WriteLine("Bob's number: " + phoneBook["Bob"]);
            Console.WriteLine("Eve's number: " + phoneBook["Eve"]);

            Console.WriteLine("All entries using method:");
            foreach (string entry in phoneBook.ShowAllEntries())
            {
                Console.WriteLine(entry);
            }
            
            Console.WriteLine("All entries using indexation:");

            for (int i = 0; i < phoneBook.Count; i++)
            {
                Console.WriteLine(phoneBook[i]);
            }

  
        }
    }
}
