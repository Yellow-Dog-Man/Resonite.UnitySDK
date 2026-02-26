
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.TimeIntDriver
// Generated on: čtvrtek 26. února 2026 15:09:08
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.TimeIntDriver")]
public partial class TimeIntDriver : global::FrooxEngine.Component

{
    public global::System.Single Scale { get => Scale_Element.Data; set => Scale_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Single>, global::System.Single> Scale_Element = new();
public global::System.Int32 Repeat { get => Repeat_Element.Data; set => Repeat_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Repeat_Element = new();
public global::System.Boolean PingPong { get => PingPong_Element.Data; set => PingPong_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Boolean>, global::System.Boolean> PingPong_Element = new();
public global::FrooxEngine.IField<global::System.Int32> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Reference<global::FrooxEngine.FieldDrive<global::System.Int32>, global::FrooxEngine.IField<global::System.Int32>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Scale", Scale_Element.ToLinkField(context));
members.Add("Repeat", Repeat_Element.ToLinkField(context));
members.Add("PingPong", PingPong_Element.ToLinkField(context));
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
