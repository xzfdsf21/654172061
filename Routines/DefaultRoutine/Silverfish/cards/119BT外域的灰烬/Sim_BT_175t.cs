using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_175t  : SimTemplate// BT_175t  二次斩击
//在本回合中，使你的英雄获得+1攻击力。
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetBuffed(p.ownHero, 1, 0);
            }
        }
    }
}