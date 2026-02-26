
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D+ChannelConfiguration
// Generated on: čtvrtek 26. února 2026 12:26:51
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
    public partial class MultiChannelSimplexTexture3D
            {
                [Serializable]
[ResoniteTypeName("[FrooxEngine]FrooxEngine.MultiChannelSimplexTexture3D+ChannelConfiguration")]
public partial class ChannelConfiguration : global::FrooxEngine.SyncObject

{
    public UnityEngine.Vector3 Offset { get => Offset_Element.Data; set => Offset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Offset_Element = new();
public UnityEngine.Vector3 Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<UnityEngine.Vector3>, UnityEngine.Vector3> Scale_Element = new();
public global::System.Boolean Use4D { get => Use4D_Element.Data; set => Use4D_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> Use4D_Element = new();
public global::System.Single WOffset { get => WOffset_Element.Data; set => WOffset_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> WOffset_Element = new();
public global::System.Single Min { get => Min_Element.Data; set => Min_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Min_Element = new();
public global::System.Single Max { get => Max_Element.Data; set => Max_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Max_Element = new();
public global::System.Single Exp { get => Exp_Element.Data; set => Exp_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Exp_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Offset", Offset_Element.ToLinkField(context));
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("Use4D", Use4D_Element.ToLinkField(context));
members.Add("WOffset", WOffset_Element.ToLinkField(context));
members.Add("Min", Min_Element.ToLinkField(context));
members.Add("Max", Max_Element.ToLinkField(context));
members.Add("Exp", Exp_Element.ToLinkField(context));
}

}
            }
}
