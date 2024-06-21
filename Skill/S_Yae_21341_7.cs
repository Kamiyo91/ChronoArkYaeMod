using System.Collections.Generic;
using _1ChronoArkKamiyoUtil;

namespace YaeMod21341
{
    /// <summary>
    ///     Combat Readiness
    /// </summary>
    public class S_Yae_21341_7 : Skill_Extended, IP_SkillUse_Target, IP_BuffAddAfter
    {
        private static readonly List<string> SkillKeys = new List<string>
            { "S_Yae_21341_0", "S_Yae_21341_1", "S_Yae_21341_2", "S_Yae_21341_5" };

        public void BuffaddedAfter(BattleChar BuffUser, BattleChar BuffTaker, Buff addedbuff, StackBuff stackBuff)
        {
            BChar.GetBuff<B_YaeCombatRead_21341>(nameof(B_YaeCombatRead_21341))?.CustomInit();
        }

        public void AttackEffect(BattleChar hit, SkillParticle SP, int DMG, bool Cri)
        {
            if (SP.SkillData != MySkill) return;
            if (!Cri) return;
            BChar.DrawCharacterSkill(
                BChar.PrepareRandomSkill(SkillKeys, new KamiyoSkillChangeParameters()));
        }

        public override void Init()
        {
            OnePassive = true;
        }
    }
}