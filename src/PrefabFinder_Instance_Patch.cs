using HarmonyLib;
using RST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace ReinforcedPointDefense
{
    [HarmonyPatch(typeof(PrefabFinder), nameof(PrefabFinder.Instance), MethodType.Getter)]
    public static class PrefabFinder_Instance_Patch
    {
        private static bool IsInited = false;


        /// <summary>
        /// Copies the list of allowed items for a regular weapon slot to the reinforced weapon slot.
        /// </summary>
        public static void Postfix()
        {

            if (IsInited) return;

            IsInited = true;

            PrefabFinder finder = PrefabFinder.instance;
            if (finder == null)
            {
                //this should never happen
                Plugin.Log.LogError("Prefab finder's instance is null");
                return;
            }

            ModuleSlot weaponSlot = finder.FindById(1837849614).GetComponent<RST.ModuleSlot>();
            ModuleSlot reinforcedWeaponSlot = finder.FindById(1972530845).GetComponent<RST.ModuleSlot>();

            if(weaponSlot == null || reinforcedWeaponSlot == null)
            {
                Plugin.Log.LogError("Weapon slots were not found");
                return;
            }

            reinforcedWeaponSlot.CraftableModulePrefabs = weaponSlot.CraftableModulePrefabs;
            reinforcedWeaponSlot.craftableModulePrefabRefs = weaponSlot.craftableModulePrefabRefs;
            reinforcedWeaponSlot.acceptedModuleTypes = weaponSlot.acceptedModuleTypes;
        }
    }

}
