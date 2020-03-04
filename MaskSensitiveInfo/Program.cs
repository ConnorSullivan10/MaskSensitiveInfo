using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a value that you'd like to hide from anyone who doesn't know the secret answer");
            var userEntry = Console.ReadLine().ToLower();
            // var hiddenEntry = new string('*', userEntry.Length - 4) + userEntry.Substring(userEntry.Length - 4);
            var hiddenEntry = userEntry.Substring(userEntry.Length - 4).PadLeft(userEntry.Length, '*');
            Console.WriteLine(hiddenEntry);
            Console.WriteLine("To uncover the hidden information above, you'll have to tell me how many movies that Quentin Tarantino has stated that he'll make over his career");
            var riddleAnswer = Console.ReadLine().ToLower();
            if (riddleAnswer == "ten" || riddleAnswer == "10")
            {
                Console.WriteLine($"You got it! The unencrypted info is: {userEntry}");
            }
            else
            {
                Console.WriteLine("Sorry! Better luck next time.");
            }
        }
    }
}
