using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(Challenge5x5.Main), "ChallengeThreeByThree", "0.0.1", "Fur")]
[assembly: MelonGame("TheJaspel", "Backpack Hero")]

namespace Challenge5x5
{
    public class Main : MelonMod
    {

    }
}

public class ChallengeFiveByFive : MelonMod
{
    //Redefines Backpack tile gain to be flatter and more difficult early game
    [HarmonyPatch(typeof(Player), nameof(Player.AddExperience))]
    class TileLevelUpCountPatch
    {
        static bool Prefix(ref Player __instance)
        {
            MelonLogger.Msg("Player.Start");
            __instance.gridsToGain = new int[]
            {
                        0, 0, 12, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
            };

            return true;
        }
    }
}
