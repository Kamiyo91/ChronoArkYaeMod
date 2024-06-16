namespace YaeMod21341
{
    /// <summary>
    ///     Red Moon
    /// </summary>
    public class S_Yae_21341_9_0 : Skill_Extended
    {
        public override bool TargetSelectExcept(BattleChar ExceptTarget)
        {
            return ExceptTarget.GetBuffs(BattleChar.GETBUFFTYPE.DOT, false).Count == 0;
        }
    }
}