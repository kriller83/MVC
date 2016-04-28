using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Labb2_Uppgift2.Content
{
    public struct BoxInfo
    {
        //Skapar två properties
        public int BoxCoordinate { get; private set; }
        public char Value { get; private set; }

        public BoxInfo(int box, char value ) //skapr ett nytt objekt
        {
            //TODO: kontrollera value
            BoxCoordinate = box;
            Value = value;
        } 
    }
}

//Varje gång man trycker på x eller o så skapas det ett nytt objekt i BoxInfo. 