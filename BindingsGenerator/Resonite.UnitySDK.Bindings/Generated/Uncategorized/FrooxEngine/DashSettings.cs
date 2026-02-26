
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.DashSettings
// Generated on: čtvrtek 26. února 2026 12:28:10
// Resonite version: 2026.2.26.702
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.DashSettings")]
public partial class DashSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.DashSettings>

{
    public global::System.Single DashCurvature { get => DashCurvature_Element.Data; set => DashCurvature_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> DashCurvature_Element = new();
public global::System.Single OpenCloseSpeed { get => OpenCloseSpeed_Element.Data; set => OpenCloseSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> OpenCloseSpeed_Element = new();
public global::System.Boolean AllowReplacingSettings { get => AllowReplacingSettings_Element.Data; set => AllowReplacingSettings_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> AllowReplacingSettings_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("DashCurvature", DashCurvature_Element.ToLinkField(context));
members.Add("OpenCloseSpeed", OpenCloseSpeed_Element.ToLinkField(context));
members.Add("AllowReplacingSettings", AllowReplacingSettings_Element.ToLinkField(context));
}

}
}
