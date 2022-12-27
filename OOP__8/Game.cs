using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__8
{
    public class Game
    {
        public Enemy? enemy;
        public double HealthBar = 100;
        public int HealPointsUp = 10;
        public int AttackPoint;
        public Game(double HealthBar, int AttackPoint, Enemy enemy)
        {
            this.HealthBar = HealthBar;
            this.AttackPoint = AttackPoint;
            this.enemy = enemy;
        }
        
        public double HealsUp(double HealPointsUp)
        {
            
            if(HealthBar == 100)
            {
                Console.WriteLine("No need to heal");
                return HealthBar;
            }
            else
            {
                if (HealthBar + HealPointsUp <= 100)
                {
                    HealthBar += HealPointsUp;
                    Console.WriteLine($"Healed {HealPointsUp} HP!");
                    return HealthBar;
                }
                else
                {
                    if (HealPointsUp + HealthBar > 100)
                    {
                        double HealLimit = HealthBar + HealPointsUp - 100;
                        HealthBar += HealLimit;
                        Console.WriteLine($"Healed {HealLimit} HP!");
                        return HealthBar;
                    }
                }
            }
            return HealthBar;
        }

        int EH => enemy.EnemyHealth;

        public int Attacking(int AttackPoint)
        {
            
            if(EH - AttackPoint <=0)
            {
                Console.WriteLine("Enemy destroyed");
                return EH;
            }
            else
            {
                Console.WriteLine($"Enemy got {AttackPoint} DMG!");
                return EH;
            }
        }

        public int EA => enemy.EnemyAttack;

        public double Damage(Enemy enemy)
        {   
            if(HealthBar - EA <= 0)
            {
                Console.WriteLine("You've lost all HP!");
            }
            else
            {
                HealthBar -= EA;
                return HealthBar;
            }
            return HealthBar;

        }

        public bool HealthLimit(Enemy enemy)
        {
            if (HealthBar == 0 || enemy.EnemyHealth ==0) { 
                return false; 
            }

            return true;
        }
    }
}
