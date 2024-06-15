using GameDataEditor;

namespace YaeMod21341
{
    /// <summary>
    ///     Blade Draw
    /// </summary>
    public class S_Yae_21341_2 : Skill_Extended, IP_SkillUse_Target
    {
        public void AttackEffect(BattleChar hit, SkillParticle SP, int DMG, bool Cri)
        {
            if (SP.SkillData != MySkill || !Cri) return;
            hit.BuffAdd(GDEItemKeys.Buff_B_Public_33_T, SP.UseStatus);
        }
    }
}