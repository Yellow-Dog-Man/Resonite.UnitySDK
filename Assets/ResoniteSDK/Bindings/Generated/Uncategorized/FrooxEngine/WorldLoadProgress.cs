
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLoadProgress
// Generated on: čtvrtek 19. února 2026 8:00:32
// Resonite version: 2026.2.19.471
// Resonite Link Version: 1.0.0.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.WorldLoadProgress")]
public partial class WorldLoadProgress : global::FrooxEngine.Component

{
    public global::FrooxEngine.Slot _visual;
public global::FrooxEngine.WorldLoadingProgressInterface ProgressIndicator;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_visual", _visual.ToResoniteReference(context));
members.Add("ProgressIndicator", ProgressIndicator.ToResoniteReference(context));
}

}
}
