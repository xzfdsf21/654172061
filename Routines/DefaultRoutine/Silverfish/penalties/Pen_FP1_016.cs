using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Pen_FP1_016 : PenTemplate //wailingsoul
    {

        //    kampfschrei:/ bringt eure anderen diener zum schweigen/.
        public override int getPlayPenalty(Playfield p, Minion m, Minion target, int choice, bool isLethal)
        {
            return 0;
        }

    }
}