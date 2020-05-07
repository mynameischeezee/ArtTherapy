using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
    public static class SelectAnswerPart2
    {
        public static void Select(int Answerid)
        {
            if (Answerid == 1)
            {
                UserMood.AddPointToStress();
            }
            else if (Answerid == 2)
            {
                UserMood.AddPointToEmotional();
            }
            else
            {
                UserMood.AddPointToCalm();
            }
        }
    }
}
