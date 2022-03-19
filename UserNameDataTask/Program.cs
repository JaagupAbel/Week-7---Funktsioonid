using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime;
            //programm küsib kasutajalt numbrit 1-3;
            //Kui kasutaja sisestab '1', siis kuvatakse kasutaja tagurpidi;
            //Kui kasutaja sisestab '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja sisestab '3', siis kuvatakse kasutaja täisnime pikkust;


            Console.WriteLine("Sisesta enda eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Vali numbrid 1 kuni 3 vahemikus.");
            char userNumber = Convert.ToChar(Console.ReadLine());

            switch (userNumber)
            {
                case '1':
                    AddOne(userName);
                    break;

                case '2':
                    AddTwo(userName);
                    break;

                case '3':
                    AddThree(userName);
                    break;

                default:
                    Console.WriteLine("Vale number, head päeva!");
                    break;
            }


        }

        //teie funktsioonid siin. 

        public static void AddOne(string userInput)
        {

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void AddTwo(string userInput)
        {
                Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void AddThree(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
