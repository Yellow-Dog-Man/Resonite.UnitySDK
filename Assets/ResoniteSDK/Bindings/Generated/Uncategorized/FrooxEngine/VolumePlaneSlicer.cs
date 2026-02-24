
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumePlaneSlicer
// Generated on: úterý 24. února 2026 18:20:28
// Resonite version: 2026.2.24.1074
// Resonite Link Version: 0.9.1.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumePlaneSlicer")]
public partial class VolumePlaneSlicer : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IGrabEventReceiver

{
    public global::FrooxEngine.VolumePlaneMode Mode;
public UnityEngine.ColorX HighlightColor;
public global::System.Single HighlightRange;
public global::FrooxEngine.ColorDialogInterface _colorDialog;
public global::FrooxEngine.Slot _grabGrid;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode.ToResoniteLinkField());
members.Add("HighlightColor", HighlightColor.ToResoniteLinkField());
members.Add("HighlightRange", HighlightRange.ToResoniteLinkField());
members.Add("_colorDialog", _colorDialog.ToResoniteReference(context));
members.Add("_grabGrid", _grabGrid.ToResoniteReference(context));
}

}
}
