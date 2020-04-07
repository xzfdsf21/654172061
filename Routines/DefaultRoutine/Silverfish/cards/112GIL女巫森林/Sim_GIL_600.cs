namespace HREngine.Bots
{
    class Sim_GIL_600 : SimTemplate //* 静电震击 Zap!
    {
        //Deal $2 damage to a minion. <b>Overload:</b> (1)
        //对一个随从造成$2点伤害。<b>过载：</b>（1）
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
            if (ownplay) p.overload++;
        }

    }
}