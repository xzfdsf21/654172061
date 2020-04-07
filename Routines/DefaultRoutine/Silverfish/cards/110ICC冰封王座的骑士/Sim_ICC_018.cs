using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_018 : SimTemplate //* Phantom Freebooter
    {
        // Battlecry: Gain stats equal to your weapon's.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetBuffed(own, 1, 1);
            if (own.own)
            {
                own.Attack += p.ownWeapon.Attack;
                own.Hp += p.ownWeapon.Durability;
                own.maxHp += p.ownWeapon.Durability;
            }
            else
            {
                own.Attack += p.enemyWeapon.Attack;
                own.Hp += p.enemyWeapon.Durability;
                own.maxHp += p.enemyWeapon.Durability;
            }
        }
    }
}
