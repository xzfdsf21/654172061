namespace HREngine.Bots
{
    class Sim_LOOT_080t2 : SimTemplate //* 法术翡翠 Emerald Spellstone
    {
        //Summon three 3/3 Wolves. <i>(Play a <b>Secret</b> to upgrade.)</i>
        //召唤三只3/3的狼。<i>（使用一个<b>奥秘</b>后升级。）</i>
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_077t);//狼

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }

    }
}