
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.VolumePlaneSlicer
// Generated on: čtvrtek 26. února 2026 15:09:14
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.VolumePlaneSlicer")]
public partial class VolumePlaneSlicer : global::FrooxEngine.Component, global::FrooxEngine.ITouchable, global::FrooxEngine.IGrabEventReceiver

{
    public global::FrooxEngine.VolumePlaneMode Mode { get => Mode_Element.Data; set => Mode_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::FrooxEngine.VolumePlaneMode>, global::FrooxEngine.VolumePlaneMode> Mode_Element = new();
public UnityEngine.ColorX HighlightColor { get => HighlightColor_Element.Data; set => HighlightColor_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> HighlightColor_Element = new();
public global::System.Single HighlightRange { get => HighlightRange_Element.Data; set => HighlightRange_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> HighlightRange_Element = new();
public global::FrooxEngine.ColorDialogInterface _colorDialog { get => _colorDialog_Element.Data; set => _colorDialog_Element.Data = value; }
public Reference<global::FrooxEngine.SlotCleanupRef<global::FrooxEngine.ColorDialogInterface>, global::FrooxEngine.ColorDialogInterface> _colorDialog_Element = new();
public global::FrooxEngine.Slot _grabGrid { get => _grabGrid_Element.Data; set => _grabGrid_Element.Data = value; }
public Reference<global::FrooxEngine.SyncRef<global::FrooxEngine.Slot>, global::FrooxEngine.Slot> _grabGrid_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Mode", Mode_Element.ToLinkField(context));
members.Add("HighlightColor", HighlightColor_Element.ToLinkField(context));
members.Add("HighlightRange", HighlightRange_Element.ToLinkField(context));
members.Add("_colorDialog", _colorDialog_Element.ToLinkReference(context));
members.Add("_grabGrid", _grabGrid_Element.ToLinkReference(context));
}

}
}
