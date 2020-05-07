using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
    public static class UserMood
    {
        private static int _Stressful;
        private static int _Emotional;
        private static int _Calm;

        static UserMood()
        {
            _Stressful = 0;
            _Emotional = 0;
            _Calm = 0;
        }
        public static int Stressful { get { return _Stressful; } private set { _Stressful = value; } }
        public static int Emotional { get { return _Emotional; } private set { _Emotional = value; } }
        public static int Calm { get { return _Calm; } private set { _Calm = value; } }

        public static void AddPointToStress()
        {
            _Stressful += 1;
        }
        public static void AddPointToEmotional()
        {
            _Emotional += 1;
        }
        public static void AddPointToCalm()
        {
            _Calm += 1;
        }
        public static bool HighestMood()
        {
            List<int> TempArr = new List<int>();
            TempArr.Add(_Stressful);
            TempArr.Add(_Emotional);
            TempArr.Add(_Calm);
            int count = TempArr.Count(x => x == TempArr.Max());
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
