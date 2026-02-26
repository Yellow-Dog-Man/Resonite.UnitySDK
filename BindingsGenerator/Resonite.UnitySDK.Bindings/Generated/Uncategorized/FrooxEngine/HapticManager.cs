
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.HapticManager
// Generated on: čtvrtek 26. února 2026 10:04:45
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.HapticManager")]
public partial class HapticManager : global::FrooxEngine.UserRootComponent, global::FrooxEngine.ICustomInspector

{
    public global::System.Single InjectedBodyPartIntensity { get => InjectedBodyPartIntensity_Element.Data; set => InjectedBodyPartIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InjectedBodyPartIntensity_Element = new();
public global::System.Single InjectedHandIntensity { get => InjectedHandIntensity_Element.Data; set => InjectedHandIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InjectedHandIntensity_Element = new();
public global::System.Single InjectedHeadIntensity { get => InjectedHeadIntensity_Element.Data; set => InjectedHeadIntensity_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InjectedHeadIntensity_Element = new();
public global::System.Single InjectedRadiusStartRatio { get => InjectedRadiusStartRatio_Element.Data; set => InjectedRadiusStartRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InjectedRadiusStartRatio_Element = new();
public global::System.Single InjectedRadiusEndRatio { get => InjectedRadiusEndRatio_Element.Data; set => InjectedRadiusEndRatio_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InjectedRadiusEndRatio_Element = new();
public global::System.Single InjectedRadiusPower { get => InjectedRadiusPower_Element.Data; set => InjectedRadiusPower_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> InjectedRadiusPower_Element = new();
public global::System.Boolean ShowDebugVisuals { get => ShowDebugVisuals_Element.Data; set => ShowDebugVisuals_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowDebugVisuals_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("InjectedBodyPartIntensity", InjectedBodyPartIntensity_Element.Data.ToResoniteLinkField());
members.Add("InjectedHandIntensity", InjectedHandIntensity_Element.Data.ToResoniteLinkField());
members.Add("InjectedHeadIntensity", InjectedHeadIntensity_Element.Data.ToResoniteLinkField());
members.Add("InjectedRadiusStartRatio", InjectedRadiusStartRatio_Element.Data.ToResoniteLinkField());
members.Add("InjectedRadiusEndRatio", InjectedRadiusEndRatio_Element.Data.ToResoniteLinkField());
members.Add("InjectedRadiusPower", InjectedRadiusPower_Element.Data.ToResoniteLinkField());
members.Add("ShowDebugVisuals", ShowDebugVisuals_Element.Data.ToResoniteLinkField());
}

}
}
