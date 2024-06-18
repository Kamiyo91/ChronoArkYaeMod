using ChronoArkMod;
using ChronoArkMod.DialogueCreate;
using ChronoArkMod.ModData;
using ChronoArkMod.Template;

namespace YaeMod21341
{
    public class YaeMod21341_ModDefinition : ModDefinition
    {
    }

    //public class YaeCharacter : CustomCharacterGDE<YaeMod21341_ModDefinition>
    //{
    //    public override ModGDEInfo.LoadingType GetLoadingType()
    //    {
    //        return ModGDEInfo.LoadingType.Add;
    //    }

    //    public override void SetValue()
    //    {
    //        Dialogue_NomalGiftTalk = CreateDialogPath<CommonGiftDialog>();
    //    }

    //    public string CreateDialogPath<T>() where T : DialogueCreator
    //    {
    //        var dialogue = DialogueCreator.CreateDialogueTree<T>();
    //        return modInfo.assetInfo.ConstructObjectByCode(dialogue);
    //    }

    //    public override string Key()
    //    {
    //        return ModParameters.YaeId;
    //    }
    //}
}