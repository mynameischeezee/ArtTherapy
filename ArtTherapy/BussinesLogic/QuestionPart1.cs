using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
   public class QuestionPart1
    {
        public string QuestionText;
        public string AnswerAText;
        public string AnswerBText;
        public string AnswerCText;
        public string AnswerDText;
        public QuestionPart1(string Q, string A, string B, string C, string D)
        {
            this.QuestionText = Q;
            this.AnswerAText = A;
            this.AnswerBText = B;
            this.AnswerCText = C;
            this.AnswerDText = D;
        }
    }
}
