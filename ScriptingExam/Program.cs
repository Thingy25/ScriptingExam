using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equipo:
            //Mariana Serna ID 000362399
            //Juan Fernando Ramírez ID 000086303

            Player player = new Player();
            Player enemy = new Player();
            Critter allyCrit;
            Critter enemyCrit;

            Random rand = new Random();

            Console.WriteLine("Welcome to Crittermon!!");

            allyCrit = new Critter("Critachu", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51), Affinities.light);
            allyCrit.AddSupportSkill("Critlightning", SupSkillType.atkUp);
            allyCrit.AddAttackSkill("Critfire", Affinities.fire, 5);
            allyCrit.AddAttackSkill("Critstorm", Affinities.light, 10);
            player.AddCritter(allyCrit);

            allyCrit = new Critter("Critterpie", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51), Affinities.earth);
            allyCrit.AddSupportSkill("Critwall", SupSkillType.defUp);
            allyCrit.AddAttackSkill("Critrocks", Affinities.earth, 2);
            allyCrit.AddSupportSkill("Critsilk", SupSkillType.spdDown);
            player.AddCritter(allyCrit);

            allyCrit = new Critter("Critmander", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51), Affinities.fire);
            allyCrit.AddAttackSkill("Critcatoa", Affinities.fire, 6);
            allyCrit.AddAttackSkill("Critflames", Affinities.dark, 8);
            allyCrit.AddAttackSkill("Crittail", Affinities.wind, 3);
            player.AddCritter(allyCrit);


            enemyCrit = new Critter("Crittersaur", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51), Affinities.earth);
            enemyCrit.AddSupportSkill("Critwaves", SupSkillType.spdDown);
            enemyCrit.AddAttackSkill("Critlaserbeam", Affinities.light, 10);
            enemyCrit.AddAttackSkill("Critbite", Affinities.dark, 3);
            enemy.AddCritter(enemyCrit);

            enemyCrit = new Critter("Critkoffing", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51), Affinities.wind);
            enemyCrit.AddSupportSkill("Critblizzard", SupSkillType.atkUp);
            enemyCrit.AddAttackSkill("Critpoison", Affinities.wind, 6);
            enemyCrit.AddAttackSkill("Critspell", Affinities.fire, 6);
            enemy.AddCritter(enemyCrit);

            enemyCrit = new Critter("Critkarp", rand.Next(10, 101), rand.Next(10, 101), rand.Next(1, 51), Affinities.water);
            enemyCrit.AddSupportSkill("Critsplash", SupSkillType.defUp);
            enemyCrit.AddSupportSkill("Critspit", SupSkillType.spdDown);
            enemyCrit.AddSupportSkill("Critstay", SupSkillType.atkUp);
            enemy.AddCritter(enemyCrit);

            Console.WriteLine("\nThese are your critters:");

            foreach (Critter crit in player.Critters)
            {
                Console.WriteLine($" Name: {crit.Name} || Base Attack: {crit.BaseAttack} || Base Defense: {crit.BaseDefense} || Base Speed: {crit.BaseSpeed} || Affinity: {crit.Affin}");
            }

            Console.WriteLine("\nThese are the enemy's critters.");

            foreach (Critter crit in enemy.Critters)
            {
                Console.WriteLine($" Name: {crit.Name} || Base Attack: {crit.BaseAttack} || Base Defense: {crit.BaseDefense} || Base Speed: {crit.BaseSpeed} || Affinity: {crit.Affin}");
            }

            Console.WriteLine("\nNow fight!!!");

            Battleground battle = new Battleground(player, enemy);
            Console.ReadKey();
        }
    }
}
