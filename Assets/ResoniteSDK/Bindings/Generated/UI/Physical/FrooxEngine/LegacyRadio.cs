
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadio
// Generated on: sobota 14. února 2026 8:58:40
// Resonite version: 2026.2.14.493
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyRadio")]
public partial class LegacyRadio : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.IRadio, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsEnabled;
public global::System.Single Radius;
public UnityEngine.ColorX Color;
public global::System.Boolean Selected;
public global::FrooxEngine.IField<global::System.Single> _colliderRadius;
public global::FrooxEngine.IcoSphereMesh _icosphere;
public global::FrooxEngine.PBS_RimMetallic _material;
public global::FrooxEngine.LegacyRadioGroup _group;
public global::System.Int32 _orderNumber;

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Selected", Selected.ToResoniteLinkField());
members.Add("_colliderRadius", _colliderRadius.ToResoniteReference(context));
members.Add("_icosphere", _icosphere.ToResoniteReference(context));
members.Add("_material", _material.ToResoniteReference(context));
members.Add("_group", _group.ToResoniteReference(context));
members.Add("_orderNumber", _orderNumber.ToResoniteLinkField());
}

}
}
