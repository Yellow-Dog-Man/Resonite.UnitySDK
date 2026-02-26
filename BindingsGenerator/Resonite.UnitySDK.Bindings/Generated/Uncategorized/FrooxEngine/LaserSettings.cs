
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.LaserSettings
// Generated on: čtvrtek 26. února 2026 12:28:11
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.LaserSettings")]
public partial class LaserSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.LaserSettings>

{
    public global::System.Single SmoothSpeed { get => SmoothSpeed_Element.Data; set => SmoothSpeed_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> SmoothSpeed_Element = new();
public global::System.Single ModulateStartAngle { get => ModulateStartAngle_Element.Data; set => ModulateStartAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ModulateStartAngle_Element = new();
public global::System.Single ModulateEndAngle { get => ModulateEndAngle_Element.Data; set => ModulateEndAngle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ModulateEndAngle_Element = new();
public global::System.Single ModulateExponent { get => ModulateExponent_Element.Data; set => ModulateExponent_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ModulateExponent_Element = new();
public global::System.Single ModulateSpeedMultiplier { get => ModulateSpeedMultiplier_Element.Data; set => ModulateSpeedMultiplier_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> ModulateSpeedMultiplier_Element = new();
public global::System.Single StickThreshold { get => StickThreshold_Element.Data; set => StickThreshold_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> StickThreshold_Element = new();
public global::System.Boolean ShowInDesktop { get => ShowInDesktop_Element.Data; set => ShowInDesktop_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> ShowInDesktop_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("SmoothSpeed", SmoothSpeed_Element.ToLinkField(context));
members.Add("ModulateStartAngle", ModulateStartAngle_Element.ToLinkField(context));
members.Add("ModulateEndAngle", ModulateEndAngle_Element.ToLinkField(context));
members.Add("ModulateExponent", ModulateExponent_Element.ToLinkField(context));
members.Add("ModulateSpeedMultiplier", ModulateSpeedMultiplier_Element.ToLinkField(context));
members.Add("StickThreshold", StickThreshold_Element.ToLinkField(context));
members.Add("ShowInDesktop", ShowInDesktop_Element.ToLinkField(context));
}

}
}
