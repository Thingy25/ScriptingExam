using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptingExam
{
    static public class Utilities
    {
        static public float Compare(Affinities player, Affinities enemy)
        {
            float affinityMultiplier = 1.0f;

            switch(player)
            {
                case  Affinities.fire:
                {
                    switch (enemy)
                    {
                        case Affinities.fire:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.wind:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.water:
                        {
                            affinityMultiplier = 2.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.earth:
                        {
                            affinityMultiplier = 0.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.dark:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.light:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                    }
                    break;
                }
                case Affinities.wind:
                {
                    switch (enemy)
                    {
                        case Affinities.fire:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.wind:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.water:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.earth:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.dark:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.light:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                    }
                    break;
                }
                case Affinities.water:
                {
                    switch (enemy)
                    {
                        case Affinities.fire:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.wind:
                        {
                            affinityMultiplier = 2.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.water:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.earth:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.dark:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.light:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                    }
                    break;
                }
                case Affinities.earth:
                {
                    switch (enemy)
                    {
                        case Affinities.fire:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.wind:
                        {
                            affinityMultiplier = 2.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.water:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.earth:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.dark:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.light:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                    }
                    break;
                }
                case Affinities.dark:
                {
                    switch (enemy)
                    {
                        case Affinities.fire:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.wind:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.water:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.earth:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.dark:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                        case Affinities.light:
                        {
                            affinityMultiplier = 2.0f;
                            return affinityMultiplier;
                        }
                    }
                    break;
                }
                case Affinities.light:
                {
                    switch (enemy)
                    {
                        case Affinities.fire:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.wind:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.water:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.earth:
                        {
                            affinityMultiplier = 1.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.dark:
                        {
                            affinityMultiplier = 2.0f;
                            return affinityMultiplier;
                        }
                        case Affinities.light:
                        {
                            affinityMultiplier = 0.5f;
                            return affinityMultiplier;
                        }
                    }
                    break;
                }
            }
            return affinityMultiplier;
        }
    }
}
