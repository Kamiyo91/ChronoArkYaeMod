using System.Collections.Generic;
using _1ChronoArkKamiyoUtil;
using ChronoArkMod.Plugin;

namespace YaeMod21341
{
    public class YaeMod21341_Plugin : ChronoArkPlugin
    {
        public override void Dispose()
        {
        }

        public override void Initialize()
        {
            KamiyoGlobalModParameters.DialogueTrees.TryAdd("Yae21341", new List<DialogueFinder>());
        }
    }
}