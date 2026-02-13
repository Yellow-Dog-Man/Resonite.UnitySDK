
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadio
// Generated on: pátek 13. února 2026 23:23:11
// Resonite version: 2026.2.12.359
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

public override void CollectMembers(System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members)
{
    base.CollectMembers(members);
members.Add("IsEnabled", IsEnabled.ToResoniteLinkField());
members.Add("Radius", Radius.ToResoniteLinkField());
members.Add("Color", Color.ToResoniteLinkField());
members.Add("Selected", Selected.ToResoniteLinkField());
members.Add("_colliderRadius", new ResoniteLink.Reference() { });
members.Add("_icosphere", new ResoniteLink.Reference() { });
members.Add("_material", new ResoniteLink.Reference() { });
members.Add("_group", new ResoniteLink.Reference() { });
members.Add("_orderNumber", _orderNumber.ToResoniteLinkField());
}

}
}
