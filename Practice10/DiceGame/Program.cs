namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your Name : ");
            var firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}!");
            Console.WriteLine("Game is starting...");

            int player1Random, player2Random;
            int player1point = 0;
             int   player2point = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Press Any Key to Start Game!");
                Console.ReadLine();

                Random random = new Random();
               
                player1Random= random.Next(1, 6);
                Console.WriteLine($"{firstName} your dice number is : {player1Random} ");
               


                player2Random = random.Next(1, 6);
                Console.WriteLine($"AI  dice number is : {player2Random} ");
               


                if (player1Random == player2Random)
                {
                    Console.WriteLine("The game ended in a draw !");
                    Console.WriteLine();

                }
                else if(player1Random >= player2Random)
                {
                    Console.WriteLine($" {firstName}, You Won !");
                    player1point++;
                    Console.WriteLine($"{firstName}, your points are - {player1point}");
                    Console.WriteLine($"Ai points are - {player2point}");



                }
                else if (player1Random <= player2Random)
                {
                    
                    Console.WriteLine(" AI Won !");
                    player2point++;
                    Console.WriteLine($"{firstName}, your points are - {player1point}");
                    Console.WriteLine($"Ai points are - {player2point}");

                }
               
             

            }

        }
    }
}