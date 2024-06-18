namespace YaeMod21341
{
    public class B_YaeLifeSteal_21341 : Buff, IP_DamageChange, IP_SkillUse_Target
    {
        public int DamageChange(Skill SkillD, BattleChar Target, int Damage, ref bool Cri, bool View)
        {
            if (BChar.MyTeam == Target.MyTeam) return Damage;
            return Damage + 5;
        }

        public void AttackEffect(BattleChar hit, SkillParticle SP, int DMG, bool Cri)
        {
            if (DMG <= 0) return;
            var healAmount = Misc.PerToNum(DMG, 25f);
            if (healAmount >= 1) BChar.Heal(BChar, healAmount, false);
        }
    }
}