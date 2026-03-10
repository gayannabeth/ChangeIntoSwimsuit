using System;
using System.Collections.Generic;
using Change_Into_Swimsuit;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ChangeIntoSwimsuit
{
    internal sealed class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            EventCommands.Initialize(helper);
            ActionCommands.Initialize(helper);
            TriggerActions.Initialize(helper);
        }
    }
}
