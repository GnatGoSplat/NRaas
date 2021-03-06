﻿using NRaas.CommonSpace.Booters;
using NRaas.CommonSpace.Helpers;
using NRaas.VectorSpace.Booters;
using NRaas.VectorSpace.Tests;
using Sims3.Gameplay.Actors;
using Sims3.Gameplay.ActorSystems;
using Sims3.Gameplay.CAS;
using Sims3.Gameplay.EventSystem;
using Sims3.Gameplay.Utilities;
using Sims3.SimIFace;
using System.Collections.Generic;

namespace NRaas.VectorSpace.Resistances
{
    public class MoodletResistance : ResistanceBooter.Data
    {
        public MoodletResistance(XmlDbRow row)
            : base(row, new MoodletTest(row))
        { }
    }
}
