using System.Collections.Generic;
using System.Linq;
using _1ChronoArkKamiyoUtil;

namespace YaeMod21341
{
    /// <summary>
    ///     Anthem Blade
    /// </summary>
    public class S_Yae_21341_0 : Skill_Extended
    {
        public override void SkillUseSingleAfter(Skill SkillD, List<BattleChar> Targets)
        {
            if (!Targets.Any(x => x.GetBuffs(BattleChar.GETBUFFTYPE.DOT, false).Any())) return;
            BChar.DrawCharacterSkill(
                BChar.PrepareSkill("S_Yae_21341_0_1", new KamiyoSkillChangeParameters()), 2);
        }
    }
}