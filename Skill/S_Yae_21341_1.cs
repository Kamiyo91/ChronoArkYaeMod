using System.Collections.Generic;
using System.Linq;
using _1ChronoArkKamiyoUtil;

namespace YaeMod21341
{
    /// <summary>
    ///     Approach
    /// </summary>
    public class S_Yae_21341_1 : Skill_Extended
    {
        public override void SkillUseSingleAfter(Skill SkillD, List<BattleChar> Targets)
        {
            if (!Targets.Any(x => x.GetBuffs(BattleChar.GETBUFFTYPE.DOT, false).Any())) return;
            var list = new List<BattleChar>();
            list.AddRange(BattleSystem.instance.EnemyTeam.AliveChars);
            list.Remove(Targets[0]);
            if (list.Count < 1 && BattleSystem.instance.EnemyList.Count != 0)
            {
                BChar.AdditionalAttack(Targets[0],
                    BChar.PrepareSkill("S_Yae_21341_1_0", new KamiyoSkillChangeParameters(-99, true, -99)));
                return;
            }

            list = (from x in list
                orderby x.HP
                select x).ToList();
            Targets.Add(list[0]);
        }
    }
}