using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValsiukLP_01_02
{
    public class RoadWorksChild : RoadWork
    {
        private int P{ get; set; }
        public RoadWorksChild (double width, double lenght, double weight, int p): base(width, lenght, weight) 
        {
            //провепка на корректность ввода
            //коэффициент прочности должен быть от 3 до 10.
            if (p < 3 || p > 10) throw new ArgumentException("Коэффициент прочности должен быть от 3 до 10");
            P = p;
        }
        public override double GetQuality() 
        {
            double q = base.GetQuality();
            if (P >= 5 && P <= 8)
            {
                return q * 1.1;
            } 
            else if (P == 3 || P == 4 || P == 9 || P == 10)
            {
                return q * 1.6;
            } 
            else
            {
                return q * 1.9;
            }
        }
    }
}
