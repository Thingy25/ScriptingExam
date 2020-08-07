using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    //public enum SkillType { attackSkill, supportSkill}

    public abstract class Skill
    {
        public string Name { get; protected set; }
        public Affinities affinity;
        //public SkillType skType;
        public float Power { get; protected set; }

        public Skill()
        {

        }

        protected Skill(string name, Affinities affinity, float power)
        {
            Name = name;
            this.affinity = affinity;
            Power = power;
        }

        public virtual void UseSkill(Critter ally, Critter enemy)
        {

        }
    }
}
