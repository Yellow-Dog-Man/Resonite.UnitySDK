
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLoadProgress
// Generated on: pátek 13. února 2026 5:52:38
// Resonite version: 2026.2.13.254
// Resonite Link Version: 0.7.0.0
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("_visual", new ResoniteLink.Reference() { });
members.Add("ProgressIndicator", new ResoniteLink.Reference() { });
}

}
}
