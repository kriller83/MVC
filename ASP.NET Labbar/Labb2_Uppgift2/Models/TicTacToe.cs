using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using Labb2_Uppgift2.Content;

namespace Labb2_Uppgift2.Models
{
    public class TicTacToe
    {
        public List<BoxInfo> BoxList { get; set; } 
        public List<string> Players { get; set; } //namn på spelarna. 
    }
}