using System.Collections.Generic;
using System.Linq;

namespace YaeMod21341
{
    /// <summary>
    ///     Past Memories
    /// </summary>
    public class S_Yae_21341_6 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            BattleSystem.instance.AllyTeam.AP += 3;
            var skill = BattleSystem.instance.AllyTeam.Skills_Deck.FirstOrDefault(x =>
                x.AllExtendeds.Any(y => y is S_Yae_21341_8));
            if (skill != null)
            {
                BattleSystem.instance.AllyTeam.Draw(skill);
                BattleSystem.instance.AllyTeam.Draw(1);
                return;
            }

            BattleSystem.instance.AllyTeam.Draw(2);
        }
    }
}