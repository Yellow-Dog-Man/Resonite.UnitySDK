
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TransferGrabbable
// Generated on: čtvrtek 26. února 2026 10:04:48
// Resonite version: 2026.2.25.455
// Resonite Link Version: 0.9.2.0
// -----------------------------------------------------------------------------

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FrooxEngine
{
    [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TransferGrabbable")]
public partial class TransferGrabbable : global::FrooxEngine.Component, global::FrooxEngine.IGrabbable, global::FrooxEngine.IInteractionTarget

{
    public global::System.Boolean PasteOnGrab { get => PasteOnGrab_Element.Data; set => PasteOnGrab_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PasteOnGrab_Element = new();
public global::FrooxEngine.FresnelMaterial _indicatorMaterial { get => _indicatorMaterial_Element.Data; set => _indicatorMaterial_Element.Data = value; }
public Field<global::FrooxEngine.SyncRef<global::FrooxEngine.FresnelMaterial>, global::FrooxEngine.FresnelMaterial> _indicatorMaterial_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PasteOnGrab", PasteOnGrab_Element.Data.ToResoniteLinkField());
members.Add("_indicatorMaterial", _indicatorMaterial_Element.Data.ToResoniteReference(context));
}

}
}
