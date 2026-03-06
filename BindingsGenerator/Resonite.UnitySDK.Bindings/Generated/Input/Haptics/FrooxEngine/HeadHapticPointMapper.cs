
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HeadHapticPointMapper
// Generated on: pátek 6. března 2026 14:18:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HeadHapticPointMapper")]
public partial class HeadHapticPointMapper : global::FrooxEngine.HapticPointMapper

{
    public UnityEngine.Vector3 HeadSize { get => HeadSize_Element.Data; set => HeadSize_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HeadSize_Element = new();
public UnityEngine.Vector3 HeadCenter { get => HeadCenter_Element.Data; set => HeadCenter_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> HeadCenter_Element = new();
public global::FrooxEngine.Slot _debugVisual { get => _debugVisual_Element.Data; set => _debugVisual_Element.Data = value; }
public Reference<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _debugVisual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HeadSize", HeadSize_Element.ToLinkField(context));
members.Add("HeadCenter", HeadCenter_Element.ToLinkField(context));
members.Add("_debugVisual", _debugVisual_Element.ToLinkReference(context));
}

}
}
