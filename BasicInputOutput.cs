using System;
namespace ConsoleApp {
    public class HelloWorld {
        public static void Main(string[] args) {
            string name, age, fName, mName, presentAddress, permanentAddress, bDate, cStat, citizenship, bPlace, address, languages, eContact, religion, weight, height;
            int padAmount = 40;
            
            Console.Write ("Enter your name: ");
            name = Console.ReadLine();
            Console.Write ("Enter your age: ");
            age =  Console.ReadLine();
            Console.Write ("Enter your father's name: ");
            fName =  Console.ReadLine();
            Console.Write ("Enter your mother's name: ");
            mName = Console.ReadLine();
            Console.Write ("Enter your present address: ");
            presentAddress =  Console.ReadLine();
            Console.Write ("Enter your permanent address: ");
            permanentAddress =  Console.ReadLine();
            Console.Write ("Enter your birthdate: ");
            bDate =  Console.ReadLine();
            Console.Write ("Enter your civil status: ");
            cStat =  Console.ReadLine();
            Console.Write ("Enter your citizenship: ");
            citizenship =  Console.ReadLine();
            Console.Write ("Enter your birth place: ");
            bPlace =  Console.ReadLine();
            Console.Write ("Enter your address: ");
            address =  Console.ReadLine();
            Console.Write ("Enter the languages you can speak: ");
            languages =  Console.ReadLine();
            Console.Write ("Enter who we should contact in case of an emergency: ");
            eContact =  Console.ReadLine();
            Console.Write ("Enter your religion: ");
            religion =  Console.ReadLine();
            Console.Write ("Enter your weight: ");
            weight =  Console.ReadLine();
            Console.Write ("Enter your height: ");
            height =  Console.ReadLine();
            
            Console.WriteLine("\n\n\n\n----------");
            
            Console.WriteLine($"Name : {name}".PadRight(padAmount, ' '));
            Console.WriteLine($"Birthdate : {bDate}".PadRight(padAmount, ' ') + $"Religion : {religion}");
            Console.WriteLine($"Birthplace : {bPlace}".PadRight(padAmount, ' ') + $"Age : {age}");
            Console.WriteLine($"Father : {fName}".PadRight(padAmount, ' ') + $"Height: {height}");
            Console.WriteLine($"Mother : {mName}".PadRight(padAmount, ' ') + $"Weight: {weight}");
            Console.WriteLine($"Civil Status : {cStat}".PadRight(padAmount, ' '));
            Console.WriteLine($"Citizenship : {citizenship}".PadRight(padAmount, ' '));
            Console.WriteLine($"Spoken Languages : {languages}".PadRight(padAmount, ' '));
            Console.WriteLine($"Present Address : {presentAddress}".PadRight(padAmount, ' '));
            Console.WriteLine($"Permanent Address : {permanentAddress}".PadRight(padAmount, ' '));
            Console.WriteLine($"Person to be notified in case of emergency : {eContact}".PadRight(padAmount, ' '));
            
        }
    }
}
