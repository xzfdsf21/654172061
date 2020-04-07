namespace HREngine.Bots
{
	class Sim_ULD_727 : SimTemplate //* 裹尸匠 Body Wrapper
	{
		//<b>Battlecry:</b> <b>Discover</b> a friendly minion that died this game. Shuffle it into your deck.
		//<b>战吼：</b><b>发现</b>一个在本局对战中死亡的友方随从。将其洗入你的牌库。

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.minionSetAttackToX(target, 1);
			p.minionSetLifetoX(target, 1);
		}
	}
}