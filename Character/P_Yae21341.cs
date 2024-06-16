using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace YaeMod21341
{
    /// <summary>
    ///     Yae
    /// </summary>
    public class P_Yae21341 : Passive_Char, IP_Kill, IP_PlayerTurn, IP_Hit, IP_PainDeathEscape, IP_BattleStart_Ones,
        IP_DeadResist
    {
        private static readonly List<string> SkillKeys = new List<string>
            { "S_Yae_21341_0", "S_Yae_21341_1", "S_Yae_21341_2", "S_Yae_21341_5" };

        private bool _counter;
        private bool _deadResist;
        private bool _painEscape;

        public void BattleStart(BattleSystem Ins)
        {
            BChar.Info.GetData.Text_MasterTarget = ModLocalization.ProgramMasterFinalYae21341;
            _painEscape = false;
            _deadResist = false;
        }

        public bool DeadResist()
        {
            if (_deadResist) return false;
            _deadResist = true;
            return true;
        }

        public void Hit(SkillParticle SP, int Dmg, bool Cri)
        {
            if (Dmg < 1 || SP.UseStatus.Info.Ally || _counter) return;
            _counter = true;
            var keyword = SkillKeys[Random.Range(0, SkillKeys.Count)];
            var skill = Skill.TempSkill(keyword, BChar, BChar.MyTeam);
            skill.AP = 0;
            skill.Counting = -99;
            skill.NotCount = true;
            skill.isExcept = true;
            BattleSystem.DelayInput(PassiveAttack(skill, SP.UseStatus));
        }

        public void KillEffect(SkillParticle SP)
        {
            BChar.Overload = 0;
        }

        public bool PainDeathEscape(BattleChar User, int Dmg, bool Cri, BattleChar Target)
        {
            if (_painEscape) return false;
            _painEscape = true;
            return true;
        }

        public void Turn()
        {
            _counter = false;
        }

        public IEnumerator PassiveAttack(Skill skill, BattleChar target)
        {
            yield return new WaitForSeconds(0.2f);
            if (BattleSystem.instance.EnemyList.Count != 0)
                yield return BattleSystem.instance.ForceAction(skill, target, false, false, true);
        }

        public override void Init()
        {
            OnePassive = true;
        }

        public void ResetCounter()
        {
            _counter = false;
        }

        public void ResetPainEscapeCount()
        {
            _painEscape = false;
        }

        public void ResetDeathResist()
        {
            _deadResist = false;
        }
    }
}