using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Dynamic;
using System.Linq;
using System.Web;
using Labb2_Uppgift2.Content;

namespace Labb2_Uppgift2.Models
{
    public class TicTacToe
    {
        public List<BoxInfo> BoxList { get; set; } = new List<BoxInfo>();
        public List<string> Players { get; set; } //namn på spelarna. 
        public bool BordFull { get; set; }

        internal bool GameOn(int coordinates, char symbol)
        {
            
        }
    }
}