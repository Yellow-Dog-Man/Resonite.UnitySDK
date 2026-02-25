
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TransferGrabbable
// Generated on: středa 25. února 2026 16:14:43
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
    public global::System.Boolean PasteOnGrab;
public global::FrooxEngine.FresnelMaterial _indicatorMaterial;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("PasteOnGrab", PasteOnGrab.ToResoniteLinkField());
members.Add("_indicatorMaterial", _indicatorMaterial.ToResoniteReference(context));
}

}
}
