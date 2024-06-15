using System.Collections.Generic;
using System.Linq;

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
            var skill = Skill.TempSkill("S_Yae_21341_0_1", BChar, BChar.MyTeam);
            skill.isExcept = true;
            BChar.MyTeam.Add(skill.CloneSkill(), true);
            BChar.MyTeam.Add(skill.CloneSkill(), true);
        }
    }
}