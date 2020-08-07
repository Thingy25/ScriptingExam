using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class Battleground
    {

        bool isPlayerTurn;
        Player[] currentPlayers = new Player[2];
        Critter[] currentCritters = new Critter[2];

        public Battleground(Player player, Player enemy)
        {
            currentPlayers[0] = player;
            currentPlayers[1] = enemy;
            currentCritters[0] = player.critters[0];
            currentCritters[1] = enemy.critters[0];            
            isPlayerTurn = currentCritters[0].BaseSpeed >= currentCritters[1].BaseSpeed;
            InitiateTurn();
        }

        //public void ChooseCritter()
        //{
        //    string temp;
        //    int i;

        //    Console.WriteLine("Choose the critter you wish to use in battle: (1), (2), (3).");
        //    temp = Console.ReadLine();
        //    if(int.TryParse(temp, out i))
        //    {
        //        playerCrit = critters[i];
        //    }
        //}

        //public void ChooseCritter(int rand)
        //{
        //    enemyCrit = enemy.critters[rand];
        //}

        public void InitiateTurn()
        {
            string temp;
            int turn = (isPlayerTurn)? 0:1, skillIndex = 0, noTurn = (!isPlayerTurn) ? 1 : 0;
            if (isPlayerTurn)
            {
                Console.WriteLine("Choose your ability: (0), (1), (2)");
                temp = Console.ReadLine();
                int.TryParse(temp, out skillIndex);

            }
            else
            {
                Random rand = new Random();
                skillIndex = rand.Next(0, currentCritters[turn].moveSet.Count);
                Console.WriteLine("The enemy has used: " + currentCritters[turn].moveSet[skillIndex].Name);
            }
            currentCritters[turn].moveSet[skillIndex].UseSkill(currentCritters[turn], currentCritters[noTurn]);
            ChangeTurn();
        }

        public void ChangeTurn()
        {
            isPlayerTurn = !isPlayerTurn;
            InitiateTurn();
        }
    }
}
