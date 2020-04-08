using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_341  : SimTemplate// BT_341  骸骨巨龙
                                   //嘲讽 在你的回合结束时，将一张龙牌置入你的手牌。
    {
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardName.faeriedragon, triggerEffectMinion.own, true);
            }
        }
    }
}