using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    public enum Affinities { fire, wind, water, earth, dark, light }

    public class Critter
    {
        public static Action<Critter> InCritterDeath;

        public string Name { get; protected set; }
        public float BaseAttack { get; protected set; }
        public float BaseDefense { get; protected set; }
        public float BaseSpeed { get; protected set; }
        public Affinities Affin { get; protected set; }
        public float HP { get; protected set; }

        private List<Skill> moveSet = new List<Skill>();
        public List<Skill> MoveSet { get => moveSet; }

        public int attackCounter = 0;
        public int defenseCounter = 0;
        public int speedCounter = 0;

        public float realAttack;
        public float realDefense;
        public float realSpeed;

        public Critter(string name, float baseAttack, float baseDefense, float baseSpeed, Affinities affin)
        {
            this.Affin = affin;
            Name = name;
            if (baseAttack >= 10 && baseAttack <= 100) BaseAttack = baseAttack;
            else BaseAttack = 10;
            if (baseDefense >= 10 && baseDefense <= 100) BaseDefense = baseDefense;
            else BaseDefense = 10;
            if (baseSpeed >= 1 && baseSpeed <= 50) BaseSpeed = baseSpeed;
            else BaseSpeed = 1;
            HP = 100;
        }

        public void AddSupportSkill(string name, SupSkillType type)
        {
            if (MoveSet.Count < 3)
            {
                moveSet.Add(new SupportSkill(name, type));
            }
            else
            {
                Console.WriteLine("Skill limit exceeded");
            }
        }

        public void AddAttackSkill(string name, Affinities affinity, float power)
        {
            if (MoveSet.Count < 3)
            {
                moveSet.Add(new AttackSkill(name, affinity, power));
            }
            else
            {
                Console.WriteLine("Skill limit exceeded");
            }
        }

        public void ReceiveDamage(float dmgValue)
        {
            HP -= dmgValue;
            if (HP <= 0)
            {
                Die();
            }
        }

        private void Die()
        {
            HP = 0;
            Console.WriteLine(Name + " has died!");
            InCritterDeath(this);
        }
    }
}
