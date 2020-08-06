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

        public void InitialCritterCreation()
        {
            critters.Add(new Critter("Critachu1"));
            critters.Add(new Critter("Critachu2"));
            critters.Add(new Critter("Critachu3"));
        }
    }
}
