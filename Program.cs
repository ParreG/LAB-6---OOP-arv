namespace LAB_6___OOP_arv
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog("Fetch", "Hund", "Max", 8, "Tysk polis hund", 32, 4, "hundmat", "Voff");
            Cat cat = new Cat("Klättra på möbler", "Katt", "Misse", 3, "Siames", 30, 4, "kattmat", "Mjau");
            Horse horse = new Horse("Långritt", "Häst", "Blaze", 12, "Arabian", 40, 4, "hö", "Gnääägg");

            
            Dog labrador = new Labrador(true, "Äta pinnar", "Retriver", "Luna", 5, "Labrador", 34, 4, "pinnar", "vOff Voff"  );
            Dog golden = new Golden("Likes baths", "Playing fetch", "Dog", "Buddy", 5, "Golden Retriever", 42, 4, "Dry dog food", "Woof");

            
            dog.makeSound();
            dog.Information();
            Console.WriteLine();

            cat.makeSound(); 
            cat.Information(); Console.WriteLine();

            horse.makeSound(); 
            horse.Information(); Console.WriteLine();

            labrador.makeSound(); 
            labrador.Information(); Console.WriteLine();

            golden.makeSound(); 
            golden.Information(); Console.WriteLine( );
            
        }
    }
}
