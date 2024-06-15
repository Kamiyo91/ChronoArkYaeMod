using System.Collections.Generic;

namespace YaeMod21341
{
    /// <summary>
    ///     Hidden Dagger
    /// </summary>
    public class S_Yae_21341_5 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            SkillBasePlus.Target_BaseDMG = 0;
            if (Targets[0] == null || Targets[0].HP > Targets[0].GetStat.maxhp * 0.5f) return;
            BattleSystem.instance.AllyTeam.AP += 1;
            SkillBasePlus.Target_BaseDMG = 3;
        }
    }
}