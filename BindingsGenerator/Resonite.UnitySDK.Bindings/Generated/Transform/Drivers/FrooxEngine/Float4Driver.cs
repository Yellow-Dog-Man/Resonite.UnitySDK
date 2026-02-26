
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float4Driver
// Generated on: čtvrtek 26. února 2026 12:28:07
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float4Driver")]
public partial class Float4Driver : global::FrooxEngine.Component

{
    public global::FrooxEngine.Sync<global::System.Single> X { get => X_Element.Data; set => X_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> X_Element = new();
public global::FrooxEngine.Sync<global::System.Single> Y { get => Y_Element.Data; set => Y_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> Y_Element = new();
public global::FrooxEngine.Sync<global::System.Single> Z { get => Z_Element.Data; set => Z_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> Z_Element = new();
public global::FrooxEngine.Sync<global::System.Single> W { get => W_Element.Data; set => W_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.Sync<global::System.Single>>, global::FrooxEngine.Sync<global::System.Single>> W_Element = new();
public global::FrooxEngine.IField<UnityEngine.Vector4> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.Vector4>, global::FrooxEngine.IField<UnityEngine.Vector4>> Target_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("X", X_Element.ToLinkReference(context));
members.Add("Y", Y_Element.ToLinkReference(context));
members.Add("Z", Z_Element.ToLinkReference(context));
members.Add("W", W_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
}

}
}
