using System;

namespace MyGameFriday
{
    public class GameLevel
    {
        private int number_rooms = 0;
        private string [] room;
        private Difficulty level;
        private int enemy_numbers;

        public GameLevel(int number_rooms, Difficulty level)
        { 
            this.level = level;
            this.number_rooms = number_rooms;
            room = new string[number_rooms];
        }
        
        public void SetEnemyInRoom(int ind_room, Enemy enemy)
        {
            room[ind_room] = enemy.GetName();
            enemy_numbers++;

        }

        public  Difficulty GetDifficulty()
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

        public void PrintEnemies()
        {
             // Este programa mostra o seguinte no ecrã:
            //
            for (int i = 0; i < room.Length; i++)
            {
                if(!string.IsNullOrEmpty(room[i]))
                {
                    Console.WriteLine($"Room {i}: {room[i]}");
                }
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
