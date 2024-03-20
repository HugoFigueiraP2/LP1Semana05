using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_inimigos = int.Parse(args[0]);

            Enemy[] enemies  = new Enemy [n_inimigos]; // tamanho da lista

            for(int i = 0; i < n_inimigos; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string nome_inimigo = Console.ReadLine();
                enemies[i] = new Enemy(nome_inimigo);

            }

            enemies[0].TakeDamage(20);
            enemies[0].PickupPowerUp(PowerUp.Shield, 30);
            enemies[1].PickupPowerUp(PowerUp.Shield, 40);
            enemies[1].PickupPowerUp(PowerUp.Shield, 30);
            


            foreach(Enemy j in enemies)
            {
                Console.WriteLine($"{j.GetName()} {j.GetHealth()} {j.GetShield()}");

            }

            Console.WriteLine(Enemy.GetPowersCollected());
        }
    }
}
