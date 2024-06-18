using _1ChronoArkKamiyoUtil;

namespace YaeMod21341
{
    /// <summary>
    ///     Combat Readiness
    ///     Speed +1
    /// </summary>
    public class B_YaeCombatRead_21341 : Buff, IP_BattleEnd
    {
        public void BattleEnd()
        {
            SelfDestroy();
        }

        public void CustomInit()
        {
            if (BattleSystem.instance == null || BattleSystem.instance.EnemyTeam == null) return;
            PlusStat.spd = 1;
            KamiyoUtil.IncreaseEnemyActionCountByValue(1);
        }
    }
}