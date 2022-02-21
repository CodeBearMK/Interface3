using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    internal class CStudent:IPass,ILevel
    {
        private string passOK;
        private int score = 60;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Pass(int grade)
        {
            if (grade >= score) passOK = "及格"; else passOK = "不及格";
            return passOK;
        }

        private string levelN;
        private int high = 80;
        public int High
        {
            get { return high; }
            set { high = value; }
        }

        private int low = 55;
        public int Low
        {
            get { return low; }
            set { low = value; }
        }

        public string Level(int grade)
        {
            if (grade >= high) levelN = "表現優異";
            if ((grade >= low) && (grade < high)) levelN = "差強人意";
            if (grade < low) levelN = "有待加強";
            return levelN;
        }

    }
}
