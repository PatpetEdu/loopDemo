namespace loopDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int myNumber = 0;

            ////while (myNumber <= 5)
            ////{
            ////    Console.WriteLine(myNumber);
            ////    myNumber++;
            //}



            //int number = 1;

            //do
            //{

            //    Console.WriteLine("My number is: " + number);
            //    number++;

            //} while (number <= 5);




            //string myPassword = "12345";
            //string userInput = "";
            //do
            //{
            //    Console.WriteLine("Skriv lösenord");
            //    userInput = Console.ReadLine();

            //} while (userInput != myPassword);






            //string myPassword = "12345";
            //int maxForsok = 3;
            //int forsok = 0;
            //string userInput = "";

            //do
            //{
            //    Console.WriteLine("Skriv lösenord");
            //    userInput = Console.ReadLine();
            //    forsok++;

            //    if (userInput != myPassword)
            //    {
            //        Console.WriteLine("Fel lösenord. Försök igen.");
            //        if (forsok >= maxForsok)
            //        {
            //            Console.WriteLine("Du har använt upp dina försök. Programmet avslutas.");
            //            break;
            //        }
            //    }

            //} while (userInput != myPassword);

            //if (userInput == myPassword)
            //{
            //    Console.WriteLine("Rätt lösenord! Du är inloggad.");
            //}

            
            //Skapar en arrway med 3 värden.
            string[] users = { "Aldor", "Reidar", "Anders" };

            for (int i = 0; i < users.Length; i++)
            {

                Console.WriteLine(users[i]);
            }

            foreach (string user in users)

            {
                Console.WriteLine(user);

            }



        }
    }
}