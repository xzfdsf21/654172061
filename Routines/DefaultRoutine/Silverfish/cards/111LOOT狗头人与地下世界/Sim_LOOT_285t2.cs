using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_285t2 : SimTemplate //* 锯齿盾牌
    {
        //获得5点护甲值.造成$5点伤害.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.minionGetDamageOrHeal(target, dmg);
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 5);
        }
    }
}