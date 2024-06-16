using System.Collections.Generic;
using UnityEngine;

namespace YaeMod21341
{
    /// <summary>
    ///     Combat Readiness
    /// </summary>
    public class S_Yae_21341_7 : Skill_Extended, IP_SkillUse_Target
    {
        private static readonly List<string> SkillKeys = new List<string>
            { "S_Yae_21341_0", "S_Yae_21341_1", "S_Yae_21341_2", "S_Yae_21341_5" };

        public void AttackEffect(BattleChar hit, SkillParticle SP, int DMG, bool Cri)
        {
            if (SP.SkillData != MySkill) return;
            if (!BChar.BuffFind("B_YaeCombatRead_21341"))
            {
                var buff = BChar.BuffAdd("B_YaeCombatRead_21341", BChar) as B_YaeCombatRead_21341;
                buff?.CustomInit();
            }

            if (!Cri) return;
            var keyword = SkillKeys[Random.Range(0, SkillKeys.Count)];
            var skill = Skill.TempSkill(keyword, BChar, BChar.MyTeam);
            skill.isExcept = true;
            BChar.MyTeam.Add(skill.CloneSkill(), true);
        }
    }
}