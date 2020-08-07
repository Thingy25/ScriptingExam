using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class Battleground
    {
        Player player;
        Player enemy;
        Critter playerCrit;
        Critter enemyCrit;

        public Battleground(Player player, Player enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public void ChooseCritter()
        {
            string temp;
            int i;

            Console.WriteLine("Choose the critter you wish to use in battle: (1), (2), (3).");
            temp = Console.ReadLine();
            if(int.TryParse(temp, out i))
            {
                playerCrit = player.critters[i];
            }
        }

        public void ChooseCritter(int rand)
        {
            enemyCrit = enemy.critters[rand];
        }

        public void InitiateBattle()
        {
            playerCrit.DoDamage(Utilities.Compare(playerCrit.affin, enemyCrit.affin));
        }

        public void ChangeTurn()
        {

        }
    }
}
