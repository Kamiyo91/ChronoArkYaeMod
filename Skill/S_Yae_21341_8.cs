using System.Collections.Generic;
using _1ChronoArkKamiyoUtil;
using GameDataEditor;

namespace YaeMod21341
{
    /// <summary>
    ///     Respite
    /// </summary>
    public class S_Yae_21341_8 : Skill_Extended
    {
        public override void SkillUseSingle(Skill SkillD, List<BattleChar> Targets)
        {
            BattleSystem.instance.AllyTeam.AP += 1;
            if (BChar.BuffFind(GDEItemKeys.Buff_B_Neardeath))
            {
                BChar.HP = 1;
                BChar.Recovery = BChar.GetStat.maxhp;
            }

            (BChar.Info.Passive as P_Yae21341)?.ResetCounter();
            (BChar.Info.Passive as P_Yae21341)?.ResetPainEscapeCount();
            (BChar.Info.Passive as P_Yae21341)?.ResetDeathResist();
            KamiyoUtil.AddShieldValue(BChar, nameof(B_YaeRespiteShield_21341), (int)(BChar.GetStat.maxhp * 0.5f));
        }
    }
}