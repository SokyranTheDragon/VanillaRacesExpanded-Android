﻿using RimWorld;
using Verse;

namespace VREAndroids
{

    [DefOf]
    public static class VREA_DefOf
    {
        public static AndroidSettings VREA_AndroidSettings;
        public static NeedDef VREA_MemorySpace;
        public static NeedDef VREA_ReactorPower;

        public static GeneDef VREA_Power, VREA_MemoryProcessing, VREA_MentalBreaksDisabled, VREA_Uninspired, VREA_NoSkillGain, VREA_SyntheticBody, VREA_ComponentOverheating, 
            VREA_ComponentFreezing, VREA_SyntheticImmunity, VREA_NeutroCirculation, VREA_JoyDisabled, VREA_PsychologyDisabled;

        public static NeedDef VREA_FoodSuppressed;
        public static MentalStateDef VREA_Reformatting;
        public static JobDef VREA_FreeMemorySpace;
        public static ThingDef VREA_UnfinishedHealthItemAndroid;
        public static ResearchProjectDef VREA_AndroidCreation;
        public static ThingCategoryDef VREA_BodyPartsAndroid;
        public static ThingDef VREA_AndroidPartWorkbench;
        public static EffecterDef Smith;
        public static EffecterDef ButcherMechanoid;
        public static SoundDef Recipe_Smith;
        public static SoundDef Recipe_ButcherCorpseMechanoid;
        public static HediffDef VREA_Reactor;
        public static HediffDef VREA_NeutroLoss;
        public static ThingDef VREA_NeutroCasket;
        public static FleshTypeDef VREA_AndroidFlesh;
        public static ThingDef VREA_Filth_Neutroamine;
        public static HediffDef VREA_Freezing;
        public static DamageDef VREA_Freeze;
        public static HediffDef VREA_Overheating;
        public static StatDef VREA_MemorySpaceDrainMultiplier;
        public static JobDef VREA_TendAndroid;
        public static SoundDef Interact_ConstructMetal;
        public static MentalStateDef VREA_SolarFlared;

        public static GeneCategoryDef Cosmetic;
        public static GeneCategoryDef Cosmetic_Skin;
        public static GeneCategoryDef Cosmetic_Hair;
        public static GeneCategoryDef Beauty;
        public static GeneCategoryDef Cosmetic_Body;

        public static GeneCategoryDef VREA_Hardware;
        public static GeneCategoryDef VREA_Subroutine;

        public static RecipeDef VREA_RemoveArtificalPart;
        public static GeneDef VREA_EMPVulnerability;
        public static DamageDef VREA_EMPBurn;
        public static HediffDef VREA_ElectromagneticShock;
        public static StatCategoryDef VREA_Android;
        public static GeneDef VREA_SlowRAM, VREA_FastRAM;
        public static AndroidGeneTemplateDef VREA_AptitudeIncapable;
        public static ThingDef VREA_SubcorePolyanalyzer;
        public static ThingDef VREA_SubcorePolyanalyzer_North, VREA_SubcorePolyanalyzer_South, VREA_SubcorePolyanalyzer_East, VREA_SubcorePolyanalyzer_West;
        public static JobDef VREA_CreateAndroid;
        public static ThingDef VREA_AndroidCreationStation;
        public static ThingDef VREA_UnfinishedAndroid;
        public static PawnKindDef VREA_AndroidBasic;
        public static ThingDef VREA_PersonaSubcore;
        public static RulePackDef VREA_AndroidTypeNameMaker;
        public static ThingDef VREA_AndroidBehavioristStation;
        public static JobDef VREA_ModifyAndroid;
        public static EffecterDef VREA_ModifyingAndroidEffecter;
    }
}
