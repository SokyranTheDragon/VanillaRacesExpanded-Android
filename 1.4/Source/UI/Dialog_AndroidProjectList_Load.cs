﻿using RimWorld;
using System;
using Verse;

namespace VREAndroids
{
    public class Dialog_AndroidProjectList_Load : Dialog_AndroidProjectList
    {
        private Action<CustomXenotype> xenotypeReturner;
        public Dialog_AndroidProjectList_Load(Action<CustomXenotype> xenotypeReturner)
        {
            this.xenotypeReturner = xenotypeReturner;
            interactButLabel = "LoadGameButton".Translate();
            deleteTipKey = "DeleteThisXenotype";
        }

        public override void DoFileInteraction(string fileName)
        {
            string filePath = Window_AndroidCreation.AbsFilePathForAndroidProject(fileName);
            PreLoadUtility.CheckVersionAndLoad(filePath, ScribeMetaHeaderUtility.ScribeHeaderMode.Xenotype, delegate
            {
                if (Window_AndroidCreation.TryLoadAndroidProject(filePath, out var xenotype))
                {
                    xenotypeReturner(xenotype);
                }
                Close();
            });
        }
    }
}
