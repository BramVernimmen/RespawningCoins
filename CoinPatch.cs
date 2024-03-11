using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace RespawningCoins
{
    [HarmonyPatch(typeof(Coin), "get_AlwaysRespawn")]
    public class CoinPatch
    {
        [HarmonyPrefix]
        public static bool AlwaysRespawnPreFix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
