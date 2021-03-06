namespace HREngine.Bots
{
	class Sim_ULD_258 : SimTemplate //* 硕铠鼠 Armagedillo
	{
        //[x]<b>Taunt</b>At the end of your turn,give all <b>Taunt</b> minionsin your hand +2/+2.
        //<b>嘲讽</b>在你的回合结束时，使你手牌中所有<b>嘲讽</b>随从牌获得+2/+2。
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.MOB && hc.card.tank)
                    {
                        hc.addattack += 2;
                        hc.addHp += 2;
                        p.anzOwnExtraAttackHp += 4;
                    }
                }
            }
        }

    }
}