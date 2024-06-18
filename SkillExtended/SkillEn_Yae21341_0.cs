using System.Collections.Generic;

namespace YaeMod21341
{
    public class SkillEn_Yae21341_0 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            SkillBasePlus.Target_BaseDMG = 5;
        }
        public override bool CanSkillEnforce(Skill MainSkill)
        {
            return !MainSkill.IsHeal;
        }
        public override void AttackEffectSingle(BattleChar hit, SkillParticle SP, int DMG, int Heal)
        {
            if (DMG <= 0) return;
            var healAmount = Misc.PerToNum(DMG + 5, 25f);
            if (healAmount >= 1) BChar.Heal(BChar, healAmount, false);
        }
    }
}