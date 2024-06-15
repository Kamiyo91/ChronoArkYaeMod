namespace YaeMod21341
{
    public class SkillEn_Yae21341_0 : Skill_Extended, IP_DamageChange
    {
        public int DamageChange(Skill SkillD, BattleChar Target, int Damage, ref bool Cri, bool View)
        {
            if (SkillD != MySkill) return Damage;
            if (Damage <= 0) return Damage;
            var healAmount = Misc.PerToNum(Damage + 5, 25f);
            if (healAmount >= 1) BChar.Heal(BChar, healAmount, false);
            return Damage + 5;
        }
    }
}