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
            Player player = new Player();
            Player enemy = new Player();
            Battleground battle = new Battleground(player, enemy);

            string temp, name;
            float baseAttack, baseDefense, baseSpeed;

            Random rand = new Random();

            Console.WriteLine("Welcome to Crittermon!!");
            Console.WriteLine("Create your own Crittermon:");
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the base attack: It can only range from 10 to 100.");
            temp = Console.ReadLine();
            if(float.TryParse(temp, out baseAttack))
            {
                Console.WriteLine("Enter the base defense: It can only range from 10 to 100.");
                temp = Console.ReadLine();
                if(float.TryParse(temp, out baseDefense))
                {
                    Console.WriteLine("Enter the base speed: It can only range from 1 to 50.");
                    temp = Console.ReadLine();
                    if(float.TryParse(temp, out baseSpeed))
                    {
                        player.AddCritter(name, baseAttack, baseDefense, baseSpeed);
                    }
                }
            }
            Console.WriteLine($"Este es tu nuevo Crittermon: Nombre: {player.critters[0].Name} || Base Attack: {player.critters[0].BaseAttack} || Base Defense: {player.critters[0].BaseDefense} || Base Speed: {player.critters[0].BaseSpeed}");

            enemy.AddCritter();
            Console.WriteLine($"\nEste es tu Crittermon enemigo: Nombre: {enemy.critters[0].Name} || Base Attack: {enemy.critters[0].BaseAttack} || Base Defense: {enemy.critters[0].BaseDefense} || Base Speed: {enemy.critters[0].BaseSpeed}");




















            //play.InitialCritterCreation();
            //battle.ChooseCritter();
            //battle.ChooseCritter(rand.Next(0, play.critters.Count));

            Console.ReadKey();
        }
    }
}
