using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    public enum SkillType { attackSkill, supportSkill}

    class Skill
    {
        public string Name { get; protected set; }
        public Affinities affinity;
        public SkillType skType;
        public float Power { get; protected set; }
    }
}
