using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_175  : SimTemplate// BT_175  双刃斩击
	{
        //在本回合中，使你的英雄获得+1攻击力。将“二次斩击”置入你的手牌。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                p.minionGetBuffed(p.ownHero, 1, 0);
                p.drawACard(CardDB.cardIDEnum.BT_175t, ownplay, true);
            }
            
        }
    }
}