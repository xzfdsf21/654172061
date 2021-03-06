using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BRMA09_2_TB : SimTemplate //* Open the Gates
    {
        // Hero Power: Summon three 1/1 Whelps. Get a new Hero Power.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BRMA09_2t);//1/1Whelp

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, place, ownplay, false);
            p.callKid(kid, place, ownplay);
            p.callKid(kid, place, ownplay);
        }
    }
}