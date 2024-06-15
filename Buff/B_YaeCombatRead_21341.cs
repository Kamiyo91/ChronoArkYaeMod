using System.Linq;

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

        public override void Init()
        {
            if (BattleSystem.instance == null || BattleSystem.instance.EnemyTeam == null) return;
            PlusStat.spd = 1;
            foreach (var enemy in BattleSystem.instance.EnemyTeam.GetAliveChars().Select(x => x as BattleEnemy))
            {
                if (enemy == null) continue;
                foreach (var skill in enemy.SkillQueue)
                    skill.CastSpeed += 1;
            }
        }
    }
}