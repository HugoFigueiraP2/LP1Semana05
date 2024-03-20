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

            foreach(Enemy j in enemies)
            {
                Console.WriteLine($"{j.GetName()} {j.GetHealth()} {j.GetShield()}");

            }
        }
    }
}
