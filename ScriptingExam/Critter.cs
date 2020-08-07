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
        Random rnd = new Random();

        public string Name { get; protected set; }
        public float BaseAttack { get; }
        public float BaseDefense { get; }
        public float BaseSpeed { get; }
        public Affinities affin;
        public List<Skill> moveSet = new List<Skill>();
        public int HP { get; }

        public int attackCounter = 0;
        public int defenseCounter = 0;
        public int speedCounter = 0;

        public Critter()
        {
        }

        public Critter(string name, float baseAttack, float baseDefense, float baseSpeed)
        {
            Name = name;
            if (baseAttack >= 10 && baseAttack <= 100) BaseAttack = baseAttack;
            else BaseAttack = 10;
            if (baseDefense >= 10 && baseDefense <= 100) BaseDefense = baseDefense;
            else BaseDefense = 10;
            if (baseSpeed >= 1 && baseSpeed <= 50) BaseSpeed = baseSpeed;
            else BaseSpeed = 1;
            HP = 100;
        }

        public void AddSupportSkill(string name, Affinities affinity, SupSkillType type)
        {
            moveSet.Add(new SupportSkill(name, affinity, type));
        }

        public void AddAttackSkill(string name, Affinities affinity, float power)
        {
            moveSet.Add(new AttackSkill(name, affinity, power));
        }

        public void DoDamage(float affinityMultiplier)
        {
            float damageValue;
            string temp;
            int i;

            Console.WriteLine("Enter the number for the type of skill you would like to use:");
            Console.WriteLine("Attack Skill (0), Attack Up (1), Defense Up (2), Speed Down (3)");
            temp = Console.ReadLine();
            if(int.TryParse(temp, out i))
            {
                moveSet[i].UseSkill();
                damageValue = (BaseAttack + moveSet[i].Power) * affinityMultiplier;
            }
        }

        public void DieSwap()
        {

        }
    }
}
