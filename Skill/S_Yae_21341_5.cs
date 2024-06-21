using System.Collections.Generic;
using _1ChronoArkKamiyoUtil;

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
            if (Targets[0] == null) return;
            if (Targets[0].HP <= Targets[0].GetStat.maxhp * 0.75f)
                BChar.DrawCharacterSkill(
                    BChar.PrepareSkill("S_Yae_21341_5_0", new KamiyoSkillChangeParameters()));
            if (Targets[0].HP > Targets[0].GetStat.maxhp * 0.5f) return;
            BattleSystem.instance.AllyTeam.AP += 1;
            SkillBasePlus.Target_BaseDMG = 3;
        }
    }
}