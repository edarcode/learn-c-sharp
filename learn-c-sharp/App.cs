internal class App
{
    private static void Main(string[] args)
    {
        /*
            contruir una app de cosola que genere un numero random de 0 a 100 y pida al usuario tratar de adivinarlo,
            si no acierta, debe darle una pista de si es mayor o menor a lo que digitó.
            En caso contrario felicita e indica cuantos intentos gastó.
         */
        Random random = new Random();
        int numRandom = random.Next(0, 100);
        int numberAttemps = 0;

        const string TRY_TO_GUESS = "Trate de adivinar el número generado entre 0 a 100";
        const string TRY_TO_GUESS_AGAIN = "Trate de adivinar nuevamente";
        const string EPIC_FAIL = "Epic Fail *****************";
        const string IS_ELDER = "El número random es mayor que:";
        const string IS_MINOR = "El número random es menor que:";
        const string WIN = "Felicidades adivinaste el random: ";
        const string ERR = "Entrada no valida, digita un número porfavor";
        
        Console.WriteLine(TRY_TO_GUESS);
        int numberUser=0;
        try {
            numberUser = int.Parse(Console.ReadLine());
        }
        catch(Exception){
            Console.WriteLine(ERR);
        }
        while (numRandom != numberUser)
        {
            numberAttemps++;
            Console.WriteLine(EPIC_FAIL);
            if (numRandom > numberUser) Console.WriteLine($"{IS_ELDER} {numberUser}");
            else Console.WriteLine($"{IS_MINOR} {numberUser}");

            Console.WriteLine(TRY_TO_GUESS_AGAIN);
            try
            {
                numberUser = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine(ERR);
            }
        }
        Console.WriteLine($"{WIN} {numRandom} en {numberAttemps} intentos");
    }

}