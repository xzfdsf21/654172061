namespace HREngine.Bots
{
    class Sim_LOOT_048 : SimTemplate //* 铁木魔像 Ironwood Golem
    {
        //<b>Taunt</b>Can only attack if you have 3 or more Armor.
        //<b>嘲讽</b>除非你的护甲值大于或等于3点，否则无法进行攻击。
        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            if (!m.silenced)
            {
                m.cantAttack = (p.ownHero.armor < 3) ? true : false;
                m.updateReadyness();
            }
        }

    }
}