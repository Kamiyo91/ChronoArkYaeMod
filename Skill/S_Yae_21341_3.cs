using System.Collections.Generic;

namespace YaeMod21341
{
    /// <summary>
    ///     Bloodlust
    /// </summary>
    public class S_Yae_21341_3 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            BattleSystem.instance.AllyTeam.Draw(1);
        }
    }
}