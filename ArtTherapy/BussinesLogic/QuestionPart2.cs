using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
    public class QuestionPart2
    {
        public string QuestionText;
        public string AnswerAText;
        public string AnswerBText;
        public string AnswerCText;
        public QuestionPart2(string Q, string A, string B, string C)
        {
            this.QuestionText = Q;
            this.AnswerAText = A;
            this.AnswerBText = B;
            this.AnswerCText = C;
        }
    }
}
