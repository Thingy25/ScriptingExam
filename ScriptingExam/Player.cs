using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class Player
    {
        public List<Critter> critters = new List<Critter>();

        //public void AddCritter(string name, float baseAttack, float baseDefense, float baseSpeed)
        //{
        //    critters.Add(new Critter(name, baseAttack, baseDefense, baseSpeed));
        //}

        public void AddCritter(Critter crit)
        {
            critters.Add(crit);
        }

        public void AddCritter()
        {
            Random rand = new Random();

            critters.Add(new Critter("Critachu", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51)));
        }
    }
}
