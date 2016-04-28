using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2_Uppgift2.Content;
using Labb2_Uppgift2.Models;

namespace Labb2_Uppgift2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult TicTacToe()
        {

            var ticTacToeModel= new TicTacToe();
            ticTacToeModel.BoxList = new List<BoxInfo>()
            {
                new BoxInfo(1, 'x'),
                new BoxInfo(2, 'o'),
                new BoxInfo(3, 'x'),
                new BoxInfo(7, 'o')
            };
            ticTacToeModel.Players = new List<string>() {"Adriana", "Erik"};

            this.Session["ticTacToeModel"] = ticTacToeModel;
            return View(ticTacToeModel);
        }

        [HttpPost]

        public ActionResult TicTacToe(int? button)
        {
            var ticTacToeModel = (TicTacToe) this.Session["tictactoeGameModel"];
            if (button == null || ticTacToeModel == null) //Om vi tappar session, gå tillbaka till den första metoden.
            {
                return TicTacToe();
            }
            ticTacToeModel.BoxList.Add(new BoxInfo(button.Value, 'x'));
            return View(ticTacToeModel);
        }
    }
}