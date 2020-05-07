using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
  public static  class SelectAnswerPart1
    {
        public static void Select(int Answerid)
        {
            if (Answerid == 1)
            {
                UserTemperament.AddPointToCholeric();
            }
            else if (Answerid == 2)
            {
                UserTemperament.AddPointToSanguine();
            }
            else if (Answerid == 3)
            {
                UserTemperament.AddPointToPhlegmatic();
            }
            else
            {
                UserTemperament.AddPointToMelancholic();
            }
        }
    }
}
