using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrziPrsti
{
    [Serializable]
    public class UserScore
    {
        public string userName { get; set; }
        public float accuracy { get; set; }
        public float wpm { get; set; }

        public UserScore(string userName, float accuracy, float wpm)
        {
            this.userName = userName;
            this.accuracy = accuracy;
            this.wpm = wpm;
        }

        public UserScore()
        {
            userName = "";
            accuracy = 0;
            wpm = 0;
        }

        public void update(UserScore nov)
        {
            if(nov.userName == userName)
            {
                if(nov.accuracy > accuracy)
                {
                    accuracy = nov.accuracy;
                }
                if(nov.wpm > wpm)
                {
                    wpm = nov.wpm;
                }
            }
            else
            {

            }
        }
    }
}
