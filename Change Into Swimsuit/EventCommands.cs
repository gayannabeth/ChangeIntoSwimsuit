using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace ChangeIntoSwimsuit
{
    public class EventCommands
    {
        public static void Initialize(IModHelper helper)
        {
            StardewValley.Event.RegisterCommand("changeIntoSwimsuit", ChangeIntoSwimsuitCommand);
            StardewValley.Event.RegisterCommand("changeOutOfSwimsuit", ChangeOutOfSwimsuitCommand);
        }

        private static void ChangeIntoSwimsuitCommand(Event @event, string[] args, EventContext context)
        {
            Game1.player.changeIntoSwimsuit();
            @event.currentCommand++;
        }

        private static void ChangeOutOfSwimsuitCommand(Event @event, string[] args, EventContext context)
        {
            Game1.player.changeOutOfSwimSuit();
            @event.currentCommand++;
        }
    }
}
