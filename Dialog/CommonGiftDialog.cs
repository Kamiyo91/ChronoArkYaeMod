//using System;
//using System.Collections.Generic;
//using ChronoArkMod;
//using ChronoArkMod.DialogueCreate;
//using UnityEngine;

//namespace YaeMod21341
//{
//    public class CommonGiftDialog : DialogueCreator
//    {
//        public override Type FirstNodeCreatorType => typeof(CommonGiftDialogN1);
//    }

//    public class CommonGiftDialogN1 : DialogueNodeCreator
//    {
//        public override Type NextDialogueNodeCreatorType => typeof(TestN2);

//        public override DialogueNodeParameter SetDialogueNodeParameter()
//        {
//            var assetinfo = ModManager.getModInfo(ModParameters.ModId).assetInfo;
//            return new DialogueNodeParameter
//            {
//                Text = ModLocalization.Yae21341GeneralGift,
//                Standing_Path = assetinfo.ChangeSpritePivot(assetinfo.ImageFromFile(ModParameters.YaeBaseImagePath),
//                    new Vector2(0.5f, 0.2f))
//            };
//        }
//    }

//    public class TestN2 : DialogueNodeCreator
//    {
//        public override IEnumerable<Type> OptionCreatorTypes => new List<Type> { typeof(TestN2O1), typeof(TestN2O2) };

//        public override DialogueNodeParameter SetDialogueNodeParameter()
//        {
//            return new DialogueNodeParameter
//            {
//                Text = "*CharacterName\nSentence2",

//                StandingBefore = true
//            };
//        }
//    }

//    public class TestN2O1 : DialogueNodeOptionCreator
//    {
//        public override Type TargetDialogueNodeCreatorType => typeof(TestN3);

//        public override DialogueNodeOptionParameter SetDialogueNodeOptionParameter()
//        {
//            return new DialogueNodeOptionParameter { Text = "Choice1£ºTo Sentence3" };
//        }
//    }

//    public class TestN2O2 : DialogueNodeOptionCreator
//    {
//        public override DialogueNodeOptionParameter SetDialogueNodeOptionParameter()
//        {
//            return new DialogueNodeOptionParameter { Text = "Choice2£ºEnd" };
//        }
//    }

//    public class TestN3 : DialogueNodeCreator
//    {
//        public override DialogueNodeParameter SetDialogueNodeParameter()
//        {
//            return new DialogueNodeParameter { Text = "*CharacterName\nSentence3" };
//        }
//    }
//}