using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__8
{
    public class Enemy
    {
        public int EnemyAttack;
        public int EnemyHealth;

        public Enemy(int enemyAttack, int enemyHealth)
        {
            EnemyAttack = enemyAttack;
            EnemyHealth = enemyHealth;
        }
    }
}
