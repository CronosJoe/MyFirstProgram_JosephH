using System;

namespace OOPExercise_JosephHuskey
{
    class Program
    {
        static void Main(string[] args)
        {
            //needed random number generator
            Random rand = new Random();
            // introduction text
            Console.WriteLine("Welcome to the Zombie Arena");
            #region character maker
            //character creation
            Player player = new Player();
            Console.WriteLine("What is your name fighter?");
            string input = Console.ReadLine();
            player.name = input;
            player.maxHealthPoints = rand.Next(player.healthModMin, player.healthModMax);
            player.healthPoints = player.maxHealthPoints;
            player.power = rand.Next(1, player.pwrMax);
            
            //First enemy creation(After this enemies will be randomly selected)
            BasicZombie tim = new BasicZombie();
            tim.Name = tim.names[rand.Next(0,3)];
            tim.healthPoints = 50;
            tim.power = rand.Next(1, 4);
            #endregion

            Battle(player, tim);
            while(player.isAlive)
            {
                #region enemy randomizer
                int enemy = rand.Next(1, 2);
                switch(enemy)
                {
                    case 1:
                        BasicZombie jim = new BasicZombie();
                        jim.Name = jim.names[rand.Next(0, 10)];
                        jim.healthPoints = rand.Next(player.score*10,player.score*15);
                        jim.power = rand.Next(1, player.score*2);
                        Console.WriteLine("A new enemy appears!");
                        Battle(player, jim);
                        break;
                    case 2:
                        ArmoredZombie charles = new ArmoredZombie();
                        charles.Name = charles.names[rand.Next(0, 10)];
                        charles.healthPoints = rand.Next(player.score * 10, player.score * 15);
                        charles.power = rand.Next(1, player.score);
                        Console.WriteLine("A new enemy appears!");
                        Battle(player, charles);
                        break;  
                }
                #endregion
                if (player.isAlive)
                {
                    player.power += 2;
                    player.maxHealthPoints += 40;
                }
            }

            // good-bye text
            Console.WriteLine($"Thanks for playing! Your score was {player.score}. Press ENTER to exit.");
            Console.ReadLine();

            return;
        }//end of main
        #region battle
        static void Battle(Player player, BasicZombie tim)
        {
            // controls whether battle should continue
            bool isBattleOver = false;
            
            // battle loop
            while (!isBattleOver)
            {

                isBattleOver = TakeInput(player, tim);
                if(player.healthPoints == 0)
                {
                    player.isAlive = false;
                }
                if (!isBattleOver)
                { 
                 //zombie attack
                    Console.WriteLine($"{tim.Name} attacks!");
                    player.TakeDamage(tim.Attack(tim.power));
                    Console.WriteLine($"Your current health is {player.healthPoints}, {tim.Name}'s health is {tim.healthPoints} ");
                    if (player.IsDefeated)
                    {
                        player.isAlive = false;
                        isBattleOver = true;
                    }
                }
            }

        }//end of basic zombie battle
        static void Battle(Player player, ArmoredZombie tim)
        {
            // controls whether battle should continue
            bool isBattleOver = false;
            
            // battle loop
            while (!isBattleOver)
            {

                isBattleOver = TakeInput(player, tim);
                if (player.healthPoints == 0)
                {
                    player.isAlive = false;
                }
                if (!isBattleOver)
                {
                    //zombie attack
                    Console.WriteLine($"{tim.Name} attacks!");
                    player.TakeDamage(tim.Attack(tim.power));
                    Console.WriteLine($"Your current health is {player.healthPoints}, {tim.Name}'s health is {tim.healthPoints}");
                    if (player.IsDefeated)
                    {
                        player.isAlive = false;
                        isBattleOver = true;
                    }
                }
            }
        }//end of armored zombie battle
        #endregion
        #region input
        static bool TakeInput(Player player, BasicZombie tim)
        {
            // prompt the player for input
            Console.WriteLine("What would you like to do?");
            string playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower();
            if (playerInput == "quit" || playerInput == "Q")
            {
                player.healthPoints = 0;
                return true;
            }
            else if (playerInput == "help")
            {
                Console.WriteLine("This is a text based battle sim where you enter commands to fight. All commands are single word commands that will do something for your turn.");
                Console.WriteLine("If at any point you would like to quit the game use the command Quit, if you want a list of commands use the command Command");
                return TakeInput(player, tim);
            }
            else if (playerInput == "command" || playerInput == "commands")
            {
                player.printCommands();
                return TakeInput(player, tim);
            }
            else if (playerInput == "attack") //controls the players attack
            {
                Console.WriteLine($"{player.name} attacked the {tim.Name}!");
                tim.TakeDamage(player.Attack(player.power));
                if (tim.IsDefeated)
                {
                    player.score++;
                    return true;
                }
                return false;
            }
            else if (playerInput == "status")
            {
                Console.WriteLine($"Your health is {player.healthPoints} your power is {player.power}");
                return TakeInput(player, tim);
            }
            else if (playerInput == "heal")
            {
                int heal = player.power * 5;
                player.healthPoints += heal;
                if (player.healthPoints > player.maxHealthPoints)
                {
                    player.healthPoints = player.maxHealthPoints;
                }
                Console.WriteLine($"You have healed {heal} points of health your current health is {player.healthPoints}");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid command try again");
                return TakeInput(player, tim);
            }
            
        }// end of takeInput BasicZombie
        static bool TakeInput(Player player, ArmoredZombie tim)
        {
            // prompt the player for input
            Console.WriteLine("What would you like to do?");
            string playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower();
            if (playerInput == "quit" || playerInput == "Q")
            {
                player.healthPoints = 0;
                return true;
            }
            else if (playerInput == "help")
            {
                Console.WriteLine("This is a text based battle sim where you enter commands to fight. All commands are single word commands that will do something for your turn.");
                Console.WriteLine("If at any point you would like to quit the game use the command Quit, if you want a list of commands use the command Command");
                return TakeInput(player, tim);
            }
            else if (playerInput == "command" || playerInput == "commands")
            {
                player.printCommands();
                return TakeInput(player, tim);
            }
            else if (playerInput == "attack") //controls the players attack
            {
                Console.WriteLine($"{player.name} attacked the {tim.Name}!");
                tim.TakeDamage(player.Attack(player.power));
                if (tim.IsDefeated)
                {
                    player.score++;
                    return true;
                }
                return false;
            }
            else if (playerInput == "status")
            {
                Console.WriteLine($"Your health is {player.healthPoints} your power is {player.power}");
                return TakeInput(player, tim);
            }else if (playerInput == "heal")
            {
                int heal = player.power * 5;
                player.healthPoints += heal;
                if (player.healthPoints>player.maxHealthPoints)
                {
                    player.healthPoints = player.maxHealthPoints;
                }
                Console.WriteLine($"You have healed {heal} points of health your current health is {player.healthPoints}");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid command try again");
                return TakeInput(player, tim);
            }

        }
        #endregion
        
    }
}
