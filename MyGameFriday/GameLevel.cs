using System;

namespace MyGameFriday
{
    public class GameLevel
    {
        private int number_rooms;
        private string [] room;
        private Difficulty level;
        private int enemy_numbers;

        public GameLevel(int number_rooms, Difficulty level)
        { 
            GetNumRooms(number_rooms);
            GetDifficulty(level);
            enemy_numbers = 0;
            room[number_rooms];
        }
        
        public void SetEnemyInRoom(int ind_room, Enemy enemy)
        {
            if(enemy in room[ind_room])
            {
                Console.WriteLine
                ("Já tem um inimigo a ocupar esta sala!");
            }
            else
            {
                enemy_numbers ++;
                room[ind_room] = enemy;

            }

        }

        public Difficulty GetDifficulty()
        {
            return level;

        }
        public int GetNumRooms()
        {
            return number_rooms;

        }

        public int GetNumEnemies()
        {
            return enemy_numbers;

        }

        public string PrintEnemies()
        {
             // Este programa mostra o seguinte no ecrã:
            //
            for(int i = 0; i < GetNumEnemies; i++)
            {
            Console.WriteLine($"Room {room[en]}")
            }
            
            // Difficulty: Easy
            // Number of rooms: 101
            // Number of enemies: 5
            // Room 1: Ringo
            // Room 2: Tina
            // Room 18: Faker
            // Room 57: Out of order
            // Room 98: Chet
        }

        

    }
}
