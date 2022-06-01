using HarmonyLib;
using SideLoader;

namespace Dszecore.Patches {

    [HarmonyPatch(typeof(StatusEffect), nameof(StatusEffect.Stop))]
    public class StatusEffect_Stop {
        [HarmonyPrefix]
        public static void Prefix(StatusEffect __instance) {
            __instance.SynchronizeEffects(EffectSynchronizer.EffectCategories.Reference);
		    __instance.StopAllEffects(EffectSynchronizer.EffectCategories.Reference, __instance.m_affectedCharacter);
        }
    }

}