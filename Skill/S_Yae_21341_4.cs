using System.Collections.Generic;

namespace YaeMod21341
{
    /// <summary>
    ///     Fist
    /// </summary>
    public class S_Yae_21341_4 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            var skill = Skill.TempSkill("S_Yae_21341_7", BChar, BChar.MyTeam);
            skill.isExcept = true;
            BChar.MyTeam.Add(skill.CloneSkill(), true);
        }
    }
}