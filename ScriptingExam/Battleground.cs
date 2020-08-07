using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class Battleground
    {
        private bool isPlayerTurn;
        private Player[] currentPlayers = new Player[2];
        private Critter[] currentCritters = new Critter[2];
        private int Turn { get => (isPlayerTurn) ? 0 : 1; }
        private int NoTurn { get => (isPlayerTurn) ? 1 : 0; }

        public Battleground(Player player, Player enemy)
        {
            Critter.InCritterDeath += SwapCritter;

            currentPlayers[0] = player;
            currentPlayers[1] = enemy;
            currentCritters[0] = player.Critters[0];
            currentCritters[1] = enemy.Critters[0];            
            isPlayerTurn = currentCritters[0].BaseSpeed >= currentCritters[1].BaseSpeed;

            InitiateTurn();
        }

        private void InitiateTurn()
        {
            string temp;
            int skillIndex = 0;
            if (isPlayerTurn)
            {
                Console.WriteLine("\nYour turn!");
                Console.WriteLine("Choose your ability: (0), (1), (2)");
                temp = Console.ReadLine();
                int.TryParse(temp, out skillIndex);

            }
            else
            {
                Console.WriteLine("\nThe enemy's turn!");
                Random rand = new Random();
                skillIndex = rand.Next(0, currentCritters[Turn].MoveSet.Count);
                Console.WriteLine("The enemy has used: {0}", currentCritters[Turn].MoveSet[skillIndex].Name);
            }
            currentCritters[Turn].MoveSet[skillIndex].UseSkill(currentCritters[Turn], currentCritters[NoTurn]);
            ChangeTurn();
            
        }

        private void ChangeTurn()
        {
            if (currentPlayers[NoTurn].Critters.Count > 0 )
            {
                if (currentPlayers[NoTurn].Critters[0].HP > 0)
                {
                    isPlayerTurn = !isPlayerTurn;
                    InitiateTurn();

                }
                else
                {
                    Console.WriteLine("\n\nOne player does not have any critters alive, the battle has ended.");
                    Console.WriteLine("Thanks for playing, press any key to exit.");
                }
            }
            else 
            {
                Console.WriteLine("\n\nOne player does not have any critters alive, the battle has ended.");
                Console.WriteLine("Thanks for playing, press any key to exit.");
            }
        }

        private void SwapCritter(Critter deadCrit)
        {
            Console.WriteLine(deadCrit.Name + " is dead, it has a new slaver.");
            currentPlayers[NoTurn].RemoveBattlegroundCritter();
            currentPlayers[Turn].AddCritter(deadCrit, 0);

            if (currentPlayers[NoTurn].Critters.Count > 0)
            {
                if (currentPlayers[NoTurn].Critters[0].HP > 0)
                {
                    currentCritters[NoTurn] = currentPlayers[NoTurn].Critters[0];
                    Console.WriteLine("\n-----------------" + currentCritters[NoTurn].Name + " has entered the battle-----------------");
                }
            }
        }
    }
}
