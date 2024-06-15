namespace YaeMod21341
{
    /// <summary>
    ///     Bloodlust
    /// </summary>
    public class S_Yae_21341_3 : Skill_Extended, IP_SkillUse_Target
    {
        public void AttackEffect(BattleChar hit, SkillParticle SP, int DMG, bool Cri)
        {
            if (SP.SkillData != MySkill) return;
            BattleSystem.instance.AllyTeam.Draw(1);
        }
    }
}