﻿using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace VREAndroids
{
    [HarmonyPatch(typeof(HealthCardUtility), "DrawOverviewTab")]
    public static class HealthCardUtility_DrawOverviewTab_Patch
    {
        public static bool Prefix(ref float __result, Rect leftRect, Pawn pawn, float curY)
        {
            if (pawn.IsAndroid())
            {
                __result = DrawOverviewTabAndroid(leftRect, pawn, curY);
                return false;
            }
            return true;
        }

        private static float DrawOverviewTabAndroid(Rect leftRect, Pawn pawn, float curY)
        {
            curY += 4f;
            Text.Font = GameFont.Tiny;
            Text.Anchor = TextAnchor.UpperLeft;
            GUI.color = new Color(0.9f, 0.9f, 0.9f);
            string str = ((pawn.gender == Gender.None) ? ((string)"PawnSummary".Translate(pawn.Named("PAWN"))) : ((string)"PawnSummaryWithGender".Translate(pawn.Named("PAWN"))));
            Rect rect = new Rect(0f, curY, leftRect.width, 34f);
            Widgets.Label(rect, str.CapitalizeFirst());
            if (Mouse.IsOver(rect))
            {
                TooltipHandler.TipRegion(rect, () => pawn.ageTracker.AgeTooltipString, 73412);
                Widgets.DrawHighlight(rect);
            }
            GUI.color = Color.white;
            curY += 34f;
            Text.Font = GameFont.Small;
            if (!pawn.Dead)
            {
                IEnumerable<PawnCapacityDef> source = (pawn.def.race.Humanlike ? DefDatabase<PawnCapacityDef>.AllDefs.Where((PawnCapacityDef x) => x.showOnHumanlikes) : ((!pawn.def.race.Animal) ? DefDatabase<PawnCapacityDef>.AllDefs.Where((PawnCapacityDef x) => x.showOnMechanoids) : DefDatabase<PawnCapacityDef>.AllDefs.Where((PawnCapacityDef x) => x.showOnAnimals)));
                {
                    foreach (PawnCapacityDef item in source.OrderBy((PawnCapacityDef act) => act.listOrder))
                    {
                        if (PawnCapacityUtility.BodyCanEverDoCapacity(pawn.RaceProps.body, item))
                        {
                            PawnCapacityDef activityLocal = item;
                            Pair<string, Color> efficiencyLabel = HealthCardUtility.GetEfficiencyLabel(pawn, item);
                            Func<string> textGetter = () => (!pawn.Dead) ? HealthCardUtility.GetPawnCapacityTip(pawn, activityLocal) : "";
                            curY = HealthCardUtility.DrawLeftRow(leftRect, curY, item.GetLabelFor(pawn.RaceProps.IsFlesh, pawn.RaceProps.Humanlike).CapitalizeFirst(), efficiencyLabel.First, efficiencyLabel.Second, new TipSignal(textGetter, pawn.thingIDNumber ^ item.index));
                        }
                    }
                    return curY;
                }
            }
            return curY;
        }
    }
}
