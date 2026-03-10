using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ChangeIntoSwimsuit
{
    public class ActionCommands
    {
        public static void Initialize(IModHelper helper)
        {
            GameLocation.RegisterTileAction("ChangeIntoSwimsuit", ChangeIntoSwimsuitAction);
            GameLocation.RegisterTileAction("ChangeOutOfSwimsuit", ChangeOutOfSwimsuitAction);
        }

        private static bool ChangeIntoSwimsuitAction(GameLocation location, string[] args, Farmer player, Microsoft.Xna.Framework.Point point)
        {
            player.changeIntoSwimsuit();
            return true;
        }

        private static bool ChangeOutOfSwimsuitAction(GameLocation location, string[] args, Farmer player, Microsoft.Xna.Framework.Point point)
        {
            player.changeOutOfSwimSuit();
            return true;
        }
    }
}
