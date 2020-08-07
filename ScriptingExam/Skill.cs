using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    public abstract class Skill
    {
        public string Name { get; protected set; }
        public Affinities Affinity { get; protected set; }
        public float Power { get; protected set; }

        protected Skill(string name, SupSkillType supSkill)
        {
            Name = name;            
        }

       protected Skill(string name, Affinities affinity, float power)
       {
            Name = name;
            this.Affinity = affinity;
            Power = power;
       }

        public abstract void UseSkill(Critter ally, Critter enemy);
    }
}
