using ChronoArkMod.DialogueCreate;
using ChronoArkMod;
using System;
using UnityEngine;
using YaeMod21341;

namespace Dialog
{
    //public class CommonGiftDialog : DialogueCreator
    //{
    //    public override Type FirstNodeCreatorType => typeof(CommonGiftDialogN1);
    //}
    //public class CommonGiftDialogN1 : DialogueNodeCreator
    //{
    //    public override DialogueNodeParameter SetDialogueNodeParameter()
    //    {
    //        var assetinfo = ModManager.getModInfo(ModParameters.ModId).assetInfo;
    //        return new DialogueNodeParameter
    //        {
    //            Text = ModLocalization.Yae21341GeneralGift,
    //            Standing_Path = assetinfo.ChangeSpritePivot(assetinfo.ImageFromFile(@"Yae21341\\Yae21341BattleChar.png"),new Vector2(0.5f,0.2f))
    //        };
    //    }
    //    public override Type NextDialogueNodeCreatorType => typeof(TestN2);
    //}
    //public class TestN2 : DialogueNodeCreator
    //{
    //    public override DialogueNodeParameter SetDialogueNodeParameter()
    //    {
    //        return new DialogueNodeParameter()
    //        {
    //            Text = "*CharacterName\nSentence2",

    //            StandingBefore = true
    //        };
    //    }
    //    public override IEnumerable<Type> OptionCreatorTypes => new List<Type>() { typeof(TestN2O1), typeof(TestN2O2) };
    //}
    //public class TestN2O1 : DialogueNodeOptionCreator
    //{
    //    public override DialogueNodeOptionParameter SetDialogueNodeOptionParameter()
    //    {
    //        return new DialogueNodeOptionParameter { Text = "Choice1£ºTo Sentence3" };
    //    }
    //    public override Type TargetDialogueNodeCreatorType => typeof(TestN3);
    //}
    //public class TestN2O2 : DialogueNodeOptionCreator
    //{
    //    public override DialogueNodeOptionParameter SetDialogueNodeOptionParameter()
    //    {
    //        return new DialogueNodeOptionParameter { Text = "Choice2£ºEnd" };
    //    }
    //}
    //public class TestN3 : DialogueNodeCreator
    //{
    //    public override DialogueNodeParameter SetDialogueNodeParameter()
    //    {
    //        return new DialogueNodeParameter { Text = "*CharacterName\nSentence3" };
    //    }
    //}
}
