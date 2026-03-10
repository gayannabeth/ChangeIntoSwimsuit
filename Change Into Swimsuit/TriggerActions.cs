using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Framework.ModLoading.Rewriters.StardewValley_1_6;
using StardewModdingAPI.Utilities;
using StardewValley;
using StardewValley.Delegates;
using StardewValley.Triggers;

namespace Change_Into_Swimsuit
{
    public class TriggerActions
    {
        public static void Initialize(IModHelper helper)
        {
            StardewValley.Triggers.TriggerActionManager.RegisterAction("ChangeIntoSwimsuit", ChangeIntoSwimsuitAction);
            StardewValley.Triggers.TriggerActionManager.RegisterAction("ChangeOutOfSwimsuit", ChangeOutOfSwimsuitAction);
            StardewValley.Triggers.TriggerActionManager.RegisterAction("StopSwimming", StopSwimmingAction);
            StardewValley.Triggers.TriggerActionManager.RegisterAction("StartSwimming", StartSwimmingAction);
        }

        private static bool ChangeIntoSwimsuitAction(string[] args, TriggerActionContext context, out string error)
        {
            Game1.player.changeIntoSwimsuit();
            error = "";
            return true;
        }

        private static bool ChangeOutOfSwimsuitAction(string[] args, TriggerActionContext context, out string error)
        {
            Game1.player.changeOutOfSwimSuit();
            error = "";
            return true;
        }

        private static bool StopSwimmingAction(string[] args, TriggerActionContext context, out string error)
        {
            if (!ArgUtility.TryGet(args, 1, out string actorId, out error, allowBlank: false, name: "actor"))
                return false;

            if (actorId.Equals("farmer"))
            {
                Game1.player.swimming.Set(false);
                return true;
            }

            NPC npc = Game1.getCharacterFromName(actorId, mustBeVillager: false, includeEventActors: true);
            if (npc == null)
            {
                error = "No actor named " + actorId + " found!";
                return false;
            }
            else
            {
                npc.swimming.Set(false);
                return true;
            }
        }

        private static bool StartSwimmingAction(string[] args, TriggerActionContext context, out string error)
        {
            if (!ArgUtility.TryGet(args, 1, out string actorId, out error, allowBlank: false, name: "actor"))
                return false;

            if (actorId.Equals("farmer"))
            {
                Game1.player.swimming.Set(true);
                return true;
            }

            NPC npc = Game1.getCharacterFromName(actorId, mustBeVillager: false, includeEventActors: true);
            if (npc == null)
            {
                error = "No actor named " + actorId + " found!";
                return false;
            }
            else
            {
                npc.swimming.Set(true);
                return true;
            }
        }
    }
}
