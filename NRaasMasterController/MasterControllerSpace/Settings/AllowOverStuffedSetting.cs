﻿using NRaas.CommonSpace.Options;
using Sims3.Gameplay.Abstracts;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.Autonomy;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.Interactions;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace NRaas.MasterControllerSpace.Settings
{
    public class AllowOverStuffedSetting : BooleanSettingOption<GameObject>, ISettingOption
    {
        protected override bool Value
        {
            get
            {
                return NRaas.MasterController.Settings.mAllowOverStuffed;
            }
            set
            {
                NRaas.MasterController.Settings.mAllowOverStuffed = value;
            }
        }

        public override string GetTitlePrefix()
        {
            return "AllowOverStuffedSetting";
        }

        public override ITitlePrefixOption ParentListingOption
        {
            get { return new SimListingOption(); }
        }
    }
}
