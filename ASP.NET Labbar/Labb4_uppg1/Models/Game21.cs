using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb4_uppg1.Models
{
    public class Game21
    {
        public static int CurentValue { get; set; }
        public static string Message { get; set; }

        public Game21(int value, string message)
        {
            CurentValue = value;
            Message = message;
        }
        public static Game21 GetCurrentValue(int value)
        {
            if (CurentValue < 19)
            {
                CurentValue += value;
                Message = "Next Move";
            }
            else if (CurentValue == 19)
            {
                if (value == 1)//show 21/21 after player moved
                {
                    CurentValue += value;
                    Message = "Next Move";
                }
                else if (value == 2)//player win
                {
                    CurentValue += value;
                    Message = "You win!!!";
                }

            }
            else if (CurentValue == 20)
            {
                if (value == 1 || value == 2)
                {
                    CurentValue = 21;
                    Message = "You win!!!";
                }
            }
            Game21 game = new Game21(CurentValue, Message);
            return game;
        }
    }
}