using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

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
                var skill = Skill.TempSkill("S_Yae_21341_1_0", BChar, BChar.MyTeam);
                skill.AP = 0;
                skill.Counting = -99;
                skill.NotCount = true;
                BattleSystem.DelayInput(PassiveAttack(skill, Targets[0]));
                return;
            }

            list = (from x in list
                orderby x.HP
                select x).ToList();
            Targets.Add(list[0]);
        }

        public IEnumerator PassiveAttack(Skill skill, BattleChar target)
        {
            yield return new WaitForSeconds(0.2f);
            if (BattleSystem.instance.EnemyList.Count != 0)
                yield return BattleSystem.instance.ForceAction(skill, target, false, false, true);
        }
    }
}