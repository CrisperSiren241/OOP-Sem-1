using System;

namespace OOP__8 
{
    public delegate double Healing(double HealthUp);
    public delegate int Attack(int AttackPoints);
    class Program
    {
        public static event Healing? heal;
        public static event Attack? attack;
        
        static void Menu()
        {
            Console.WriteLine("Вы сражаетесь с противником. Выберите действие:");
            Console.WriteLine($"1 - Атаковать");
            Console.WriteLine($"2 - Полечиться");
            Console.WriteLine($"3 - Просмотреть характеристики");
            Console.WriteLine($"4 - Просмотреть характеристики врага");
            Console.WriteLine();
        }
        
        static void Main()
        {
            string? choice;
            Enemy enemy = new Enemy(5, 100);
            Game newGame = new Game(100, 15, enemy);
            Attack attacking = new Attack(newGame.Attacking);
            Healing healing = new Healing(newGame.HealsUp);
            attack += attacking;
            heal += healing;
            do
            {
                Menu();
                choice = Console.ReadLine();
                switch (Convert.ToInt32(choice))
                {
                    case 1:
                        attack(newGame.AttackPoint);
                        Console.WriteLine("Противник атакует!");
                        Console.WriteLine($"Вы потеряли {enemy.EnemyAttack} очков HP!");
                        Console.WriteLine($"Ваше текущее HP: {newGame.HealthBar}!");
                        newGame.Damage(enemy);
                        break;
                    case 2:
                        heal(newGame.HealPointsUp);
                        Console.WriteLine("Противник атакует!");
                        Console.WriteLine($"Вы потеряли {enemy.EnemyAttack} очков HP!");
                        Console.WriteLine($"Ваше текущее HP: {newGame.HealthBar}!");
                        newGame.Damage(enemy);
                        break;
                        
                    case 3:
                        Console.WriteLine($"Ваше текущее HP: {newGame.HealthBar}!");
                        break;
                    case 4:
                        Console.WriteLine($"Здоровье: {enemy.EnemyHealth}" + "\n" + $"Атака: {enemy.EnemyAttack}");
                        break;
                    
                }
                
            }
            while (newGame.HealthLimit(enemy));
            if(newGame.HealthBar == 0)
            {
                Console.WriteLine("Вы проиграли!");
            }
            else
            {
                if(enemy.EnemyHealth == 0)
                {
                    Console.WriteLine("Вы победили!!!");
                }
            }

            Console.WriteLine("Обработка методов строк");
            Func<string, string> funcStr;
            string str = "El  d  en  r    ing+";
            Console.WriteLine($"Исходная строка:        {str}");
            funcStr = String.RemoveSpace;
            Console.WriteLine($"Без пробелов:           {str = funcStr(str)}");
            funcStr = String.Upper;
            Console.WriteLine($"Заглавными буквами:     {str = funcStr(str)}");
            funcStr = String.Lower;
            Console.WriteLine($"Строчными буквами:      {str = funcStr(str)}");
            funcStr = String.AddToString;
            Console.WriteLine($"С добавлением символа:  {str = funcStr(str)}");
        }
    }

}
