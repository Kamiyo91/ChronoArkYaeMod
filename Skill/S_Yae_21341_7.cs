using System.Collections.Generic;
using _1ChronoArkKamiyoUtil;

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
            KamiyoUtil.GetBuff<B_YaeCombatRead_21341>(BChar, nameof(B_YaeCombatRead_21341))?.CustomInit();
            if (!Cri) return;
            KamiyoUtil.DrawCharacterSkill(BChar,
                KamiyoUtil.PrepareRandomSkill(BChar, SkillKeys, new KamiyoSkillChangeParameters()));
        }
    }
}