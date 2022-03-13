using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt eesnime
            //programm küsib kasutajalt numbrit 1-3
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimene täht
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkus, tähtede arv.

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine().ToUpper();
            Console.WriteLine("Siseta number 1, 2, 3 ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)

            //funktsioonid siia vahesse
            {
                case 1:
                    UserNameBackwards(userName);
                    break;
                case 2:
                    UserNameFirstLetter(userName);
                    break;
                case 3:
                    UserNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kaena päeva!");
                    break;
            }
            }

                public static void UserNameBackwards(string userName)
            {
                for (int i = userName.Length - 1; i >= 0; i--)
            {
                Console.Write(userName[i]);
            }
            }

             public static void UserNameFirstLetter(string userName)
            {
            Console.WriteLine($"Sinu eesnimi algab {userName[0]} tähega.");
            }
             public static void UserNameLength(string userName)
            {
            Console.WriteLine($"Sinu eesnimes on {userName.Length} tähte.");
            }


    }
}

