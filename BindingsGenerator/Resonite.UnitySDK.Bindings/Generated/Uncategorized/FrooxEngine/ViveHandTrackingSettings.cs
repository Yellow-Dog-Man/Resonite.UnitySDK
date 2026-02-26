
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.ViveHandTrackingSettings
// Generated on: čtvrtek 26. února 2026 10:04:49
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.ViveHandTrackingSettings")]
public partial class ViveHandTrackingSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.ViveHandTrackingSettings>

{
    public global::System.Boolean ViveHandTrackingEnabled { get => ViveHandTrackingEnabled_Element.Data; set => ViveHandTrackingEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ViveHandTrackingEnabled_Element = new();
public global::System.Single SnapDistance { get => SnapDistance_Element.Data; set => SnapDistance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SnapDistance_Element = new();
public global::System.Boolean UseFingersWhenSnapped { get => UseFingersWhenSnapped_Element.Data; set => UseFingersWhenSnapped_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> UseFingersWhenSnapped_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("ViveHandTrackingEnabled", ViveHandTrackingEnabled_Element.Data.ToResoniteLinkField());
members.Add("SnapDistance", SnapDistance_Element.Data.ToResoniteLinkField());
members.Add("UseFingersWhenSnapped", UseFingersWhenSnapped_Element.Data.ToResoniteLinkField());
}

}
}
