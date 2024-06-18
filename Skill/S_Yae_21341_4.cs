using System.Collections.Generic;
using _1ChronoArkKamiyoUtil;

namespace YaeMod21341
{
    /// <summary>
    ///     Fist
    /// </summary>
    public class S_Yae_21341_4 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            KamiyoUtil.DrawCharacterSkill(BChar,
                KamiyoUtil.PrepareSkill(BChar, nameof(S_Yae_21341_7), new KamiyoSkillChangeParameters()));
        }
    }
}