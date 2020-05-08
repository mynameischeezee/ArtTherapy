using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
   public class Result
    {
        public string Temp;
        public string Mood;
        public string Direction;
        public string Type;
        public string Text1;
        public string Text2;
        public string About1;
        public string About2;
        public Image Img;
        public string URL;
        public Result(string T, string M, string D, string type, string text1, string text2, string A, Image I)
        {
            this.Temp = T;
            this.Mood = M;
            this.Direction = D;
            this.Type = type;
            this.Text1 = text1;
            this.Text2 = text2;
            this.Img = I;
            this.About1 = A;
        }
        public Result(string T, string M, string D, string type, string text1, string text2, string A, string A2, Image I)
        {
            this.Temp = T;
            this.Mood = M;
            this.Direction = D;
            this.Type = type;
            this.Text1 = text1;
            this.Text2 = text2;
            this.Img = I;
            this.About1 = A;
            this.About2 = A2;
        }
        public Result(string T, string M, string D, string type, string text1, string text2, string A, string A2, Image I, string U)
        {
            this.Temp = T;
            this.Mood = M;
            this.Direction = D;
            this.Type = type;
            this.Text1 = text1;
            this.Text2 = text2;
            this.Img = I;
            this.About1 = A;
            this.About2 = A2;
            this.URL = U;
        }
        public Result(string T, string M, string D, string type, string text1, string text2, string A, Image I, string U)
        {
            this.Temp = T;
            this.Mood = M;
            this.Direction = D;
            this.Type = type;
            this.Text1 = text1;
            this.Text2 = text2;
            this.Img = I;
            this.About1 = A;
            this.URL = U;
        }
    }
}
