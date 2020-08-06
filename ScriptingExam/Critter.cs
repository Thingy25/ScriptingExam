using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    public enum Affinities { fire, wind, water, earth, dark, light }

    class Critter
    {
        Random rnd = new Random();

        public string Name { get; protected set; }
        public float BaseAttack { get; }
        public float BaseDefense { get; }
        public float BaseSpeed { get; }
        public Affinities affin;
        public List<Skill> moveSet = new List<Skill>();
        public int HP { get; }

        public Critter(string name)
        {
            Name = name;
            BaseAttack = rnd.Next(10, 101);
            BaseDefense = rnd.Next(10, 101);
            BaseSpeed = rnd.Next(1, 51);
            HP = 100;
        }
    }
}
