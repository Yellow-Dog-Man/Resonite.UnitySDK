
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.WorldLoadProgress
// Generated on: pátek 6. března 2026 14:19:11
// Resonite version: 2026.3.5.946
// Resonite Link Version: 0.11.0.0
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
    public global::FrooxEngine.Slot _visual { get => _visual_Element.Data; set => _visual_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _visual_Element = new();
public global::FrooxEngine.WorldLoadingProgressInterface ProgressIndicator { get => ProgressIndicator_Element.Data; set => ProgressIndicator_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.WorldLoadingProgressInterface>, global::FrooxEngine.WorldLoadingProgressInterface> ProgressIndicator_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("_visual", _visual_Element.ToLinkReference(context));
members.Add("ProgressIndicator", ProgressIndicator_Element.ToLinkReference(context));
}

}
}
