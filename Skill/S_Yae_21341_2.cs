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
            BattleSystem.instance.AllyTeam.AP += 1;
        }
    }
}