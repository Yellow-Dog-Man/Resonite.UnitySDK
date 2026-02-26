
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.EarmuffSettings
// Generated on: čtvrtek 26. února 2026 15:09:10
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.EarmuffSettings")]
public partial class EarmuffSettings : global::FrooxEngine.SettingComponent<global::FrooxEngine.EarmuffSettings>

{
    public global::System.Boolean EarmuffEnabled { get => EarmuffEnabled_Element.Data; set => EarmuffEnabled_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> EarmuffEnabled_Element = new();
public global::System.Single VolumeAttenuation { get => VolumeAttenuation_Element.Data; set => VolumeAttenuation_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> VolumeAttenuation_Element = new();
public global::System.Single Directionality { get => Directionality_Element.Data; set => Directionality_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Directionality_Element = new();
public global::System.Single Distance { get => Distance_Element.Data; set => Distance_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Distance_Element = new();
public global::System.Single Angle { get => Angle_Element.Data; set => Angle_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Angle_Element = new();
public global::System.Single TransitionStart { get => TransitionStart_Element.Data; set => TransitionStart_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TransitionStart_Element = new();
public global::System.Single TransitionLength { get => TransitionLength_Element.Data; set => TransitionLength_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> TransitionLength_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("EarmuffEnabled", EarmuffEnabled_Element.ToLinkField(context));
members.Add("VolumeAttenuation", VolumeAttenuation_Element.ToLinkField(context));
members.Add("Directionality", Directionality_Element.ToLinkField(context));
members.Add("Distance", Distance_Element.ToLinkField(context));
members.Add("Angle", Angle_Element.ToLinkField(context));
members.Add("TransitionStart", TransitionStart_Element.ToLinkField(context));
members.Add("TransitionLength", TransitionLength_Element.ToLinkField(context));
}

}
}
