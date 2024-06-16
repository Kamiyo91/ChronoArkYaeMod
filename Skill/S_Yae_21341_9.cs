using System.Collections.Generic;
using GameDataEditor;
using UnityEngine;

namespace YaeMod21341
{
    /// <summary>
    ///     Red Moon
    /// </summary>
    public class S_Yae_21341_9 : Skill_Extended, IP_BuffAdd
    {
        public void Buffadded(BattleChar BuffUser, BattleChar BuffTaker, Buff addedbuff)
        {
            if (BuffUser != BChar || BuffTaker == null || BuffTaker.MyTeam == BattleSystem.instance.AllyTeam ||
                addedbuff.BuffData.BuffTag.Key != GDEItemKeys.BuffTag_DOT) return;
            SkillBasePlus.Target_BaseDMG += 10;
            SkillBasePlus.Target_BaseDMG = Mathf.Clamp(SkillBasePlus.Target_BaseDMG, 0, 50);
        }

        public override void Init()
        {
            base.Init();
            OnePassive = true;
        }

        public override bool TargetSelectExcept(BattleChar ExceptTarget)
        {
            return ExceptTarget.MyTeam == BattleSystem.instance.AllyTeam || ExceptTarget.GetBuffs(BattleChar.GETBUFFTYPE.DOT, false).Count == 0;
        }

        public override string DescExtended(string desc)
        {
            return base.DescExtended(desc).Replace("&a", SkillBasePlus.Target_BaseDMG.ToString());
        }

        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            if (SkillBasePlus.Target_BaseDMG < 50) return;
            var skill = Skill.TempSkill("S_Yae_21341_9_0", BChar, BChar.MyTeam);
            skill.isExcept = true;
            BChar.MyTeam.Add(skill.CloneSkill(), true);
        }
    }
}