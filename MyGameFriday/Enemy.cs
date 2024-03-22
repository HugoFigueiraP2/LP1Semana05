using System;

namespace MyGameFriday
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;



        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
            
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public float GetHealth()
        {
            return health;

        }

        public float GetShield()
        {
            return shield;
        }

        public string SetName(string char_name)
        {
            char_name = char_name.Trim();

            if (char_name.Length > 8)
            {
                name = char_name.Substring(0,8);
            }
            else
            {
                name = char_name;

            }

            return name;

        }

        






        
    }

}