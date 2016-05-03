using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Labb2_Uppgift1_21.Helpers;

namespace Labb2_Uppgift1_21.Models
{
    public class TwentyOne
    {
        public List<GameField> GameFields { get; set; }
        public GameStatus ActiveGameStatus { get; set; }

        public void Plus(int value)
        {
            if (GameFields[2].Value <= 17)
            {
                if (value == 1 || value == 2)
                {
                    PlayerMoved(value);
                }
                else if (value == 3)
                {
                    var valueForComputerMove = RandomComputerMove();
                    ComputerMoved(valueForComputerMove);
                }
            }
            else if (GameFields[2].Value == 18)
            {
                if (value == 1)
                {
                    PlayerMoved(value);
                }
                else if (value == 2)
                {
                    PlayerGoneToTwenty(value);
                }
            }
        }

        private void PlayerMoved(int value)
        {
            for (int i = 0; i < GameFields.Count - 1; i++)
            {
                GameFields[i].Value += value;
            }
            GameFields[0].Active = "disabled";
            GameFields[1].Active = "disabled";
            GameFields[0].Color = "";
            GameFields[1].Color = "";
            GameFields[GameFields.Count - 1].Active = "";
            GameFields[GameFields.Count - 1].Color = "hotpink";
            ActiveGameStatus.TextOnScreen = "Computer turn. Click the button";
        }

        private void ComputerMoved(int valueForCompare)
        {
            for (int i = 0; i < GameFields.Count - 1; i++)
            {
                GameFields[i].Value += valueForCompare;
            }
            GameFields[0].Active = "";
            GameFields[1].Active = "";
            GameFields[0].Color = "hotpink";
            GameFields[1].Color = "hotpink";
            GameFields[GameFields.Count - 1].Active = "disabled";
            GameFields[GameFields.Count - 1].Color = "";
            ActiveGameStatus.TextOnScreen = "Your turn. Select number";
        }

        private static int RandomComputerMove()
        {
            Random rand = new Random();
            int valueForCompare = rand.Next(1, 3);
            return valueForCompare;
        }

        private void PlayerGoneToTwenty(int value)
        {
            GameFields[0].Value = 21;
            GameFields[1].Value = 21;
            GameFields[2].Value += value;
            GameFields[1].Active = "";
            GameFields[0].Active = "";
            GameFields[0].Color = "hotpink";
            GameFields[1].Color = "hotpink";
            GameFields[GameFields.Count - 1].Active = "disabled";
            GameFields[GameFields.Count - 1].Color = "";
            ActiveGameStatus.TextOnScreen = "Your turn. Select number";
        }
    }
}