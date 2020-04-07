using System.Collections.Generic;

namespace HREngine.Bots
{
	class Sim_ULD_280 : SimTemplate //* 沙赫柯特工兵 Sahket Sapper
	{
        //<b>Deathrattle:</b> Return a  random enemy minion to  your opponent's hand.
        //<b>亡语：</b>随机将一个敌方随从移回对手的手牌。
        public override void onDeathrattle(Playfield p, Minion m)
        {
            List<Minion> temp = (m.own) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);

            if (temp.Count > 0)
            {
                if (m.own) temp.Sort((a, b) => b.Attack.CompareTo(a.Attack));
                else temp.Sort((a, b) => a.Attack.CompareTo(b.Attack));
                Minion target = temp[0];
                if (m.own && temp.Count >= 2 && !target.taunt && temp[1].taunt) target = temp[1];
                p.minionReturnToHand(target, !m.own, 0);
            }
        }

    }
}