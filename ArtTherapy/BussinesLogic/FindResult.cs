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
            TempArr.Add(Convert.ToInt32(UserTemperament.Choleric));
            TempArr.Add(Convert.ToInt32(UserTemperament.Sanguine));
            TempArr.Add(Convert.ToInt32(UserTemperament.Phlegmatic));
            TempArr.Add(Convert.ToInt32(UserTemperament.Melancholic));

            int MaxIndexTemp = TempArr.IndexOf(TempArr.Max());

            List<int> TempList = new List<int>();
            TempList.Add(Convert.ToInt32(UserMood.Stressful));
            TempList.Add(Convert.ToInt32(UserMood.Emotional));
            TempList.Add(Convert.ToInt32(UserMood.Calm));
            foreach (int i in TempList)
            {
                Console.WriteLine(i);
            }
            int MaxIndexMood = TempList.IndexOf(TempList.Max());
            return MainResult.Results[MaxIndexTemp][MaxIndexMood];
        }
    }
}
