using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArtTherapy.BussinesLogic
{
    public static class UserTemperament
    {
        private static int _Choleric;
        private static int _Sanguine;
        private static int _Phlegmatic;
        private static int _Melancholic;

        static UserTemperament()
        {
            _Choleric = 0;
            _Sanguine = 0;
            _Phlegmatic = 0;
            _Melancholic = 0;
        }
        public static int Choleric { get { return _Choleric; } private set { _Choleric = value; } }
        public static int Sanguine { get { return _Sanguine; } private set { _Sanguine = value; } }
        public static int Phlegmatic { get { return _Phlegmatic; } private set { _Phlegmatic = value; } }
        public static int Melancholic { get { return _Melancholic; } private set { _Melancholic = value; } }

        public static void AddPointToCholeric()
        {
            _Choleric += 1;
        }
        public static void AddPointToSanguine()
        {
            _Sanguine += 1;
        }
        public static void AddPointToPhlegmatic()
        {
            _Phlegmatic += 1;
        }
        public static void AddPointToMelancholic()
        {
            _Melancholic += 1;
        }
        public static bool HighestTemperament()
        {
            List<int> TempArr = new List<int>();
            TempArr.Add(_Choleric);
            TempArr.Add(_Sanguine);
            TempArr.Add(_Phlegmatic);
            TempArr.Add(_Melancholic);
            int count = TempArr.Count(x => x  == TempArr.Max());
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
