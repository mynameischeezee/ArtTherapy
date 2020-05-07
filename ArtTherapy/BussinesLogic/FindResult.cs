using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
    public static class FindResult
    {
        public static Result ReturnResult()
        {
            List<int> TempArr = new List<int>();
            TempArr.Add(UserTemperament.Choleric);
            TempArr.Add(UserTemperament.Sanguine);
            TempArr.Add(UserTemperament.Phlegmatic);
            TempArr.Add(UserTemperament.Melancholic);

            int MaxIndexTemp = TempArr.IndexOf(TempArr.Max());

            List<int> TempList = new List<int>();
            TempList.Add(UserMood.Stressful);
            TempList.Add(UserMood.Emotional);
            TempList.Add(UserMood.Calm);
            int MaxIndexMood = TempList.IndexOf(TempList.Max());

            return MainResult.Results[MaxIndexTemp][MaxIndexMood];
        }
    }
}
