using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class Player
    {
        private List<Critter> critters = new List<Critter>();
        public List<Critter> Critters { get => critters; }

        public void AddCritter(Critter crit)
        {
            if (Critters.Count < 3)
            {
                critters.Add(crit);
            }
            else
            {
                Console.WriteLine("Critter limit exceeded");
            }
        }

        public void RemoveBattlegroundCritter()
        {
            critters.RemoveAt(0);
        }

        public void AddCritter(Critter crit, int i) //Se hace sobrecarga para agregar critters muertos ilimitados.
        {           
             critters.Add(crit);            
        }
    }
}
