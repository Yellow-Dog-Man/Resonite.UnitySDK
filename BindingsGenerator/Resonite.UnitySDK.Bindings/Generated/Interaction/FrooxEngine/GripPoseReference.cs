
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.GripPoseReference
// Generated on: čtvrtek 26. února 2026 15:08:00
// Resonite version: 2026.2.26.828
// Resonite Link Version: 0.9.3.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.GripPoseReference")]
public partial class GripPoseReference : global::FrooxEngine.Component

{
    public global::Renderite.Shared.Chirality HandSide { get => HandSide_Element.Data; set => HandSide_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::Renderite.Shared.Chirality>, global::Renderite.Shared.Chirality> HandSide_Element = new();
public UnityEngine.Vector3 _rootPos { get => _rootPos_Element.Data; set => _rootPos_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> _rootPos_Element = new();
public global::FrooxEngine.Slot TipReference { get => TipReference_Element.Data; set => TipReference_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> TipReference_Element = new();
public global::System.Boolean ShowVisual { get => ShowVisual_Element.Data; set => ShowVisual_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowVisual_Element = new();
public global::System.Boolean DisableSlider { get => DisableSlider_Element.Data; set => DisableSlider_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> DisableSlider_Element = new();
public global::FrooxEngine.Slot _activeVisual { get => _activeVisual_Element.Data; set => _activeVisual_Element.Data = value; }
public Reference<global::FrooxEngine.CleanupRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _activeVisual_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("HandSide", HandSide_Element.ToLinkField(context));
members.Add("_rootPos", _rootPos_Element.ToLinkField(context));
members.Add("TipReference", TipReference_Element.ToLinkReference(context));
members.Add("ShowVisual", ShowVisual_Element.ToLinkField(context));
members.Add("DisableSlider", DisableSlider_Element.ToLinkField(context));
members.Add("_activeVisual", _activeVisual_Element.ToLinkReference(context));
}

}
}
