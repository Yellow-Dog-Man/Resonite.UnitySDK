
// -----------------------------------------------------------------------------
// WARNING: This is auto-generated file! DO NOT MODIFY
// Generated from type: [FrooxEngine]FrooxEngine.Float3ToColorXSwizzleDriver
// Generated on: čtvrtek 26. února 2026 12:28:02
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
[ResoniteTypeName("[FrooxEngine]FrooxEngine.Float3ToColorXSwizzleDriver")]
public partial class Float3ToColorXSwizzleDriver : global::FrooxEngine.Component

{
    public global::FrooxEngine.IField<UnityEngine.Vector3> Source { get => Source_Element.Data; set => Source_Element.Data = value; }
public Field<global::FrooxEngine.RelayRef<global::FrooxEngine.IField<UnityEngine.Vector3>>, global::FrooxEngine.IField<UnityEngine.Vector3>> Source_Element = new();
public global::FrooxEngine.IField<UnityEngine.ColorX> Target { get => Target_Element.Data; set => Target_Element.Data = value; }
public Field<global::FrooxEngine.FieldDrive<UnityEngine.ColorX>, global::FrooxEngine.IField<UnityEngine.ColorX>> Target_Element = new();
public global::System.Int32 X { get => X_Element.Data; set => X_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> X_Element = new();
public global::System.Int32 Y { get => Y_Element.Data; set => Y_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Y_Element = new();
public global::System.Int32 Z { get => Z_Element.Data; set => Z_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> Z_Element = new();
public global::System.Int32 W { get => W_Element.Data; set => W_Element.Data = value; }
public Field<global::FrooxEngine.Sync<global::System.Int32>, global::System.Int32> W_Element = new();

public override void CollectMembers(
    System.Collections.Generic.Dictionary<string, ResoniteLink.Member> members, IConversionContext context)
{
    base.CollectMembers(members, context);
members.Add("Source", Source_Element.ToLinkReference(context));
members.Add("Target", Target_Element.ToLinkReference(context));
members.Add("X", X_Element.ToLinkField(context));
members.Add("Y", Y_Element.ToLinkField(context));
members.Add("Z", Z_Element.ToLinkField(context));
members.Add("W", W_Element.ToLinkField(context));
}

}
}
