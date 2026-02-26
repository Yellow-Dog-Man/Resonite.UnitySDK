
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LegacyRadio
// Generated on: čtvrtek 26. února 2026 15:09:09
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LegacyRadio")]
public partial class LegacyRadio : global::FrooxEngine.LegacyUIElement, global::FrooxEngine.IRadio, global::FrooxEngine.ILegacyUIElement, global::FrooxEngine.ITouchable

{
    public global::System.Boolean IsEnabled { get => IsEnabled_Element.Data; set => IsEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> IsEnabled_Element = new();
public global::System.Single Radius { get => Radius_Element.Data; set => Radius_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Radius_Element = new();
public UnityEngine.ColorX Color { get => Color_Element.Data; set => Color_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.ColorX>, UnityEngine.ColorX> Color_Element = new();
public global::System.Boolean Selected { get => Selected_Element.Data; set => Selected_Element.Data = value; }
public Field<global::FrooxEngine.RawOutput<global::System.Boolean>, global::System.Boolean> Selected_Element = new();
public global::FrooxEngine.IField<global::System.Single> _colliderRadius { get => _colliderRadius_Element.Data; set => _colliderRadius_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Single>, global::FrooxEngine.IField<global::System.Single>> _colliderRadius_Element = new();
public global::FrooxEngine.IcoSphereMesh _icosphere { get => _icosphere_Element.Data; set => _icosphere_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.IcoSphereMesh>, global::FrooxEngine.IcoSphereMesh> _icosphere_Element = new();
public global::FrooxEngine.PBS_RimMetallic _material { get => _material_Element.Data; set => _material_Element.Data = value; }
public Reference<global::FrooxEngine.DriveRef<global::FrooxEngine.PBS_RimMetallic>, global::FrooxEngine.PBS_RimMetallic> _material_Element = new();
public global::FrooxEngine.LegacyRadioGroup _group { get => _group_Element.Data; set => _group_Element.Data = value; }
public Reference<global::FrooxEngine.RelayRef<global::FrooxEngine.LegacyRadioGroup>, global::FrooxEngine.LegacyRadioGroup> _group_Element = new();
public global::System.Int32 _orderNumber { get => _orderNumber_Element.Data; set => _orderNumber_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> _orderNumber_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("IsEnabled", IsEnabled_Element.ToLinkField(context));
members.Add("Radius", Radius_Element.ToLinkField(context));
members.Add("Color", Color_Element.ToLinkField(context));
members.Add("Selected", Selected_Element.ToLinkField(context));
members.Add("_colliderRadius", _colliderRadius_Element.ToLinkReference(context));
members.Add("_icosphere", _icosphere_Element.ToLinkReference(context));
members.Add("_material", _material_Element.ToLinkReference(context));
members.Add("_group", _group_Element.ToLinkReference(context));
members.Add("_orderNumber", _orderNumber_Element.ToLinkField(context));
}

}
}
